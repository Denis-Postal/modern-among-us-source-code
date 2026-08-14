using System;
using System.Collections;
using System.Collections.Generic;
using AmongUs.GameOptions;
using InnerNet;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class AmongUsClient : InnerNetClient
{
	public enum MainMenuTarget
	{
		None = 0,
		OnlineMenu = 1,
		EnterCodeMenu = 2,
		FindGameMenu = 3
	}

	private const int MAX_CLIENT_WAIT_SECONDS = 10;

	public static AmongUsClient Instance;

	public string OnlineScene;

	public string MainMenuScene;

	public GameData GameDataPrefab;

	public VoteBanSystem VoteBanPrefab;

	public PlayerControl PlayerPrefab;

	public List<AssetReference> ShipPrefabs;

	public ShipStatus FreePlayShipPrefab;

	public int TutorialMapId;

	public float SpawnRadius = 1.75f;

	public DiscoveryState discoverState;

	public List<IDisconnectHandler> DisconnectHandlers = new List<IDisconnectHandler>();

	public List<IGameListHandler> GameListHandlers = new List<IGameListHandler>();

	public CrossplayPrivilegeErrorType CrossplayPrivilegeError;

	public MainMenuTarget MenuTarget;

	private readonly Logger logger = new Logger(Logger.Category.Network, "AmongUsClient");

	private AsyncOperationHandle<GameObject> ShipLoadingAsyncHandle;

	public void Awake()
	{
		if ((bool)Instance && Instance != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Instance = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 30;
		if (DisconnectHandlers == null)
		{
			DisconnectHandlers = new List<IDisconnectHandler>();
		}
		if (GameListHandlers == null)
		{
			GameListHandlers = new List<IGameListHandler>();
		}
	}

	public void StartGame()
	{
		SendStartGame();
		discoverState = DiscoveryState.Off;
	}

	public override void Update()
	{
		base.Update();
	}

	public void ExitGame(DisconnectReasons reason)
	{
		if (DestroyableSingleton<WaitForHostPopup>.InstanceExists)
		{
			DestroyableSingleton<WaitForHostPopup>.Instance.Hide();
		}
		if ((bool)SoundManager.Instance)
		{
			SoundManager.Instance.StopAllSound();
		}
		discoverState = DiscoveryState.Off;
		DisconnectHandlers.Clear();
		DisconnectInternal(reason);
		LoadMainMenuScene();
	}

	protected override void OnGetGameList(TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse gamesResponse)
	{
		for (int i = GameListHandlers.Count - 1; i >= 0; i--)
		{
			try
			{
				GameListHandlers[i].HandleList(totalGames, gamesResponse);
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				GameListHandlers.RemoveAt(i);
			}
		}
	}

	protected override void OnReportedPlayer(ReportOutcome outcome, int clientId, string playerName, ReportReasons reason)
	{
	}

	protected override void OnGameCreated(string gameIdString)
	{
	}

	protected override void OnWaitForHost(string gameIdString)
	{
		Debug.Log("Waiting for host: " + gameIdString);
		if (DestroyableSingleton<WaitForHostPopup>.InstanceExists)
		{
			DestroyableSingleton<WaitForHostPopup>.Instance.Show();
		}
	}

	protected void AbortLoadingAssets()
	{
		if (ShipLoadingAsyncHandle.IsValid())
		{
			Addressables.Release(ShipLoadingAsyncHandle);
		}
	}

	protected IEnumerator CoStartGameHost()
	{
		if (!ShipStatus.Instance)
		{
			yield return CoLoadShip(GetSelectedMapId());
		}
		if (!ShipStatus.Instance)
		{
			EnqueueDisconnect(DisconnectReasons.Error, "Could not load ship prefab.");
			yield break;
		}
		Spawn(ShipStatus.Instance);
		ShipStatus.Instance.Begin();
	}

	public void KickNotJoinedPlayers()
	{
	}

	protected IEnumerator CoStartGameClient()
	{
		float timer = 0f;
		while (!ShipStatus.Instance && timer < MAX_CLIENT_WAIT_SECONDS)
		{
			timer += Time.deltaTime;
			yield return null;
		}
		if (!ShipStatus.Instance)
		{
			EnqueueDisconnect(DisconnectReasons.Error, "Timed out waiting for ship prefab.");
		}
	}

	private IEnumerator CoWaitForDisconnect()
	{
		while (mode != MatchMakerModes.None)
		{
			yield return null;
		}
	}

	protected override IEnumerator CoStartGame()
	{
		while (!GameData.Instance)
		{
			yield return null;
		}
		CleanupLobbyStateForGame();
		if (DestroyableSingleton<GameStartManager>.InstanceExists)
		{
			DisconnectHandlers.Remove(DestroyableSingleton<GameStartManager>.Instance);
			UnityEngine.Object.Destroy(DestroyableSingleton<GameStartManager>.Instance.gameObject);
		}
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			yield return DestroyableSingleton<HudManager>.Instance.CoFadeFullScreen(Color.clear, Color.black);
		}
		SendClientReady();
		if (AmHost)
		{
			yield return CoStartGameHost();
		}
		else
		{
			yield return CoStartGameClient();
		}
		EnablePlayersForGame();
	}

	protected override void OnBecomeHost()
	{
		ClientData clientData = FindClientById(ClientId);
		if (clientData != null && !clientData.Character)
		{
			StartCoroutine(CoOnPlayerChangedScene(clientData, SceneManager.GetActiveScene().name));
		}
		Debug.Log("Became Host");
		RemoveUnownedObjects();
	}

	protected override void OnGameEnd(EndGameResult endGameResult)
	{
		DisconnectHandlers.Clear();
		Minigame minigame = UnityEngine.Object.FindObjectOfType<Minigame>();
		if ((bool)minigame)
		{
			minigame.Close();
		}
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.moveable = false;
		}
		EndGameResult.CachedGameOverReason = endGameResult.GameOverReason;
		EndGameResult.CachedShowAd = endGameResult.ShowAd;
		EndGameResult.CachedLocalPlayer = PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.Data != null ? new CachedPlayerData(PlayerControl.LocalPlayer.Data) : null;
		EndGameResult.CachedWinners = BuildWinnerCache(endGameResult.GameOverReason);
		StartCoroutine(CoEndGame());
	}

	public IEnumerator CoEndGame()
	{
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			yield return DestroyableSingleton<HudManager>.Instance.CoFadeFullScreen(Color.clear, Color.black, 0.5f);
		}
		SceneManager.LoadScene("EndGame");
	}

	protected override void OnPlayerJoined(ClientData data)
	{
		if (AmHost && data.InScene && !data.Character)
		{
			StartCoroutine(CreatePlayer(data));
		}
	}

	protected override void OnGameJoined(string gameIdString)
	{
		if (DestroyableSingleton<WaitForHostPopup>.InstanceExists)
		{
			DestroyableSingleton<WaitForHostPopup>.Instance.Hide();
		}
		if (!string.IsNullOrWhiteSpace(OnlineScene))
		{
			SceneManager.LoadScene(OnlineScene);
		}
	}

	protected override void OnPlayerLeft(ClientData data, DisconnectReasons reason)
	{
		if (data != null && (bool)data.Character)
		{
			for (int i = DisconnectHandlers.Count - 1; i >= 0; i--)
			{
				try
				{
					DisconnectHandlers[i].HandleDisconnect(data.Character, reason);
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
					DisconnectHandlers.RemoveAt(i);
				}
			}
			UnityEngine.Object.Destroy(data.Character.gameObject);
			return;
		}
		for (int j = DisconnectHandlers.Count - 1; j >= 0; j--)
		{
			try
			{
				DisconnectHandlers[j].HandleDisconnect();
			}
			catch (Exception exception2)
			{
				Debug.LogException(exception2);
				DisconnectHandlers.RemoveAt(j);
			}
		}
	}

	protected override void PreDisconnectInternal()
	{
		AbortLoadingAssets();
		discoverState = DiscoveryState.Off;
		if (DestroyableSingleton<InnerDiscover>.InstanceExists)
		{
			DestroyableSingleton<InnerDiscover>.Instance.StopServer();
		}
	}

	protected override void OnDisconnected()
	{
		GameData.OnDisconnected();
		LoadMainMenuScene();
	}

	private void DestroyPlayerInfoObjects()
	{
		if (!GameData.Instance)
		{
			return;
		}
		for (int i = GameData.Instance.AllPlayers.Count - 1; i >= 0; i--)
		{
			NetworkedPlayerInfo playerInfo = GameData.Instance.AllPlayers[i];
			if ((bool)playerInfo)
			{
				UnityEngine.Object.Destroy(playerInfo.gameObject);
			}
		}
	}

	protected override IEnumerator CoOnPlayerChangedScene(ClientData client, string currentScene)
	{
		client.InScene = true;
		if (!AmHost)
		{
			yield break;
		}
		if (IsFreeplayScene(currentScene))
		{
			EnsureGameData();
			if (!ShipStatus.Instance)
			{
				yield return CoLoadShip(GetSelectedMapId());
				if ((bool)ShipStatus.Instance && NetworkMode != NetworkModes.FreePlay)
				{
					Spawn(ShipStatus.Instance);
				}
			}
			yield return CreatePlayer(client);
			yield break;
		}
		if (!currentScene.Equals("OnlineGame", StringComparison.OrdinalIgnoreCase))
		{
			yield break;
		}
		if (client.Id != ClientId)
		{
			SendInitialData(client.Id);
		}
		else
		{
			if (NetworkMode == NetworkModes.LocalGame)
			{
				StartCoroutine(CoBroadcastManager());
			}
			EnsureGameData();
			EnsureLobby();
		}
		if (!client.Character)
		{
			yield return CreatePlayer(client);
		}
	}

	private void EnsureLobby()
	{
		if ((bool)LobbyBehaviour.Instance || (bool)ShipStatus.Instance)
		{
			return;
		}
		GameStartManager gameStartManager = UnityEngine.Object.FindObjectOfType<GameStartManager>();
		if (!(bool)gameStartManager || !(bool)gameStartManager.LobbyPrefab)
		{
			return;
		}
		LobbyBehaviour lobbyBehaviour = UnityEngine.Object.Instantiate(gameStartManager.LobbyPrefab);
		LobbyBehaviour.Instance = lobbyBehaviour;
		Spawn(lobbyBehaviour);
	}

	private IEnumerator CreatePlayer(ClientData clientData)
	{
		if (!AmHost)
		{
			Debug.Log("Waiting for host to make my player");
			yield break;
		}
		EnsureGameData();
		if (!GameData.Instance || !PlayerPrefab)
		{
			yield break;
		}
		if (clientData.IsBeingCreated)
		{
			yield break;
		}
		clientData.IsBeingCreated = true;
		sbyte availableId = GameData.Instance.GetAvailableId();
		if (availableId < 0)
		{
			clientData.IsBeingCreated = false;
			yield break;
		}
		byte playerId = (byte)availableId;
		Vector2 spawnLocation = GetPlayerSpawnLocation(playerId);
		PlayerControl playerControl = UnityEngine.Object.Instantiate(PlayerPrefab, spawnLocation, Quaternion.identity);
		playerControl.PlayerId = playerId;
		playerControl.FriendCode = clientData.FriendCode;
		playerControl.Puid = clientData.ProductUserId;
		clientData.Character = playerControl;
		Spawn(playerControl, clientData.Id, SpawnFlags.IsClientCharacter);
		GameData.Instance.AddPlayer(playerControl, clientData);
		if (NetworkMode == NetworkModes.FreePlay && playerControl.Data != null)
		{
			playerControl.Data.IsDead = false;
		}
		clientData.IsBeingCreated = false;
		yield return null;
	}

	private IEnumerator CoBroadcastManager()
	{
		while (!GameData.Instance)
		{
			yield return null;
		}
		int lastPlayerCount = -1;
		discoverState = DiscoveryState.Broadcast;
		while (discoverState == DiscoveryState.Broadcast)
		{
			int playerCount = GetPlayerCount();
			if (lastPlayerCount != playerCount)
			{
				lastPlayerCount = playerCount;
				string code = GameCode.IntToGameName(GameId) ?? string.Empty;
				string data = string.Format("{0}~Open~{1}~{2}~", GetLocalPlayerName(), playerCount, code);
				DestroyableSingleton<InnerDiscover>.Instance.Interval = 1f;
				DestroyableSingleton<InnerDiscover>.Instance.StartAsServer(data);
			}
			yield return null;
		}
		if (DestroyableSingleton<InnerDiscover>.InstanceExists)
		{
			DestroyableSingleton<InnerDiscover>.Instance.StopServer();
		}
	}

	public void CheckOnlinePermissions(Action success, Action failure, Action loadingCallback, bool checkOnline = true)
	{
		loadingCallback?.Invoke();
		success?.Invoke();
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	private static void InitSceneChangeListener()
	{
		SceneManager.activeSceneChanged -= OnActiveSceneChange;
		SceneManager.activeSceneChanged += OnActiveSceneChange;
	}

	private static void OnActiveSceneChange(Scene from, Scene to)
	{
		if ((bool)Instance && Instance.mode != MatchMakerModes.None)
		{
			ClientData client = Instance.GetClient(Instance.ClientId);
			if (client != null)
			{
				Instance.StartCoroutine(Instance.CoOnPlayerChangedScene(client, to.name));
			}
		}
	}

	public IEnumerator CoCreateOnlineGame()
	{
		NetworkMode = NetworkModes.OnlineGame;
		MainMenuScene = "MMOnline";
		OnlineScene = "OnlineGame";
		HostGame(GetHostOptions(), new GameFilterOptions());
		yield return WaitForConnectionOrFail();
	}

	public IEnumerator CoJoinOnlinePublicGame(int gameId, string ipAddress, ushort port, MainMenuTarget targetMenu = MainMenuTarget.OnlineMenu)
	{
		MenuTarget = targetMenu;
		yield return CoJoinOnlineGameDirect(gameId, ipAddress, port, null);
	}

	public IEnumerator CoJoinOnlineGameFromListing(GameListing game, string matchmakerToken)
	{
		yield return CoJoinOnlineGameDirect(game.GameId, game.IPString, game.Port, matchmakerToken);
	}

	public IEnumerator CoJoinOnlineGameFromCode(int gameId, bool fromEnterCode = false)
	{
		yield return CoFindGameInfoFromCodeAndJoin(gameId);
	}

	public IEnumerator CoFindGameInfoFromCode(int gameId, Action<HttpMatchmakerManager.FindGameByCodeResponse, string> callback)
	{
		yield return DestroyableSingleton<HttpMatchmakerManager>.Instance.CoFindGameInfo(gameId, callback);
	}

	public IEnumerator CoFindGameInfoFromCodeAndJoin(int gameId)
	{
		HttpMatchmakerManager.FindGameByCodeResponse response = null;
		string token = null;
		yield return CoFindGameInfoFromCode(gameId, delegate(HttpMatchmakerManager.FindGameByCodeResponse found, string matchmakerToken)
		{
			response = found;
			token = matchmakerToken;
		});
		if (response != null)
		{
			yield return CoJoinOnlineGameFromListing(response.Game, token);
		}
	}

	public IEnumerator CoFindGame()
	{
		RequestGameList(GetSearchOptions(), new GameFilterOptions());
		yield return WaitForConnectionOrFail();
	}

	private IEnumerator CoConnectToGameServer(MatchMakerModes connectMode, string ipAddress, ushort port, string matchmakerToken)
	{
		SetEndpoint(ipAddress, port, false);
		OnlineScene = "OnlineGame";
		Connect(connectMode, matchmakerToken);
		yield return WaitForConnectionOrFail();
	}

	private IEnumerator CoJoinOnlineGameDirect(int gameId, string ipAddress, ushort port, string matchmakerToken)
	{
		NetworkMode = NetworkModes.OnlineGame;
		GameId = gameId;
		MainMenuScene = "MMOnline";
		yield return CoConnectToGameServer(MatchMakerModes.Client, ipAddress, port, matchmakerToken);
	}

	private void EnsureGameData()
	{
		if (!GameData.Instance && (bool)GameDataPrefab)
		{
			GameData.Instance = UnityEngine.Object.Instantiate(GameDataPrefab);
		}
	}

	private IEnumerator CoLoadShip(byte mapId)
	{
		if (ShipPrefabs == null || ShipPrefabs.Count == 0)
		{
			if (TryInstantiateShipPrefab(LoadShipPrefabFromProject(mapId)))
			{
				yield break;
			}
			if ((bool)FreePlayShipPrefab && NetworkMode == NetworkModes.FreePlay)
			{
				ShipStatus.Instance = UnityEngine.Object.Instantiate(FreePlayShipPrefab);
			}
			yield break;
		}
		int index = Mathf.Clamp(mapId, 0, ShipPrefabs.Count - 1);
		AssetReference shipReference = ShipPrefabs[index];
		if (shipReference != null)
		{
			ShipLoadingAsyncHandle = shipReference.InstantiateAsync();
			yield return ShipLoadingAsyncHandle;
			if (ShipLoadingAsyncHandle.Status == AsyncOperationStatus.Succeeded && (bool)ShipLoadingAsyncHandle.Result)
			{
				ShipStatus.Instance = ShipLoadingAsyncHandle.Result.GetComponent<ShipStatus>();
				if (!ShipStatus.Instance)
				{
					ShipStatus.Instance = ShipLoadingAsyncHandle.Result.GetComponentInChildren<ShipStatus>(true);
				}
				if ((bool)ShipStatus.Instance)
				{
					ShipLoadingAsyncHandle.Result.SetActive(true);
					ShipStatus.Instance.gameObject.SetActive(true);
					yield break;
				}
				UnityEngine.Object.Destroy(ShipLoadingAsyncHandle.Result);
			}
			GameObject shipPrefab = CosmeticAssetLoader.LoadReference<GameObject>(shipReference);
			if (TryInstantiateShipPrefab(shipPrefab))
			{
				yield break;
			}
		}
		if (TryInstantiateShipPrefab(LoadShipPrefabFromProject(index)))
		{
			yield break;
		}
		if ((bool)FreePlayShipPrefab && NetworkMode == NetworkModes.FreePlay)
		{
			ShipStatus.Instance = UnityEngine.Object.Instantiate(FreePlayShipPrefab);
			if ((bool)ShipStatus.Instance)
			{
				ShipStatus.Instance.gameObject.SetActive(true);
			}
		}
	}

	private bool TryInstantiateShipPrefab(GameObject shipPrefab)
	{
		if (!shipPrefab)
		{
			return false;
		}
		GameObject shipObject = UnityEngine.Object.Instantiate(shipPrefab);
		ShipStatus.Instance = shipObject.GetComponent<ShipStatus>();
		if (!ShipStatus.Instance)
		{
			ShipStatus.Instance = shipObject.GetComponentInChildren<ShipStatus>(true);
		}
		if ((bool)ShipStatus.Instance)
		{
			shipObject.SetActive(true);
			ShipStatus.Instance.gameObject.SetActive(true);
			return true;
		}
		UnityEngine.Object.Destroy(shipObject);
		return false;
	}

	private static GameObject LoadShipPrefabFromProject(int mapIndex)
	{
#if UNITY_EDITOR
		string[] paths = new string[6]
		{
			"Assets/Ship/SkeldShip.prefab",
			"Assets/HeadQuarters/MiraShip.prefab",
			"Assets/PlanetMap/PolusShip.prefab",
			"Assets/Ship/AprilShip.prefab",
			"Assets/Airship/Airship.prefab",
			"Assets/Fungle/FungleShip.prefab"
		};
		mapIndex = Mathf.Clamp(mapIndex, 0, paths.Length - 1);
		return UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(paths[mapIndex]);
#else
		return null;
#endif
	}

	private byte GetSelectedMapId()
	{
		if (NetworkMode == NetworkModes.FreePlay)
		{
			return (byte)Mathf.Max(TutorialMapId, 0);
		}
		IGameOptions hostOptions = GetHostOptions();
		if (hostOptions != null)
		{
			return hostOptions.MapId;
		}
		return 0;
	}

	private IGameOptions GetHostOptions()
	{
		return GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameHostOptions : null;
	}

	private IGameOptions GetSearchOptions()
	{
		return GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameSearchOptions : null;
	}

	private Vector2 GetPlayerSpawnLocation(byte playerId)
	{
		if ((bool)LobbyBehaviour.Instance && LobbyBehaviour.Instance.SpawnPositions != null && LobbyBehaviour.Instance.SpawnPositions.Length > 0)
		{
			return LobbyBehaviour.Instance.SpawnPositions[playerId % LobbyBehaviour.Instance.SpawnPositions.Length];
		}
		if ((bool)ShipStatus.Instance)
		{
			int playerCount = Mathf.Max(GetPlayerCount() + 1, 1);
			float angle = (float)playerId * (360f / (float)playerCount);
			float radius = Mathf.Max(ShipStatus.Instance.SpawnRadius, 0.5f);
			return ShipStatus.Instance.InitialSpawnCenter + Vector2.up.Rotate(angle) * radius;
		}
		int colorCount = Palette.PlayerColors != null && Palette.PlayerColors.Length > 0 ? Palette.PlayerColors.Length : 15;
		return Vector2.up.Rotate((float)playerId * (360f / (float)colorCount)) * SpawnRadius;
	}

	private int GetPlayerCount()
	{
		return GameData.Instance != null && GameData.Instance.AllPlayers != null ? GameData.Instance.AllPlayers.Count : 0;
	}

	private void EnablePlayersForGame()
	{
		if (!GameData.Instance || !ShipStatus.Instance || GameData.Instance.AllPlayers == null)
		{
			return;
		}
		for (int i = 0; i < GameData.Instance.AllPlayers.Count; i++)
		{
			PlayerControl player = GameData.Instance.AllPlayers[i].Object;
			if (!(bool)player)
			{
				continue;
			}
			player.NetTransform.enabled = true;
			player.MyPhysics.enabled = true;
			player.MyPhysics.Awake();
			player.MyPhysics.ResetAnimState();
			player.Collider.enabled = true;
			ShipStatus.Instance.SpawnPlayer(player, GameData.Instance.AllPlayers.Count, false);
		}
	}

	private void CleanupLobbyStateForGame()
	{
		if ((bool)SoundManager.Instance)
		{
			SoundManager.Instance.StopAllSound();
		}
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			HudManager hud = DestroyableSingleton<HudManager>.Instance;
			if ((bool)hud.Chat)
			{
				hud.Chat.ForceClosed();
				hud.Chat.SetVisible(false);
			}
		}
		if ((bool)LobbyBehaviour.Instance)
		{
			LobbyBehaviour.Instance.StopAllCoroutines();
			LobbyBehaviour.Instance.gameObject.SetActive(false);
		}
	}

	private static bool IsFreeplayScene(string sceneName)
	{
		return string.Equals(sceneName, "Tutorial", StringComparison.OrdinalIgnoreCase) || ((bool)Instance && Instance.NetworkMode == NetworkModes.FreePlay);
	}

	private static string GetLocalPlayerName()
	{
		return PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.Data != null ? PlayerControl.LocalPlayer.Data.PlayerName : "Player";
	}

	private List<CachedPlayerData> BuildWinnerCache(GameOverReason reason)
	{
		List<CachedPlayerData> winners = new List<CachedPlayerData>();
		if (!GameData.Instance || GameData.Instance.AllPlayers == null)
		{
			return winners;
		}
		for (int i = 0; i < GameData.Instance.AllPlayers.Count; i++)
		{
			NetworkedPlayerInfo playerInfo = GameData.Instance.AllPlayers[i];
			if (playerInfo != null && playerInfo.Role != null && playerInfo.Role.DidWin(reason))
			{
				winners.Add(new CachedPlayerData(playerInfo));
			}
		}
		return winners;
	}

	private void LoadMainMenuScene()
	{
		string sceneName = string.IsNullOrEmpty(MainMenuScene) ? "MainMenu" : MainMenuScene;
		SceneManager.LoadScene(sceneName);
	}
}
