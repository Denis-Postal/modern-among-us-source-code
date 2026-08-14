using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using AmongUs.InnerNet.GameDataMessages;
using Hazel;
using Hazel.Udp;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace InnerNet
{
	public abstract class InnerNetClient : MonoBehaviour
	{
		public enum GameStates
		{
			NotJoined = 0,
			Joined = 1,
			Started = 2,
			Ended = 3
		}

		public class TotalGameData
		{
			public int[] PerMapTotals;
		}

		private class RecentPlayerComparer : IComparer<ClientData>
		{
			public static readonly RecentPlayerComparer Instance;

			public int Compare(ClientData x, ClientData y)
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass166_0
		{
			public uint spawnId;

			internal bool _003CCoHandleSpawn_003Eb__0(InnerNetObject f)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoConnect_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InnerNetClient _003C_003E4__this;

			public string matchmakerToken;

			private string _003CipAddr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoConnect_003Ed__65(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoConnect_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InnerNetClient _003C_003E4__this;

			public MatchMakerModes mode;

			public string matchmakerToken;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoConnect_003Ed__69(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoHandleSpawn_003Ed__166 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MessageReader reader;

			public InnerNetClient _003C_003E4__this;

			private _003C_003Ec__DisplayClass166_0 _003C_003E8__1;

			private int _003CownerId_003E5__2;

			private ClientData _003CownerClient_003E5__3;

			private int _003Cframes_003E5__4;

			private AsyncOperationHandle<GameObject> _003CspawnPrefab_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoHandleSpawn_003Ed__166(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoSendSceneChange_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InnerNetClient _003C_003E4__this;

			public string sceneName;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoSendSceneChange_003Ed__156(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CHandleGameDataInner_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MessageReader reader;

			public InnerNetClient _003C_003E4__this;

			public int msgNum;

			private int _003Ccnt_003E5__2;

			private InnerNetObjectCollection _003C_003E7__wrap2;

			private bool _003C_003E7__wrap3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CHandleGameDataInner_003Ed__165(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			private void _003C_003Em__Finally4()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitForConnectionOrFail_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InnerNetClient _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitForConnectionOrFail_003Ed__70(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitWithTimeout_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Func<bool> success;

			public InnerNetClient _003C_003E4__this;

			public int durationSeconds;

			public string errorMessage;

			private bool _003Cfailed_003E5__2;

			private float _003Ctimer_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitWithTimeout_003Ed__71(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static readonly HashSet<DisconnectReasons> DontBotherLoggingTheseDisconnectReasons;

		public const int MaxRecentClients = 20;

		private const int DefaultSecondsSuspendedBeforeDisconnect = 30;

		public static int SecondsSuspendedBeforeDisconnect;

		public const int NoClientId = -1;

		private readonly Logger serverLogger;

		private string networkAddress;

		private int networkPort;

		private bool useDtls;

		private UnityUdpClientConnection connection;

		public MatchMakerModes mode;

		public NetworkModes NetworkMode;

		public int GameId;

		public int HostId;

		public int ClientId;

		protected List<ClientData> allClients = new List<ClientData>();

		protected CircleBuffer<ClientData> recentClients;

		public DisconnectReasons LastDisconnectReason;

		public string LastCustomDisconnect;

		public byte LastServerChatMode;

		public HttpMatchmakerManager.MatchmakerError LastMatchmakerError;

		private readonly List<Action> PreSpawnDispatcher = new List<Action>();

		private readonly List<Action> Dispatcher = new List<Action>();

		private readonly List<SpawnGameDataMessage> sendInitialDataSpawnGameDataMessages = new List<SpawnGameDataMessage>();

		private readonly GameOptionsFactory gameOptionsFactory;

		public GameStates GameState;

		private bool isConnecting;

		private bool platformSpecificsChecked;

		private List<Action> TempQueue;

		private bool appPaused;

		public const int CurrentClient = -3;

		public const int HostInherit = -2;

		public const int ServerOwned = -4;

		public const int MinServerID = 100000;

		private const int MaxMessageSizeBytes = 500;

		public float MinSendInterval;

		private uint NetIdCnt;

		private float timer;

		public AssetReference[] SpawnableObjects;

		public InnerNetObject[] NonAddressableSpawnableObjects;

		protected InnerNetObjectCollection allObjects = new InnerNetObjectCollection();

		private bool InOnlineScene;

		private HashSet<uint> DestroyedObjects = new HashSet<uint>();

		private Queue<IGameDataMessage> reliableMessageQueue = new Queue<IGameDataMessage>();

		private Queue<IGameDataMessage> unreliableMessageQueue = new Queue<IGameDataMessage>();

		private int numberOfConsecutiveFramesWithReliableMessages;

		private int numberOfConsecutiveFramesWithUnreliableMessages;

		private int indexForReliableStreamedUpdates;

		private int indexForUnreliableStreamedUpdates;

		private int msgNum;

		public bool AmConnected => mode != MatchMakerModes.None && ClientId >= 0;

		public int Ping => 0;

		public int BytesSent => 0;

		public int BytesGot => 0;

		public int Resends => 0;

		public bool AmHost => mode != MatchMakerModes.None && HostId == ClientId && ClientId >= 0;

		public bool AmLocalHost => AmHost && NetworkMode == NetworkModes.LocalGame;

		public bool AmModdedHost => AmHost;

		public bool AmClient => mode != MatchMakerModes.None && ClientId >= 0;

		public bool IsGamePublic { get; private set; }

		public bool IsGameStarted => GameState == GameStates.Started;

		public bool IsGameOver => GameState == GameStates.Ended;

		public bool IsInGame => GameState == GameStates.Joined || GameState == GameStates.Started;

		public void SetEndpoint(string addr, ushort port, bool dtls)
		{
			networkAddress = addr;
			networkPort = port;
			useDtls = dtls;
		}

		public virtual void Start()
		{
			ClientId = -1;
			HostId = -1;
			GameState = GameStates.NotJoined;
			if (allClients == null)
			{
				allClients = new List<ClientData>();
			}
			if (allObjects == null)
			{
				allObjects = new InnerNetObjectCollection();
			}
		}

		private void SendOrDisconnect(MessageWriter msg)
		{
		}

		public ClientData GetHost()
		{
			return FindClientById(HostId);
		}

		public ClientData GetClientFromCharacter(PlayerControl character)
		{
			if (character == null || allClients == null)
			{
				return null;
			}
			for (int i = 0; i < allClients.Count; i++)
			{
				if (allClients[i].Character == character)
				{
					return allClients[i];
				}
			}
			return null;
		}

		public ClientData GetClientFromPlayerInfo(NetworkedPlayerInfo playerInfo)
		{
			if (playerInfo == null || allClients == null)
			{
				return null;
			}
			for (int i = 0; i < allClients.Count; i++)
			{
				if (allClients[i].Id == playerInfo.ClientId)
				{
					return allClients[i];
				}
			}
			return null;
		}

		public int GetClientIdFromCharacter(PlayerControl character)
		{
			ClientData client = GetClientFromCharacter(character);
			return client != null ? client.Id : -1;
		}

		public virtual void OnDestroy()
		{
			DisconnectInternal(DisconnectReasons.Destroy);
		}

		[IteratorStateMachine(typeof(_003CCoConnect_003Ed__65))]
		public IEnumerator CoConnect(string matchmakerToken)
		{
			return null;
		}

		private void Connection_DataReceivedRaw(byte[] data)
		{
		}

		private void Connection_DataSentRaw(byte[] data, int length)
		{
		}

		public void Connect(MatchMakerModes mode, string matchmakerToken)
		{
			StartCoroutine(CoConnect(mode, matchmakerToken));
		}

		private IEnumerator CoConnect(MatchMakerModes mode, string matchmakerToken)
		{
			if (this.mode != MatchMakerModes.None)
			{
				DisconnectInternal(DisconnectReasons.NewConnection);
			}
			this.mode = mode;
			isConnecting = true;
			yield return null;
			if (mode == MatchMakerModes.HostAndClient)
			{
				ClientId = 1;
				HostId = ClientId;
				if (GameId == 0)
				{
					GameId = UnityEngine.Random.Range(100000, 999999);
				}
				GameState = GameStates.Joined;
				ClientData localClient = GetOrCreateClient(new ClientData(ClientId, GetLocalPlayerName(), null, 0u, string.Empty, string.Empty));
				localClient.InScene = false;
				OnGameCreated(GameCode.IntToGameName(GameId) ?? GameId.ToString());
				OnGameJoined(GameCode.IntToGameName(GameId) ?? GameId.ToString());
			}
			else if (mode == MatchMakerModes.Client)
			{
				ClientId = 1;
				HostId = 1;
				GameState = GameStates.Joined;
				GetOrCreateClient(new ClientData(ClientId, GetLocalPlayerName(), null, 0u, string.Empty, string.Empty));
				OnGameJoined(GameCode.IntToGameName(GameId) ?? GameId.ToString());
			}
			isConnecting = false;
		}

		public IEnumerator WaitForConnectionOrFail()
		{
			float timer = 0f;
			while (mode != MatchMakerModes.None && timer < 5f)
			{
				if (mode == MatchMakerModes.HostAndClient && GameId != 0 && ClientId >= 0)
				{
					yield break;
				}
				if (mode == MatchMakerModes.Client && ClientId >= 0)
				{
					yield break;
				}
				timer += Time.deltaTime;
				yield return null;
			}
			if (mode != MatchMakerModes.None)
			{
				EnqueueDisconnect(DisconnectReasons.Error, "Timed out waiting for local connection.");
			}
		}

		private IEnumerator WaitWithTimeout(Func<bool> success, string errorMessage, int durationSeconds = 15)
		{
			for (float timer = 0f; timer < durationSeconds; timer += Time.deltaTime)
			{
				if (success == null || success())
				{
					yield break;
				}
				yield return null;
			}
			EnqueueDisconnect(DisconnectReasons.Error, errorMessage);
		}

		public virtual void Update()
		{
			if (Dispatcher.Count <= 0)
			{
				return;
			}
			List<Action> actions = new List<Action>(Dispatcher);
			Dispatcher.Clear();
			for (int i = 0; i < actions.Count; i++)
			{
				try
				{
					actions[i]?.Invoke();
				}
				catch (Exception exception)
				{
					UnityEngine.Debug.LogException(exception);
				}
			}
		}

		private void OnDisconnect(object sender, DisconnectedEventArgs e)
		{
		}

		public void HandleDisconnect(DisconnectReasons reason, string stringReason = null)
		{
			DisconnectInternal(reason, stringReason);
			OnDisconnected();
		}

		public void EnqueueDisconnect(DisconnectReasons reason, string stringReason = null)
		{
			Dispatcher.Clear();
			Dispatcher.Add(delegate
			{
				HandleDisconnect(reason, stringReason);
			});
		}

		protected void DisconnectInternal(DisconnectReasons reason, string stringReason = null)
		{
			PreDisconnectInternal();
			mode = MatchMakerModes.None;
			GameState = GameStates.NotJoined;
			ClientId = -1;
			HostId = -1;
			isConnecting = false;
			LastDisconnectReason = reason;
			LastCustomDisconnect = stringReason;
			if (allClients != null)
			{
				allClients.Clear();
			}
			if (allObjects != null)
			{
				allObjects.Clear();
			}
			DestroyedObjects?.Clear();
		}

		public void HostGame(IGameOptions settings, GameFilterOptions filterOpts)
		{
		}

		public void ReportPlayer(int clientId, ReportReasons reason)
		{
		}

		public void JoinGame()
		{
		}

		public bool CanBan()
		{
			return AmHost;
		}

		public bool CanKick()
		{
			return AmHost;
		}

		public void KickPlayer(int clientId, bool ban)
		{
			ClientData client = FindClientById(clientId);
			if (client == null)
			{
				return;
			}
			allClients.Remove(client);
			recentClients?.Add(client);
			OnPlayerLeft(client, ban ? DisconnectReasons.Banned : DisconnectReasons.Kicked);
		}

		public MessageWriter StartEndGame()
		{
			return null;
		}

		public void FinishEndGame(MessageWriter msg)
		{
		}

		protected void SendLateRejection(int targetId, DisconnectReasons reason)
		{
		}

		protected void SendClientReady()
		{
			ClientData client = FindClientById(ClientId);
			if (client != null)
			{
				client.IsReady = true;
			}
		}

		protected void SendStartGame()
		{
			if (GameState == GameStates.Started)
			{
				return;
			}
			GameState = GameStates.Started;
			StartCoroutine(CoStartGame());
		}

		public void RequestGameList(IGameOptions settings, GameFilterOptions filterOpts)
		{
		}

		public void ChangeGamePublic(bool isPublic)
		{
			IsGamePublic = isPublic;
		}

		public void SetGameSession(string session)
		{
		}

		public void SetActivePodType(string podType)
		{
		}

		public void QueryPlatformIds()
		{
		}

		private void OnQueryPlatformData(List<PlatformSpecificData> playerData)
		{
		}

		private void OnMessageReceived(Hazel.DataReceivedEventArgs e)
		{
		}

		private void HandleMessage(MessageReader reader, SendOption sendOption)
		{
		}

		public static string AddressToString(uint address)
		{
			byte[] bytes = BitConverter.GetBytes(address);
			return string.Format("{0}.{1}.{2}.{3}", bytes[0], bytes[1], bytes[2], bytes[3]);
		}

		private ClientData GetOrCreateClient(ClientData client)
		{
			if (client == null)
			{
				return null;
			}
			if (allClients == null)
			{
				allClients = new List<ClientData>();
			}
			ClientData existing = FindClientById(client.Id);
			if (existing != null)
			{
				existing.UpdatePlayerName(client.PlayerName);
				return existing;
			}
			allClients.Add(client);
			return client;
		}

		public ClientData GetClient(int clientId)
		{
			return FindClientById(clientId);
		}

		public void GetAllClients(List<ClientData> buffer)
		{
			if (buffer == null)
			{
				return;
			}
			buffer.Clear();
			if (allClients != null)
			{
				buffer.AddRange(allClients);
			}
		}

		public void GetRecentClients(List<ClientData> buffer)
		{
			if (buffer == null)
			{
				return;
			}
			buffer.Clear();
			if (recentClients == null)
			{
				return;
			}
			foreach (ClientData client in recentClients)
			{
				if (client != null)
				{
					buffer.Add(client);
				}
			}
		}

		public ClientData GetRecentClient(int clientId)
		{
			if (recentClients != null)
			{
				foreach (ClientData client in recentClients)
				{
					if (client != null && client.Id == clientId)
					{
						return client;
					}
				}
			}
			return null;
		}

		private void RemovePlayer(int playerIdThatLeft, DisconnectReasons reason)
		{
			KickPlayer(playerIdThatLeft, reason == DisconnectReasons.Banned);
		}

		protected virtual void OnApplicationPause(bool pause)
		{
		}

		private void WaitToDisconnect(object state)
		{
		}

		protected void SendInitialData(int clientId)
		{
		}

		private void SendGameManager(int clientId, GameManager gameManager)
		{
		}

		protected abstract void OnGameCreated(string gameIdString);

		protected abstract void OnGameJoined(string gameIdString);

		protected abstract void OnWaitForHost(string gameIdString);

		protected abstract IEnumerator CoStartGame();

		protected abstract void OnGameEnd(EndGameResult endGameResult);

		protected abstract void OnBecomeHost();

		protected abstract void OnPlayerJoined(ClientData client);

		protected abstract IEnumerator CoOnPlayerChangedScene(ClientData client, string targetScene);

		protected abstract void OnPlayerLeft(ClientData client, DisconnectReasons reason);

		protected abstract void OnReportedPlayer(ReportOutcome outcome, int clientId, string playerName, ReportReasons reason);

		protected abstract void OnDisconnected();

		protected abstract void PreDisconnectInternal();

		private void OnSetPSNSessionId(string sessionId)
		{
		}

		protected abstract void OnGetGameList(TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse gamesResponse);

		private byte[] GetConnectionData(bool useDtlsLayout, string matchmakerToken)
		{
			return null;
		}

		protected ClientData FindClientById(int id)
		{
			if (allClients == null)
			{
				return null;
			}
			for (int i = 0; i < allClients.Count; i++)
			{
				if (allClients[i].Id == id)
				{
					return allClients[i];
				}
			}
			return null;
		}

		private void FixedUpdate()
		{
		}

		protected void UpdateCachedClients(ClientData clientData, PlayerControl character)
		{
		}

		private void SendAllStreamedObjects()
		{
		}

		public T FindObjectByNetId<T>(uint netId) where T : InnerNetObject
		{
			if (allObjects != null && allObjects.AllObjectsFast.TryGetValue(netId, out InnerNetObject obj))
			{
				return obj as T;
			}
			return null;
		}

		public MessageWriter StartRpcImmediately(uint targetNetId, byte callId, SendOption option, int targetClientId = -1)
		{
			MessageWriter writer = MessageWriter.Get(option);
			writer.StartMessage(callId);
			return writer;
		}

		public void FinishRpcImmediately(MessageWriter msg)
		{
			if (msg != null)
			{
				msg.EndMessage();
				msg.Recycle();
			}
		}

		public void SendXuidToAll()
		{
		}

		public void LateBroadcastReliableMessage(IGameDataMessage rpcMessage)
		{
		}

		public void LateBroadcastUnreliableMessage(IGameDataMessage rpcMessage)
		{
		}

		private void SendSceneChange(string sceneName)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSendSceneChange_003Ed__156))]
		private IEnumerator CoSendSceneChange(string sceneName)
		{
			return null;
		}

		public void Spawn(InnerNetObject netObjParent, int ownerId = -2, SpawnFlags flags = SpawnFlags.None)
		{
			if (netObjParent == null)
			{
				return;
			}
			if (ownerId == HostInherit)
			{
				ownerId = HostId;
			}
			if (ownerId == CurrentClient)
			{
				ownerId = ClientId;
			}
			if (ownerId == 0 || ownerId == -1)
			{
				ownerId = ClientId;
			}
			netObjParent.OwnerId = ownerId;
			netObjParent.SpawnFlags = flags;
			if (netObjParent.NetId == 0u)
			{
				netObjParent.NetId = ++NetIdCnt;
			}
			if (netObjParent.SpawnId == 0u)
			{
				netObjParent.SpawnId = netObjParent.NetId;
			}
			AddNetObject(netObjParent);
		}

		private SpawnGameDataMessage CreateSpawnMessage(InnerNetObject netObjParent, int ownerId, SpawnFlags flags)
		{
			return null;
		}

		public void Despawn(InnerNetObject objToDespawn)
		{
			if (objToDespawn == null)
			{
				return;
			}
			RemoveNetObject(objToDespawn);
			DestroyedObjects?.Add(objToDespawn.NetId);
			UnityEngine.Object.Destroy(objToDespawn.gameObject);
		}

		private bool AddNetObject(InnerNetObject obj)
		{
			if (allObjects == null)
			{
				allObjects = new InnerNetObjectCollection();
			}
			return allObjects.TryAddNetObject(obj);
		}

		public void RemoveNetObject(InnerNetObject obj)
		{
			allObjects?.RemoveNetObject(obj);
		}

		public void RemoveUnownedObjects()
		{
			HashSet<int> ids = new HashSet<int>();
			if (allClients != null)
			{
				for (int i = 0; i < allClients.Count; i++)
				{
					ids.Add(allClients[i].Id);
				}
			}
			allObjects?.RemoveUnownedObjects(ids, ClientId, go => UnityEngine.Object.Destroy(go));
		}

		private void HandleGameData(MessageReader parentReader)
		{
		}

		[IteratorStateMachine(typeof(_003CHandleGameDataInner_003Ed__165))]
		private IEnumerator HandleGameDataInner(MessageReader reader, int msgNum)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoHandleSpawn_003Ed__166))]
		private IEnumerator CoHandleSpawn(MessageReader reader)
		{
			return null;
		}

		private void PackAndSendQueuedMessages(Queue<IGameDataMessage> queue, SendOption sendOption, out bool thereAreQueuedMessagesLeft)
		{
			thereAreQueuedMessagesLeft = default(bool);
		}

		private void PackAndSendDirtyStreamedObjects(IReadOnlyList<InnerNetObject> streamCollection, SendOption sendOption, ref int trackingIndex)
		{
		}

		private void StartStreamedObjectMessage(ref MessageWriter writer, SendOption option)
		{
		}

		private int GetMaxMessagePackingLimit()
		{
			return 0;
		}

		private static string GetLocalPlayerName()
		{
			string playerName = PlayerPrefs.GetString("PlayerName", "Player");
			return string.IsNullOrWhiteSpace(playerName) ? "Player" : playerName;
		}
	}
}
