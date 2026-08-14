using System.Collections;
using Hazel;
using InnerNet;
using UnityEngine;

public class LobbyBehaviour : InnerNetObject
{
	public static LobbyBehaviour Instance;

	public AudioClip SpawnSound;

	public AnimationClip SpawnInClip;

	public Vector2[] SpawnPositions;

	public AudioClip DropShipSound;

	public AudioClip MapTheme;

	private const string MAP_THEME_NAME = "MapTheme";

	public SkeldShipRoom[] AllRooms;

	private readonly Logger logger = new Logger(Logger.Category.Gameplay, "Lobby");

	private float lastFriendsCheckTime;

	private float optionsTimer;

	private int currentExtensionId;

	public void Start()
	{
		Instance = this;
		StartCoroutine(DelayPlayDropshipAmbience());
		Camera main = Camera.main;
		if ((bool)main)
		{
			FollowerCamera component = main.GetComponent<FollowerCamera>();
			if ((bool)component)
			{
				component.shakeAmount = 0.03f;
				component.shakePeriod = 400f;
			}
		}
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			DestroyableSingleton<HudManager>.Instance.SetHudActive(true);
		}
	}

	private void Update()
	{
		HandleFriendsDataCaching();
	}

	public void RpcExtendLobbyTimer()
	{
		if (AmongUsClient.Instance == null)
		{
			return;
		}
		MessageWriter messageWriter = AmongUsClient.Instance.StartRpcImmediately(NetId, (byte)RpcCalls.ExtendLobbyTimer, SendOption.Reliable, AmongUsClient.Instance.HostId);
		AmongUsClient.Instance.FinishRpcImmediately(messageWriter);
	}

	private IEnumerator DelayPlayDropshipAmbience()
	{
		if ((bool)SoundManager.Instance)
		{
			SoundManager.Instance.StopAllSound();
		}
		yield return new WaitForSeconds(0.5f);
		if ((bool)SoundManager.Instance)
		{
			if ((bool)DropShipSound)
			{
				AudioSource audioSource = SoundManager.Instance.PlaySound(DropShipSound, true, 0.2f);
				if ((bool)audioSource)
				{
					audioSource.pitch = 1.2f;
				}
			}
			if ((bool)MapTheme)
			{
				SoundManager.Instance.PlaySound(MapTheme, true, 0.2f);
			}
		}
	}

	public void FixedUpdate()
	{
		if ((bool)ShipStatus.Instance || (AmongUsClient.Instance != null && AmongUsClient.Instance.GameState == InnerNetClient.GameStates.Started))
		{
			StopLobbySounds();
			base.enabled = false;
			return;
		}
		optionsTimer += Time.deltaTime;
		if (optionsTimer >= 0.25f)
		{
			optionsTimer = 0f;
		}
	}

	public override void OnDestroy()
	{
		if (Instance == this)
		{
			Instance = null;
		}
		Camera main = Camera.main;
		if ((bool)main)
		{
			FollowerCamera component = main.GetComponent<FollowerCamera>();
			if ((bool)component)
			{
				component.shakeAmount = 0.02f;
				component.shakePeriod = 0.3f;
			}
		}
		StopLobbySounds();
		base.OnDestroy();
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		switch ((RpcCalls)callId)
		{
		case RpcCalls.LobbyTimeExpiring:
			HandleLobbyTimerExtensionRequest(reader.ReadInt32(), reader.ReadBoolean(), reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
			break;
		case RpcCalls.ExtendLobbyTimer:
			LobbyTimerExtended();
			break;
		}
	}

	public override void ClearOrDecrementDirt()
	{
		ClearDirtyBits();
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private void HandleFriendsDataCaching()
	{
		if (Time.time - lastFriendsCheckTime < 1f)
		{
			return;
		}
		lastFriendsCheckTime = Time.time;
		if (DestroyableSingleton<FriendsListManager>.InstanceExists && FriendsListUI.Instance != null)
		{
			FriendsListUI.Instance.RefreshLobbyPlayers();
		}
	}

	private void HandleLobbyTimerExtensionRequest(int timeRemainingSeconds, bool isExtensionAvailable, int hostId, int extensionId, int extendedTimeSeconds)
	{
		currentExtensionId = extensionId;
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			if (isExtensionAvailable && AmongUsClient.Instance != null && AmongUsClient.Instance.ClientId == hostId)
			{
				DestroyableSingleton<HudManager>.Instance.ShowLobbyTimerPopup(timeRemainingSeconds, extendedTimeSeconds);
			}
			else
			{
				DestroyableSingleton<HudManager>.Instance.ShowLobbyTimer(timeRemainingSeconds);
			}
		}
	}

	private void LobbyTimerExtended()
	{
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			DestroyableSingleton<HudManager>.Instance.OnLobbyTimerExtended();
		}
	}

	private void StopLobbySounds()
	{
		if (!(bool)SoundManager.Instance)
		{
			return;
		}
		if ((bool)DropShipSound)
		{
			SoundManager.Instance.StopSound(DropShipSound);
		}
		if ((bool)MapTheme)
		{
			SoundManager.Instance.StopSound(MapTheme);
		}
	}
}
