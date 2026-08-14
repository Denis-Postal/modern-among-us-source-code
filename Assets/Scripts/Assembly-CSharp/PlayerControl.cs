using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using AmongUs.QuickChat;
using Hazel;
using InnerNet;
using UnityEngine;

public class PlayerControl : InnerNetObject
{
	public class ColliderComparer : IEqualityComparer<Collider2D>
	{
		public static readonly ColliderComparer Instance = new ColliderComparer();

		public bool Equals(Collider2D x, Collider2D y)
		{
			return x == y;
		}

		public int GetHashCode(Collider2D obj)
		{
			return obj != null ? obj.GetHashCode() : 0;
		}
	}

	public class UsableComparer : IEqualityComparer<IUsable>
	{
		public static readonly UsableComparer Instance = new UsableComparer();

		public bool Equals(IUsable x, IUsable y)
		{
			return x == y;
		}

		public int GetHashCode(IUsable obj)
		{
			return obj != null ? obj.GetHashCode() : 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAssertWithTimeout_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> assertion;

		public float timeoutInSeconds;

		public Action onTimeout;

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
		public _003CAssertWithTimeout_003Ed__81(int _003C_003E1__state)
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
	private sealed class _003CClientInitialize_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

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
		public _003CClientInitialize_003Ed__83(int _003C_003E1__state)
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
	private sealed class _003CCoSetColor_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public int bodyColor;

		private int _003Cattempts_003E5__2;

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
		public _003CCoSetColor_003Ed__125(int _003C_003E1__state)
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
	private sealed class _003CCoSetCosmetic_003Ed__188 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public RpcCalls rpc;

		public byte sequenceId;

		public string cosmeticId;

		private int _003Cattempts_003E5__2;

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
		public _003CCoSetCosmetic_003Ed__188(int _003C_003E1__state)
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
	private sealed class _003CCoSetLevel_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public uint level;

		private int _003Cattempts_003E5__2;

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
		public _003CCoSetLevel_003Ed__129(int _003C_003E1__state)
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
	private sealed class _003CCoSetName_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public string playerName;

		private int _003Cattempts_003E5__2;

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
		public _003CCoSetName_003Ed__121(int _003C_003E1__state)
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
	private sealed class _003CCoSetRole_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoleTypes role;

		public PlayerControl _003C_003E4__this;

		public bool canOverride;

		private bool _003CghostRole_003E5__2;

		private int _003Cattempts_003E5__3;

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
		public _003CCoSetRole_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CCoSetTasks_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public List<NetworkedPlayerInfo.TaskInfo> tasks;

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
		public _003CCoSetTasks_003Ed__103(int _003C_003E1__state)
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
	private sealed class _003CEnableRightJoystick_003Ed__187 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool enabled;

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
		public _003CEnableRightJoystick_003Ed__187(int _003C_003E1__state)
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
	private sealed class _003CScalePlayer_003Ed__168 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

		public float targetScale;

		public float duration;

		private float _003CelapsedTime_003E5__2;

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
		public _003CScalePlayer_003Ed__168(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl _003C_003E4__this;

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
		public _003CStart_003Ed__82(int _003C_003E1__state)
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

	private const int MAX_NETOBJECT_INIT_ATTEMPTS = 60;

	private const float NETOBJECT_INIT_ATTEMPT_WAIT_SECONDS = 0.1f;

	private static readonly Color32[] FallbackPlayerColors =
	{
		new Color32(198, 17, 17, byte.MaxValue),
		new Color32(19, 46, 210, byte.MaxValue),
		new Color32(17, 128, 45, byte.MaxValue),
		new Color32(238, 84, 187, byte.MaxValue),
		new Color32(240, 125, 13, byte.MaxValue),
		new Color32(246, 246, 87, byte.MaxValue),
		new Color32(63, 71, 78, byte.MaxValue),
		new Color32(215, 225, 241, byte.MaxValue),
		new Color32(107, 47, 188, byte.MaxValue),
		new Color32(113, 73, 30, byte.MaxValue),
		new Color32(56, byte.MaxValue, 221, byte.MaxValue),
		new Color32(80, 240, 57, byte.MaxValue),
		new Color32(255, 255, 190, byte.MaxValue),
		new Color32(145, 136, 119, byte.MaxValue),
		new Color32(236, 117, 120, byte.MaxValue)
	};

	public byte PlayerId;

	public string FriendCode;

	public string Puid;

	public float MaxReportDistance;

	public bool moveable;

	public CosmeticsLayer cosmetics;

	[HideInInspector]
	public bool ForceKillTimerContinue;

	public bool inVent;

	public bool walkingToVent;

	public bool petting;

	public bool inMovingPlat;

	public bool onLadder;

	public bool protectedByGuardianThisRound;

	public bool shapeshifting;

	public bool waitingForShapeshiftResponse;

	public bool isKilling;

	private float invisibilityAlpha;

	private const float OFFSET_ANIM_CHARGE = -0.05f;

	public static PlayerControl LocalPlayer;

	private NetworkedPlayerInfo CachedPlayerData;

	private Dictionary<PlayerOutfitType, NetworkedPlayerInfo.PlayerOutfit> CachedLocalOutfits;

	private int protectedByGuardianId;

	private float flashlightAngle;

	private int shapeshiftTargetPlayerId;

	private bool shouldAppearInvisible;

	public bool isTrackingPlayer;

	public PlayerControl trackedPlayer;

	public int trackedPlayerColorID;

	public AudioSource FootSteps;

	public AudioClip KillSfx;

	public KillAnimation[] KillAnimations;

	[SerializeField]
	private float killTimer;

	public int RemainingEmergencies;

	public LightSource LightPrefab;

	private LightSource lightSource;

	[HideInInspector]
	public Collider2D Collider;

	[HideInInspector]
	public PlayerPhysics MyPhysics;

	[HideInInspector]
	public CustomNetworkTransform NetTransform;

	[SerializeField]
	private Collider2D clickKillCollider;

	public Vector3 defaultCosmeticsScale;

	public List<PlayerTask> myTasks;

	public List<RoleEffectAnimation> currentRoleAnimations;

	public GameObject TargetFlashlight;

	public bool isDummy;

	public bool notRealPlayer;

	private readonly Logger logger = new Logger(Logger.Category.Gameplay, "PlayerControl");

	private readonly List<IPlayerVisibleItem> visibilityItems = new List<IPlayerVisibleItem>();

	private Collider2D[] hitBuffer;

	private IUsable closest;

	private bool isNew;

	private bool hasBeenSerialized;

	private Rigidbody2D rigidbody2D;

	public static List<PlayerControl> AllPlayerControls = new List<PlayerControl>();

	private Dictionary<Collider2D, IUsable[]> cache = new Dictionary<Collider2D, IUsable[]>(ColliderComparer.Instance);

	private List<IUsable> itemsInRange = new List<IUsable>();

	private List<IUsable> newItemsInRange = new List<IUsable>();

	private byte scannerCount;

	private bool roleAssigned;

	private int LastStartCounter;

	public bool CanMove => moveable && !inVent && !walkingToVent && !petting && !inMovingPlat && !onLadder;

	public bool IsKillTimerEnabled => !ForceKillTimerContinue && !inVent && !petting && !inMovingPlat && !onLadder;

	public NetworkedPlayerInfo.PlayerOutfit CurrentOutfit => GetOutfit(CurrentOutfitType);

	public PlayerOutfitType CurrentOutfitType { get; private set; }

	public float CalculatedAlpha => Mathf.Clamp01(invisibilityAlpha <= 0f ? 1f : invisibilityAlpha);

	public float FlashlightAngle
	{
		get
		{
			return flashlightAngle;
		}
		set
		{
			flashlightAngle = value;
		}
	}

	public bool PhantomFadeActive => shouldAppearInvisible;

	public NetworkedPlayerInfo Data
	{
		get
		{
			if ((bool)CachedPlayerData)
			{
				return CachedPlayerData;
			}
			if ((bool)GameData.Instance)
			{
				CachedPlayerData = GameData.Instance.GetPlayerById(PlayerId);
			}
			return CachedPlayerData;
		}
	}

	public bool Visible
	{
		get
		{
			return gameObject.activeSelf;
		}
		set
		{
			gameObject.SetActive(value);
			if ((bool)cosmetics)
			{
				cosmetics.gameObject.SetActive(value);
			}
		}
	}

	public PlayerBodyTypes BodyType => cosmetics != null ? cosmetics.CurrentBodyType : PlayerBodyTypes.Normal;

	public void SetKillTimer(float time)
	{
		killTimer = Mathf.Max(0f, time);
	}

	private void Awake()
	{
		MyPhysics = GetComponent<PlayerPhysics>();
		NetTransform = GetComponent<CustomNetworkTransform>();
		Collider = GetComponent<Collider2D>();
		rigidbody2D = GetComponent<Rigidbody2D>();
		if ((bool)cosmetics)
		{
			defaultCosmeticsScale = cosmetics.transform.localScale;
		}
		if (myTasks == null)
		{
			myTasks = new List<PlayerTask>();
		}
		if (currentRoleAnimations == null)
		{
			currentRoleAnimations = new List<RoleEffectAnimation>();
		}
		if (hitBuffer == null || hitBuffer.Length == 0)
		{
			hitBuffer = new Collider2D[32];
		}
		if (AllPlayerControls == null)
		{
			AllPlayerControls = new List<PlayerControl>();
		}
		if (!notRealPlayer && !AllPlayerControls.Contains(this))
		{
			AllPlayerControls.Add(this);
		}
	}

	private void OnEnable()
	{
		if (!notRealPlayer && AllPlayerControls != null && !AllPlayerControls.Contains(this))
		{
			AllPlayerControls.Add(this);
		}
	}

	private void OnDisable()
	{
		if (AllPlayerControls != null)
		{
			AllPlayerControls.Remove(this);
		}
	}

	[IteratorStateMachine(typeof(_003CAssertWithTimeout_003Ed__81))]
	private IEnumerator AssertWithTimeout(Func<bool> assertion, Action onTimeout, float timeoutInSeconds)
	{
		bool failed = true;
		for (float timer = 0f; timer < timeoutInSeconds; timer += Time.deltaTime)
		{
			if (assertion == null || assertion())
			{
				failed = false;
				break;
			}
			yield return null;
		}
		if (failed)
		{
			onTimeout?.Invoke();
		}
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__82))]
	private IEnumerator Start()
	{
		if (notRealPlayer)
		{
			yield break;
		}
		yield return AssertWithTimeout(() => PlayerId != byte.MaxValue, delegate
		{
			if (AmongUsClient.Instance != null)
			{
				AmongUsClient.Instance.EnqueueDisconnect(DisconnectReasons.Error, "Timeout while waiting for player id.");
			}
		}, 30f);
		yield return AssertWithTimeout(() => Data != null || GameData.Instance == null, null, 5f);
		if (IsLocalOwner())
		{
			LocalPlayer = this;
			if ((bool)LightPrefab)
			{
				lightSource = UnityEngine.Object.Instantiate(LightPrefab, transform);
				lightSource.transform.localPosition = Collider != null ? (Vector3)Collider.offset : Vector3.zero;
			}
			Camera main = Camera.main;
			if ((bool)main)
			{
				FollowerCamera followerCamera = main.GetComponent<FollowerCamera>();
				if ((bool)followerCamera)
				{
					followerCamera.SetTarget(this);
				}
			}
			SetAppearanceFromSaveData();
		}
		else
		{
			yield return ClientInitialize();
		}
		if (isNew && (bool)MyPhysics && (bool)LobbyBehaviour.Instance)
		{
			isNew = false;
			StartCoroutine(MyPhysics.CoSpawnPlayer(LobbyBehaviour.Instance));
		}
	}

	[IteratorStateMachine(typeof(_003CClientInitialize_003Ed__83))]
	private IEnumerator ClientInitialize()
	{
		Visible = false;
		yield return AssertWithTimeout(() => Data != null && !notRealPlayer, null, 10f);
		if (Data != null)
		{
			SetOutfit(CurrentOutfit ?? Data.DefaultOutfit, PlayerOutfitType.Default);
		}
		Visible = true;
	}

	public override void OnDestroy()
	{
		if (AllPlayerControls != null)
		{
			AllPlayerControls.Remove(this);
		}
		if (LocalPlayer == this)
		{
			LocalPlayer = null;
		}
		if ((bool)lightSource)
		{
			UnityEngine.Object.Destroy(lightSource.gameObject);
		}
		base.OnDestroy();
	}

	private void FixedUpdate()
	{
		if (killTimer > 0f && IsKillTimerEnabled)
		{
			killTimer = Mathf.Max(0f, killTimer - Time.fixedDeltaTime);
		}
		if ((bool)lightSource && (bool)ShipStatus.Instance && Data != null)
		{
			lightSource.SetViewDistance(ShipStatus.Instance.CalculateLightRadius(Data));
		}
		EnsureNormalBodyRenderer();
	}

	private void EnsureNormalBodyRenderer()
	{
		if (cosmetics == null || cosmetics.CurrentBodyType != PlayerBodyTypes.Normal)
		{
			return;
		}
		Transform bodyForms = FindBodyFormsRoot();
		if (bodyForms == null)
		{
			return;
		}
		SetBodyFormRenderers(bodyForms, "Normal", true);
		SetBodyFormRenderers(bodyForms, "Horse", false);
		SetBodyFormRenderers(bodyForms, "Seeker", false);
		SetBodyFormRenderers(bodyForms, "LongBoiBody", false);
		SetBodyFormRenderers(bodyForms, "LongSeekerBody", false);
	}

	private Transform FindBodyFormsRoot()
	{
		Transform cursor = transform;
		while (cursor != null)
		{
			Transform bodyForms = cursor.Find("BodyForms");
			if (bodyForms != null)
			{
				return bodyForms;
			}
			cursor = cursor.parent;
		}
		return null;
	}

	private static void SetBodyFormRenderers(Transform bodyForms, string childName, bool enabled)
	{
		Transform child = bodyForms.Find(childName);
		if (child == null)
		{
			return;
		}
		SpriteRenderer[] renderers = child.GetComponentsInChildren<SpriteRenderer>(true);
		for (int i = 0; i < renderers.Length; i++)
		{
			renderers[i].enabled = enabled;
		}
	}

	private bool IsLocalOwner()
	{
		if (AmongUsClient.Instance == null)
		{
			return LocalPlayer == null || LocalPlayer == this;
		}
		return OwnerId == AmongUsClient.Instance.ClientId;
	}

	public void AnimateCustom(AnimationClip anim)
	{
		if ((bool)MyPhysics)
		{
			MyPhysics.AnimateCustom(anim);
		}
	}

	public void OnGameStart()
	{
		moveable = true;
		inVent = false;
		petting = false;
		if ((bool)MyPhysics)
		{
			MyPhysics.enabled = true;
			MyPhysics.ResetAnimState();
		}
	}

	public void OnGameEnd()
	{
		moveable = false;
	}

	public void UseClosest()
	{
		if (closest != null)
		{
			closest.Use();
			closest = null;
		}
	}

	public void RegisterVisibilityItem(IPlayerVisibleItem obj)
	{
		if (obj != null && !visibilityItems.Contains(obj))
		{
			visibilityItems.Add(obj);
		}
	}

	public void UnregisterVisibilityItem(IPlayerVisibleItem obj)
	{
		visibilityItems.Remove(obj);
	}

	public void TryPet()
	{
		if (CanPet() && (bool)GetPet())
		{
			petting = true;
		}
	}

	public void ReportClosest()
	{
		if (Data != null && Data.IsDead)
		{
			return;
		}
		Collider2D[] hits = Physics2D.OverlapCircleAll(GetTruePosition(), MaxReportDistance, Constants.NotShipMask);
		for (int i = 0; i < hits.Length; i++)
		{
			if (hits[i].CompareTag("DeadBody"))
			{
				DeadBody deadBody = hits[i].GetComponent<DeadBody>();
				if ((bool)deadBody && !deadBody.Reported)
				{
					deadBody.OnClick();
					return;
				}
			}
		}
	}

	public void PlayStepSound()
	{
		if ((bool)FootSteps && Constants.ShouldPlaySfx())
		{
			FootSteps.Play();
		}
	}

	private void SetScanner(bool on, byte cnt)
	{
		if (cnt < scannerCount)
		{
			return;
		}
		scannerCount = cnt;
	}

	public Vector2 GetTruePosition()
	{
		return (Vector2)transform.position + (Collider != null ? Collider.offset : Vector2.zero);
	}

	public void SetTasks(List<NetworkedPlayerInfo.TaskInfo> tasks)
	{
		StartCoroutine(CoSetTasks(tasks));
	}

	[IteratorStateMachine(typeof(_003CCoSetTasks_003Ed__103))]
	private IEnumerator CoSetTasks(List<NetworkedPlayerInfo.TaskInfo> tasks)
	{
		while (!ShipStatus.Instance)
		{
			yield return null;
		}
		ClearTasks();
		if (tasks == null)
		{
			yield break;
		}
		for (int i = 0; i < tasks.Count; i++)
		{
			NetworkedPlayerInfo.TaskInfo taskInfo = tasks[i];
			NormalPlayerTask taskPrefab = ShipStatus.Instance.GetTaskById(taskInfo.TypeId);
			if (!(bool)taskPrefab)
			{
				continue;
			}
			NormalPlayerTask normalPlayerTask = UnityEngine.Object.Instantiate(taskPrefab, transform);
			normalPlayerTask.Id = taskInfo.Id;
			normalPlayerTask.Owner = this;
			normalPlayerTask.Initialize();
			myTasks.Add(normalPlayerTask);
		}
	}

	public PlayerTask AddSystemTask(SystemTypes system)
	{
		if (!ShipStatus.Instance)
		{
			return null;
		}
		PlayerTask[] specialTasks = ShipStatus.Instance.SpecialTasks;
		if (specialTasks == null || specialTasks.Length == 0)
		{
			return null;
		}
		int index = 0;
		switch (system)
		{
		case SystemTypes.Electrical:
			index = Mathf.Min(1, specialTasks.Length - 1);
			break;
		case SystemTypes.Comms:
			index = Mathf.Min(2, specialTasks.Length - 1);
			break;
		case SystemTypes.LifeSupp:
			index = Mathf.Min(3, specialTasks.Length - 1);
			break;
		}
		PlayerTask playerTask = UnityEngine.Object.Instantiate(specialTasks[index], transform);
		playerTask.Owner = this;
		playerTask.Initialize();
		myTasks.Add(playerTask);
		return playerTask;
	}

	public void RemoveTask(PlayerTask task)
	{
		if (!(bool)task)
		{
			return;
		}
		task.OnRemove();
		myTasks.Remove(task);
		UnityEngine.Object.Destroy(task.gameObject);
	}

	public void ClearTasks()
	{
		if (myTasks == null)
		{
			myTasks = new List<PlayerTask>();
			return;
		}
		for (int i = 0; i < myTasks.Count; i++)
		{
			if ((bool)myTasks[i])
			{
				myTasks[i].OnRemove();
				UnityEngine.Object.Destroy(myTasks[i].gameObject);
			}
		}
		myTasks.Clear();
	}

	public void Die(DeathReason reason, bool assignGhostRole)
	{
		NetworkedPlayerInfo data = Data;
		if (data != null)
		{
			data.IsDead = true;
		}
		moveable = false;
		gameObject.layer = LayerMask.NameToLayer("Ghost");
	}

	public void Revive()
	{
		NetworkedPlayerInfo data = Data;
		if (data != null)
		{
			data.IsDead = false;
		}
		moveable = true;
		gameObject.layer = LayerMask.NameToLayer("Players");
		if ((bool)MyPhysics)
		{
			MyPhysics.ResetAnimState();
		}
	}

	public void OnClick()
	{
	}

	public void CheckSeekerHand_AnimEvent()
	{
	}

	public void PlayAnimation(byte animType)
	{
	}

	public void CompleteTask(uint idx)
	{
		PlayerTask task = myTasks != null ? myTasks.Find((PlayerTask t) => (bool)t && t.Id == idx) : null;
		if ((bool)task)
		{
			task.Complete();
		}
	}

	public bool AllTasksCompleted()
	{
		if (myTasks == null)
		{
			return true;
		}
		for (int i = 0; i < myTasks.Count; i++)
		{
			if ((bool)myTasks[i] && !myTasks[i].IsComplete)
			{
				return false;
			}
		}
		return true;
	}

	public bool MustCleanVent(int ventId)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCoSetRole_003Ed__116))]
	private IEnumerator CoSetRole(RoleTypes role, bool canOverride)
	{
		if (DestroyableSingleton<RoleManager>.InstanceExists)
		{
			DestroyableSingleton<RoleManager>.Instance.SetRole(this, role);
		}
		roleAssigned = true;
		yield break;
	}

	public void Exiled()
	{
		Die(DeathReason.Exile, true);
	}

	public void CheckName(string playerName)
	{
		SetName(string.IsNullOrWhiteSpace(playerName) ? "Player" : playerName);
	}

	public void SetKinematic(bool b)
	{
		if ((bool)rigidbody2D)
		{
			rigidbody2D.isKinematic = b;
		}
	}

	public void SetName(string playerName)
	{
		StartCoroutine(CoSetName(playerName));
	}

	[IteratorStateMachine(typeof(_003CCoSetName_003Ed__121))]
	private IEnumerator CoSetName(string playerName)
	{
		RawSetName(playerName);
		yield break;
	}

	public void CheckColor(byte bodyColor)
	{
		SetColor(bodyColor);
	}

	public void SetHatAndVisorAlpha(float a)
	{
		invisibilityAlpha = a;
	}

	public void SetColor(int bodyColor)
	{
		StartCoroutine(CoSetColor(bodyColor));
	}

	[IteratorStateMachine(typeof(_003CCoSetColor_003Ed__125))]
	private IEnumerator CoSetColor(int bodyColor)
	{
		RawSetColor(bodyColor);
		yield break;
	}

	public void SetNamePlate(string namePlateId)
	{
		GetOrCreateOutfit(PlayerOutfitType.Default).NamePlateId = namePlateId;
		if (Data != null)
		{
			Data.UpdateNamePlate(namePlateId);
		}
	}

	public void SetVisor(string visorId, int colorId)
	{
		RawSetVisor(visorId, colorId);
	}

	public void SetLevel(uint level)
	{
		StartCoroutine(CoSetLevel(level));
	}

	[IteratorStateMachine(typeof(_003CCoSetLevel_003Ed__129))]
	private IEnumerator CoSetLevel(uint level)
	{
		if (Data != null)
		{
			Data.PlayerLevel = level;
		}
		yield break;
	}

	public void SetSkin(string skinId, int color)
	{
		RawSetSkin(skinId, color);
	}

	public void SetHat(string hatId, int colorId)
	{
		RawSetHat(hatId, colorId);
	}

	public void SetPet(string petId)
	{
		SetPet(petId, CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
	}

	public void SetPet(string petId, int colorId)
	{
		RawSetPet(petId, colorId);
	}

	public void SetPetPosition(Vector3 newPosition)
	{
		cosmetics?.SetPetPosition(newPosition);
	}

	public PetBehaviour GetPet()
	{
		return cosmetics != null ? cosmetics.GetPet() : null;
	}

	public static void SetSkinImageAsync(SkinData skin, int colorId, SpriteRenderer target)
	{
	}

	private void ReportDeadBody(NetworkedPlayerInfo target)
	{
		StartMeeting(target);
	}

	private void CheckUseZipline(PlayerControl target, ZiplineBehaviour ziplineBehaviour, bool fromTop)
	{
	}

	private void CheckSporeTrigger(Mushroom mushroom)
	{
	}

	public void StartMeeting(NetworkedPlayerInfo target)
	{
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			DestroyableSingleton<HudManager>.Instance.OpenMeetingRoom(this);
		}
	}

	public void ResetForMeeting()
	{
		inVent = false;
		petting = false;
		walkingToVent = false;
		if ((bool)MyPhysics)
		{
			MyPhysics.ResetMoveState();
		}
	}

	public void CheckMurder(PlayerControl target)
	{
		if ((bool)target && target != this && Data != null && !Data.IsDead)
		{
			RpcMurderPlayer(target, true);
		}
	}

	private void CheckShapeshift(PlayerControl target, bool shouldAnimate)
	{
	}

	public bool IsMushroomMixupActive()
	{
		return false;
	}

	public bool AreCommsAffected()
	{
		return false;
	}

	public void MurderPlayer(PlayerControl target, MurderResultFlags resultFlags)
	{
		if (!(bool)target || resultFlags == MurderResultFlags.FailedError)
		{
			return;
		}
		if ((bool)KillSfx && (bool)SoundManager.Instance && Constants.ShouldPlaySfx())
		{
			SoundManager.Instance.PlaySound(KillSfx, false, 0.8f);
		}
		target.Die(DeathReason.Kill, true);
		if (DestroyableSingleton<HudManager>.InstanceExists && target == LocalPlayer)
		{
			DestroyableSingleton<HudManager>.Instance.KillOverlay.ShowKillAnimation(Data, target.Data);
		}
	}

	public void CheckProtect(PlayerControl target)
	{
		if ((bool)target)
		{
			RpcProtectPlayer(target, CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
		}
	}

	public void ProtectPlayer(PlayerControl target, int colorId)
	{
		if ((bool)target)
		{
			target.TurnOnProtection(true, colorId, PlayerId);
		}
	}

	public void SetPlayerMaterialColors(Renderer rend)
	{
		int colorId = CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId;
		SetPlayerMaterialColors(colorId, rend);
	}

	public static void SetPlayerMaterialColors(int colorId, Renderer rend)
	{
		if (!(bool)rend)
		{
			return;
		}
		Color32[] playerColors = Palette.PlayerColors != null && Palette.PlayerColors.Length > 0 ? Palette.PlayerColors : FallbackPlayerColors;
		Color32[] shadowColors = Palette.ShadowColors != null && Palette.ShadowColors.Length == playerColors.Length ? Palette.ShadowColors : null;
		colorId = Mathf.Clamp(colorId, 0, playerColors.Length - 1);
		SpriteRenderer spriteRenderer = rend as SpriteRenderer;
		if ((bool)spriteRenderer)
		{
			spriteRenderer.color = Color.white;
		}
		if ((bool)rend.material)
		{
			Color bodyColor = playerColors[colorId];
			Color backColor = shadowColors != null ? (Color)shadowColors[colorId] : bodyColor * 0.55f;
			rend.material.SetColor("_BackColor", backColor);
			rend.material.SetColor("_BodyColor", bodyColor);
			rend.material.SetColor("_VisorColor", new Color(0.584f, 0.792f, 0.863f, 1f));
		}
	}

	public static void HideCursorTemporarily()
	{
	}

	public void SetAppearanceFromSaveData()
	{
		int colorId = PlayerCustomization.ColorId;
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(PlayerOutfitType.Default);
		outfit.ColorId = colorId;
		outfit.HatId = PlayerCustomization.HatId;
		outfit.SkinId = PlayerCustomization.SkinId;
		outfit.VisorId = PlayerCustomization.VisorId;
		outfit.PetId = PlayerCustomization.PetId;
		outfit.NamePlateId = PlayerCustomization.NameplateId;
		outfit.PlayerName = PlayerPrefs.GetString("PlayerName", "Player");
		RawSetOutfit(outfit, PlayerOutfitType.Default);
	}

	public void ToggleHighlight(bool active, RoleTeamTypes targeterTeam)
	{
	}

	public void SetOutfit(NetworkedPlayerInfo.PlayerOutfit newOutfit, PlayerOutfitType type)
	{
		RawSetOutfit(newOutfit, type);
	}

	public void RawSetOutfit(NetworkedPlayerInfo.PlayerOutfit newOutfit, PlayerOutfitType type)
	{
		if (newOutfit == null)
		{
			return;
		}
		CurrentOutfitType = type;
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(type);
		outfit.ColorId = newOutfit.ColorId;
		outfit.HatId = newOutfit.HatId;
		outfit.PetId = newOutfit.PetId;
		outfit.SkinId = newOutfit.SkinId;
		outfit.VisorId = newOutfit.VisorId;
		outfit.NamePlateId = newOutfit.NamePlateId;
		outfit.PlayerName = newOutfit.PlayerName;
		RawSetColor(outfit.ColorId);
		RawSetName(outfit.PlayerName);
		RawSetHat(outfit.HatId, outfit.ColorId);
		RawSetSkin(outfit.SkinId, outfit.ColorId);
		RawSetVisor(outfit.VisorId, outfit.ColorId);
		RawSetPet(outfit.PetId, outfit.ColorId);
	}

	public void RejectShapeshift()
	{
		waitingForShapeshiftResponse = false;
	}

	public void Shapeshift(PlayerControl targetPlayer, bool animate)
	{
		if ((bool)targetPlayer && targetPlayer.CurrentOutfit != null)
		{
			RawSetOutfit(targetPlayer.CurrentOutfit, PlayerOutfitType.Shapeshifted);
			shapeshiftTargetPlayerId = targetPlayer.PlayerId;
		}
	}

	public int ShapeshiftedPlayerID()
	{
		return shapeshiftTargetPlayerId;
	}

	private void SetRoleInvisibility(bool isActive, bool shouldAnimate = true, bool playFullAnimation = false)
	{
		SetInvisibility(isActive);
	}

	private void LoopChargeAnim(PhantomRole phantomRole)
	{
	}

	public void ForcePhantomVisible()
	{
		SetInvisibility(false);
	}

	private void AppearOtherClients()
	{
	}

	private void ContinueVanish()
	{
	}

	private void SetInvisibility(bool isActive)
	{
		shouldAppearInvisible = isActive;
		invisibilityAlpha = isActive ? 0.35f : 1f;
		if ((bool)cosmetics)
		{
			cosmetics.gameObject.SetActive(!isActive || invisibilityAlpha > 0f);
		}
	}

	public void StartPlayerTracking(PlayerControl playerToTrack, int colorID)
	{
		trackedPlayer = playerToTrack;
		trackedPlayerColorID = colorID;
		isTrackingPlayer = playerToTrack != null;
	}

	public void CancelPlayerTracking()
	{
		trackedPlayer = null;
		isTrackingPlayer = false;
	}

	public void DisableCurrentTrackers()
	{
		CancelPlayerTracking();
	}

	public void MixUpOutfit(NetworkedPlayerInfo.PlayerOutfit playerOutfit)
	{
		RawSetOutfit(playerOutfit, PlayerOutfitType.MushroomMixup);
	}

	[IteratorStateMachine(typeof(_003CScalePlayer_003Ed__168))]
	public IEnumerator ScalePlayer(float targetScale, float duration)
	{
		Vector3 startScale = transform.localScale;
		Vector3 target = new Vector3(targetScale, targetScale, startScale.z);
		for (float timer = 0f; timer < duration; timer += Time.deltaTime)
		{
			transform.localScale = Vector3.Lerp(startScale, target, timer / duration);
			yield return null;
		}
		transform.localScale = target;
	}

	public void CmdCheckRevertShapeshift(bool shouldAnimate)
	{
		FixMixedUpOutfit();
	}

	public void FixMixedUpOutfit()
	{
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOutfit(PlayerOutfitType.Default);
		if (outfit != null)
		{
			RawSetOutfit(outfit, PlayerOutfitType.Default);
		}
	}

	private void RawSetName(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			name = "Player";
		}
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(CurrentOutfitType);
		outfit.PlayerName = name;
		if ((bool)cosmetics)
		{
			cosmetics.SetName(name);
		}
	}

	private void RawSetColor(int bodyColor)
	{
		int colorCount = Palette.PlayerColors != null && Palette.PlayerColors.Length > 0 ? Palette.PlayerColors.Length : FallbackPlayerColors.Length;
		bodyColor = Mathf.Clamp(bodyColor, 0, colorCount - 1);
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(CurrentOutfitType);
		outfit.ColorId = bodyColor;
		if ((bool)cosmetics)
		{
			cosmetics.SetColor(bodyColor);
		}
		SetColorBlindTag();
	}

	private void RawSetVisor(string visorId, int color)
	{
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(CurrentOutfitType);
		outfit.VisorId = string.IsNullOrEmpty(visorId) ? VisorData.EmptyId : visorId;
		if ((bool)cosmetics)
		{
			cosmetics.SetVisor(outfit.VisorId, color);
		}
	}

	private void RawSetSkin(string skinId, int color)
	{
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(CurrentOutfitType);
		outfit.SkinId = string.IsNullOrEmpty(skinId) ? SkinData.EmptyId : skinId;
		if ((bool)cosmetics)
		{
			cosmetics.SetSkin(outfit.SkinId, color);
		}
	}

	private void RawSetHat(string hatId, int colorId)
	{
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(CurrentOutfitType);
		outfit.HatId = string.IsNullOrEmpty(hatId) ? HatData.EmptyId : hatId;
		if ((bool)cosmetics)
		{
			cosmetics.SetHat(outfit.HatId, colorId);
		}
	}

	private void RawSetPet(string petId, int colorId)
	{
		NetworkedPlayerInfo.PlayerOutfit outfit = GetOrCreateOutfit(CurrentOutfitType);
		outfit.PetId = string.IsNullOrEmpty(petId) ? PetData.EmptyId : petId;
		if ((bool)cosmetics)
		{
			cosmetics.SetPetIdle(outfit.PetId, colorId);
			cosmetics.SetPetSource(this);
		}
	}

	private void ShowFailedMurder()
	{
	}

	private void RemoveProtection()
	{
		TurnOnProtection(false, 0, -1);
	}

	private void TurnOnProtection(bool visible, int colorId, int guardianPlayerId)
	{
		protectedByGuardianThisRound = visible;
		protectedByGuardianId = guardianPlayerId;
	}

	private void SetColorBlindTag()
	{
	}

	private NetworkedPlayerInfo.PlayerOutfit GetOutfit(PlayerOutfitType type)
	{
		NetworkedPlayerInfo data = Data;
		if (data != null && data.Outfits != null && data.Outfits.TryGetValue(type, out NetworkedPlayerInfo.PlayerOutfit outfit))
		{
			return outfit;
		}
		if (CachedLocalOutfits != null && CachedLocalOutfits.TryGetValue(type, out NetworkedPlayerInfo.PlayerOutfit cachedOutfit))
		{
			return cachedOutfit;
		}
		return null;
	}

	private NetworkedPlayerInfo.PlayerOutfit GetOrCreateOutfit(PlayerOutfitType type)
	{
		NetworkedPlayerInfo data = Data;
		if (data != null)
		{
			if (data.Outfits == null)
			{
				data.Outfits = new Dictionary<PlayerOutfitType, NetworkedPlayerInfo.PlayerOutfit>();
			}
			if (!data.Outfits.TryGetValue(type, out NetworkedPlayerInfo.PlayerOutfit outfit) || outfit == null)
			{
				outfit = new NetworkedPlayerInfo.PlayerOutfit();
				data.Outfits[type] = outfit;
			}
			return outfit;
		}
		if (CachedLocalOutfits == null)
		{
			CachedLocalOutfits = new Dictionary<PlayerOutfitType, NetworkedPlayerInfo.PlayerOutfit>();
		}
		if (!CachedLocalOutfits.TryGetValue(type, out NetworkedPlayerInfo.PlayerOutfit cachedOutfit) || cachedOutfit == null)
		{
			cachedOutfit = new NetworkedPlayerInfo.PlayerOutfit();
			CachedLocalOutfits[type] = cachedOutfit;
		}
		return cachedOutfit;
	}

	public bool CanPet()
	{
		return !petting && !inVent && moveable;
	}

	public void AdjustLighting()
	{
		if ((bool)lightSource && (bool)ShipStatus.Instance && Data != null)
		{
			lightSource.SetViewDistance(ShipStatus.Instance.CalculateLightRadius(Data));
		}
	}

	private bool IsFlashlightEnabled()
	{
		return false;
	}

	private void SetFlashlightInputMethod()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableRightJoystick_003Ed__187))]
	private IEnumerator EnableRightJoystick(bool enabled)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CCoSetCosmetic_003Ed__188))]
	private IEnumerator CoSetCosmetic(RpcCalls rpc, string cosmeticId, byte sequenceId)
	{
		yield break;
	}

	private bool ShouldProcessRpc(RpcCalls rpc, byte sequenceId)
	{
		return true;
	}

	private byte GetNextRpcSequenceId(RpcCalls rpc)
	{
		return (byte)((int)rpc + Time.frameCount);
	}

	private MessageWriter StartRpc(byte callId, SendOption option = SendOption.Reliable, int targetClientId = -1)
	{
		if (AmongUsClient.Instance == null)
		{
			return MessageWriter.Get(option);
		}
		return AmongUsClient.Instance.StartRpcImmediately(NetId, callId, option, targetClientId);
	}

	private void FinishRpc(MessageWriter writer)
	{
		if (writer == null)
		{
			return;
		}
		if (AmongUsClient.Instance != null)
		{
			AmongUsClient.Instance.FinishRpcImmediately(writer);
		}
		else
		{
			writer.Recycle();
		}
	}

	public void RpcSetScanner(bool value)
	{
		byte count = ++scannerCount;
		SetScanner(value, count);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetScanner);
		writer.Write(value);
		writer.Write(count);
		FinishRpc(writer);
	}

	public void RpcUsePlatform()
	{
	}

	public void CmdCheckUseZipline(PlayerControl target, ZiplineBehaviour ziplineBehaviour, bool fromTop)
	{
	}

	public void CmdCheckSporeTrigger(Mushroom mushroom)
	{
	}

	public void RpcPlayAnimation(byte animType)
	{
		PlayAnimation(animType);
		MessageWriter writer = StartRpc((byte)RpcCalls.PlayAnimation, SendOption.None);
		writer.Write(animType);
		FinishRpc(writer);
	}

	public void RpcSetStartCounter(int secondsLeft)
	{
		if (DestroyableSingleton<GameStartManager>.InstanceExists)
		{
			DestroyableSingleton<GameStartManager>.Instance.SetStartCounter((sbyte)secondsLeft);
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.SetStartCounter);
		writer.Write(LastStartCounter++);
		writer.Write((sbyte)secondsLeft);
		FinishRpc(writer);
	}

	public void RpcCompleteTask(uint idx)
	{
		CompleteTask(idx);
		MessageWriter writer = StartRpc((byte)RpcCalls.CompleteTask);
		writer.Write(idx);
		FinishRpc(writer);
	}

	public void RpcSetRole(RoleTypes roleType, bool canOverrideRole = false)
	{
		StartCoroutine(CoSetRole(roleType, canOverrideRole));
		MessageWriter writer = StartRpc((byte)RpcCalls.SetRole);
		writer.Write((ushort)roleType);
		writer.Write(canOverrideRole);
		FinishRpc(writer);
	}

	public void CmdCheckName(string name)
	{
		if (AmongUsClient.Instance != null && AmongUsClient.Instance.AmHost)
		{
			CheckName(name);
			return;
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.CheckName, SendOption.Reliable, AmongUsClient.Instance != null ? AmongUsClient.Instance.HostId : -1);
		writer.Write(name);
		FinishRpc(writer);
	}

	public void RpcSetLevel(uint level)
	{
		SetLevel(level);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetLevel);
		writer.Write(level);
		FinishRpc(writer);
	}

	public void RpcSetVisor(string visorId)
	{
		SetVisor(visorId, CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetVisorStr);
		writer.Write(visorId);
		writer.Write(GetNextRpcSequenceId(RpcCalls.SetVisorStr));
		FinishRpc(writer);
	}

	public void RpcSetNamePlate(string namePlateId)
	{
		SetNamePlate(namePlateId);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetNamePlateStr);
		writer.Write(namePlateId);
		writer.Write(GetNextRpcSequenceId(RpcCalls.SetNamePlateStr));
		FinishRpc(writer);
	}

	public void RpcSetSkin(string skinId)
	{
		SetSkin(skinId, CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetSkinStr);
		writer.Write(skinId);
		writer.Write(GetNextRpcSequenceId(RpcCalls.SetSkinStr));
		FinishRpc(writer);
	}

	public void RpcSetHat(string hatId)
	{
		SetHat(hatId, CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetHatStr);
		writer.Write(hatId);
		writer.Write(GetNextRpcSequenceId(RpcCalls.SetHatStr));
		FinishRpc(writer);
	}

	public void RpcSetPet(string petId)
	{
		SetPet(petId);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetPetStr);
		writer.Write(petId);
		writer.Write(GetNextRpcSequenceId(RpcCalls.SetPetStr));
		FinishRpc(writer);
	}

	public void RpcSetName(string name)
	{
		SetName(name);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetName);
		writer.Write(name);
		FinishRpc(writer);
	}

	public void CmdCheckColor(byte bodyColor)
	{
		if (AmongUsClient.Instance != null && AmongUsClient.Instance.AmHost)
		{
			CheckColor(bodyColor);
			return;
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.CheckColor, SendOption.Reliable, AmongUsClient.Instance != null ? AmongUsClient.Instance.HostId : -1);
		writer.Write(bodyColor);
		FinishRpc(writer);
	}

	public void RpcSetColor(byte bodyColor)
	{
		SetColor(bodyColor);
		MessageWriter writer = StartRpc((byte)RpcCalls.SetColor);
		writer.Write(bodyColor);
		FinishRpc(writer);
	}

	public bool RpcSendChat(string chatText)
	{
		if (string.IsNullOrWhiteSpace(chatText))
		{
			return false;
		}
		if (DestroyableSingleton<HudManager>.InstanceExists && (bool)DestroyableSingleton<HudManager>.Instance.Chat)
		{
			DestroyableSingleton<HudManager>.Instance.Chat.AddChat(this, chatText);
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.SendChat);
		writer.Write(chatText);
		FinishRpc(writer);
		return true;
	}

	public bool RpcSendQuickChat(QuickChatPhraseBuilderResult data)
	{
		return RpcSendChat(data != null ? data.ToChatText() : string.Empty);
	}

	public void RpcSendChatNote(byte srcPlayerId, ChatNoteTypes noteType)
	{
		if (DestroyableSingleton<HudManager>.InstanceExists && (bool)DestroyableSingleton<HudManager>.Instance.Chat && (bool)GameData.Instance)
		{
			DestroyableSingleton<HudManager>.Instance.Chat.AddChatNote(GameData.Instance.GetPlayerById(srcPlayerId), noteType);
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.SendChatNote);
		writer.Write(srcPlayerId);
		writer.Write((byte)noteType);
		FinishRpc(writer);
	}

	public void CmdReportDeadBody(NetworkedPlayerInfo target)
	{
		if (AmongUsClient.Instance != null && AmongUsClient.Instance.AmHost)
		{
			ReportDeadBody(target);
			return;
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.ReportDeadBody);
		writer.Write(target != null ? target.PlayerId : byte.MaxValue);
		FinishRpc(writer);
	}

	public void RpcStartMeeting(NetworkedPlayerInfo info)
	{
		StartMeeting(info);
		MessageWriter writer = StartRpc((byte)RpcCalls.StartMeeting, SendOption.Reliable);
		writer.Write(info != null ? info.PlayerId : byte.MaxValue);
		FinishRpc(writer);
	}

	public void CmdCheckMurder(PlayerControl target)
	{
		if (AmongUsClient.Instance != null && AmongUsClient.Instance.AmHost)
		{
			CheckMurder(target);
			return;
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.CheckMurder, SendOption.Reliable, AmongUsClient.Instance != null ? AmongUsClient.Instance.HostId : -1);
		writer.WriteNetObject(target);
		FinishRpc(writer);
	}

	public void CmdCheckProtect(PlayerControl target)
	{
	}

	public void RpcMurderPlayer(PlayerControl target, bool didSucceed)
	{
		if (didSucceed)
		{
			MurderPlayer(target, MurderResultFlags.Succeeded);
		}
		MessageWriter writer = StartRpc((byte)RpcCalls.MurderPlayer, SendOption.Reliable);
		writer.WriteNetObject(target);
		writer.Write(didSucceed);
		FinishRpc(writer);
	}

	public void RpcUseZipline(PlayerControl target, ZiplineBehaviour ziplineBehaviour, bool fromTop)
	{
	}

	public void RpcTriggerSpores(Mushroom mushroom)
	{
	}

	public void RpcProtectPlayer(PlayerControl target, int colorId)
	{
		ProtectPlayer(target, colorId);
	}

	public void RpcShapeshift(PlayerControl target, bool shouldAnimate)
	{
	}

	public void CmdCheckShapeshift(PlayerControl target, bool shouldAnimate)
	{
	}

	public void RpcRejectShapeshift()
	{
		RejectShapeshift();
	}

	public void RpcSyncSettings(byte[] optionsByteArray)
	{
		MessageWriter writer = StartRpc((byte)RpcCalls.SyncSettings);
		writer.WriteBytesAndSize(optionsByteArray);
		FinishRpc(writer);
	}

	public override void ClearOrDecrementDirt()
	{
		ClearDirtyBits();
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		if (initialState)
		{
			writer.Write(isNew);
		}
		writer.Write(PlayerId);
		return true;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
		if (initialState)
		{
			isNew = reader.ReadBoolean();
		}
		PlayerId = reader.ReadByte();
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		switch ((RpcCalls)callId)
		{
		case RpcCalls.PlayAnimation:
			PlayAnimation(reader.ReadByte());
			break;
		case RpcCalls.CompleteTask:
			CompleteTask(reader.ReadUInt32());
			break;
		case RpcCalls.SetRole:
			StartCoroutine(CoSetRole((RoleTypes)reader.ReadUInt16(), reader.ReadBoolean()));
			break;
		case RpcCalls.CheckName:
			CheckName(reader.ReadString());
			break;
		case RpcCalls.SetName:
			SetName(reader.ReadString());
			break;
		case RpcCalls.CheckColor:
			CheckColor(reader.ReadByte());
			break;
		case RpcCalls.SetColor:
			SetColor(reader.ReadByte());
			break;
		case RpcCalls.SetHatStr:
			SetHat(reader.ReadString(), CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
			break;
		case RpcCalls.SetSkinStr:
			SetSkin(reader.ReadString(), CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
			break;
		case RpcCalls.SetPetStr:
			SetPet(reader.ReadString());
			break;
		case RpcCalls.SetVisorStr:
			SetVisor(reader.ReadString(), CurrentOutfit != null ? CurrentOutfit.ColorId : PlayerCustomization.ColorId);
			break;
		case RpcCalls.SetNamePlateStr:
			SetNamePlate(reader.ReadString());
			break;
		case RpcCalls.SetLevel:
			SetLevel(reader.ReadUInt32());
			break;
		case RpcCalls.ReportDeadBody:
			ReportDeadBody(GameData.Instance != null ? GameData.Instance.GetPlayerById(reader.ReadByte()) : null);
			break;
		case RpcCalls.MurderPlayer:
			MurderPlayer(reader.ReadNetObject<PlayerControl>(), MurderResultFlags.Succeeded);
			break;
		case RpcCalls.SendChat:
			if (DestroyableSingleton<HudManager>.InstanceExists && (bool)DestroyableSingleton<HudManager>.Instance.Chat)
			{
				DestroyableSingleton<HudManager>.Instance.Chat.AddChat(this, reader.ReadString());
			}
			break;
		case RpcCalls.SendChatNote:
			if (DestroyableSingleton<HudManager>.InstanceExists && (bool)DestroyableSingleton<HudManager>.Instance.Chat && (bool)GameData.Instance)
			{
				DestroyableSingleton<HudManager>.Instance.Chat.AddChatNote(GameData.Instance.GetPlayerById(reader.ReadByte()), (ChatNoteTypes)reader.ReadByte());
			}
			break;
		case RpcCalls.SetScanner:
			SetScanner(reader.ReadBoolean(), reader.ReadByte());
			break;
		case RpcCalls.SetStartCounter:
			if (DestroyableSingleton<GameStartManager>.InstanceExists)
			{
				DestroyableSingleton<GameStartManager>.Instance.SetStartCounter(reader.ReadSByte());
			}
			break;
		case RpcCalls.StartMeeting:
			StartMeeting(GameData.Instance != null ? GameData.Instance.GetPlayerById(reader.ReadByte()) : null);
			break;
		case RpcCalls.CheckMurder:
			CheckMurder(reader.ReadNetObject<PlayerControl>());
			break;
		default:
			HandleRoleRpc(callId, reader);
			break;
		}
	}

	public virtual void HandleRoleRpc(byte callId, MessageReader reader)
	{
	}

	public void HandleServerVanish()
	{
	}

	public void HandleServerAppear(bool shouldAnimate)
	{
	}

	public void CheckVanish()
	{
	}

	public void RpcVanish()
	{
	}

	public void CheckAppear(bool shouldAnimate)
	{
	}

	public void RpcAppear(bool shouldAnimate)
	{
	}

	public void CmdCheckVanish(float maxDuration)
	{
	}

	public void CmdCheckAppear(bool shouldAnimate)
	{
	}
}
