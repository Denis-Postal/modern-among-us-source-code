using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class HudManager : DestroyableSingleton<HudManager>
{
	[CompilerGenerated]
	private sealed class _003CCoDelayedInitTouchType_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

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
		public _003CCoDelayedInitTouchType_003Ed__101(int _003C_003E1__state)
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
	private sealed class _003CCoFadeFullScreen_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		public bool showLoader;

		public Color target;

		public Color source;

		public float duration;

		private float _003Ct_003E5__2;

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
		public _003CCoFadeFullScreen_003Ed__87(int _003C_003E1__state)
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
	private sealed class _003CCoReactorFlash_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private bool _003Clight_003E5__3;

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
		public _003CCoReactorFlash_003Ed__88(int _003C_003E1__state)
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
	private sealed class _003CCoShowIntro_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

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
		public _003CCoShowIntro_003Ed__89(int _003C_003E1__state)
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
	private sealed class _003CCoTaskComplete_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudManager _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CCoTaskComplete_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003CShowEmblem_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool shhh;

		public HudManager _003C_003E4__this;

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
		public _003CShowEmblem_003Ed__81(int _003C_003E1__state)
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

	public FollowerCamera PlayerCam;

	public Camera UICamera;

	public MeetingHud MeetingPrefab;

	public KillButton KillButton;

	public AdminButton AdminButton;

	public SabotageButton SabotageButton;

	public VentButton ImpostorVentButton;

	public UseButton UseButton;

	public PetButton PetButton;

	public AbilityButton AbilityButton;

	public SecondaryAbilityButton SecondaryAbilityButton;

	public ReportButton ReportButton;

	public GameObject TaskStuff;

	public TaskPanelBehaviour TaskPanel;

	public CrewmatesKilledTracker CrewmatesKilled;

	public ChatController Chat;

	public DialogueBox Dialogue;

	public Transform TaskCompleteOverlay;

	private float taskDirtyTimer;

	public MeshRenderer ShadowQuad;

	public SpriteRenderer FullScreen;

	public PassiveButton MapButton;

	public GameObject MapButtonGlyph;

	public KillOverlay KillOverlay;

	public IVirtualJoystick joystick;

	public VirtualJoystick joystickR;

	public MonoBehaviour[] Joysticks;

	public MonoBehaviour RightVJoystick;

	public Collider2D LeftStickDeadZone;

	public Collider2D RightStickDeadZone;

	public DiscussBehaviour discussEmblem;

	public ShhhBehaviour shhhEmblem;

	public IntroCutscene IntroPrefab;

	public OptionsMenuBehaviour GameMenu;

	public NotificationPopper Notifier;

	public RoomTracker roomTracker;

	public AudioClip TaskCompleteSound;

	public AudioClip TaskUpdateSound;

	public Transform consoleUIRoot;

	public GameObject[] consoleUIObjects;

	public GameObject menuNavigationPrompts;

	public GameObject GameLoadAnimation;

	public LobbyTimerExtensionUI LobbyTimerExtensionUI;

	[NonSerialized]
	public float consoleUIHorizontalShift;

	public GameObject playerListPrompt;

	public AlertFlash AlertFlash;

	public DangerMeter DangerMeter;

	public GameObject SettingsButton;

	private StringBuilder tasksString;

	private DualshockLightManager.LightOverlayHandle lightFlashHandle;

	public Coroutine ReactorFlash { get; set; }

	public Coroutine OxyFlash { get; set; }

	public bool IsIntroDisplayed { get; private set; }

	public void Start()
	{
	}

	public void OnGameStart()
	{
	}

	public void ShowTaskComplete()
	{
	}

	[IteratorStateMachine(typeof(_003CCoTaskComplete_003Ed__65))]
	private IEnumerator CoTaskComplete()
	{
		return null;
	}

	public void SetJoystickSize(float size)
	{
	}

	private void SetVirtualJoystickSize(VirtualJoystick jStick, float size, Vector2 dist)
	{
	}

	public void SetTouchType(ControlTypes type)
	{
	}

	public void InitMap()
	{
	}

	public void DeselectMapButton()
	{
	}

	public void ToggleMapVisible(MapOptions options)
	{
	}

	public void SetHudActive(PlayerControl localPlayer, RoleBehaviour role, bool isActive)
	{
	}

	public void UpdateVoteTimerText(StringNames key, int value)
	{
	}

	public void SetHudActive(bool isActive)
	{
	}

	public void ToggleRightJoystick(bool isActive)
	{
	}

	public void ToggleMapButton(bool isActive)
	{
	}

	public void ToggleMapButtonGlyph(bool isActive)
	{
	}

	public void SetMapButtonEnabled(bool enabled)
	{
	}

	public void ToggleSettingsButton(bool isActive)
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CShowEmblem_003Ed__81))]
	public IEnumerator ShowEmblem(bool shhh)
	{
		return null;
	}

	public void StartReactorFlash()
	{
	}

	public void StartOxyFlash()
	{
	}

	public void ShowPopUp(string text)
	{
	}

	public void StopReactorFlash()
	{
	}

	public void StopOxyFlash()
	{
	}

	[IteratorStateMachine(typeof(_003CCoFadeFullScreen_003Ed__87))]
	public IEnumerator CoFadeFullScreen(Color source, Color target, float duration = 0.2f, bool showLoader = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoReactorFlash_003Ed__88))]
	private IEnumerator CoReactorFlash()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoShowIntro_003Ed__89))]
	public IEnumerator CoShowIntro()
	{
		return null;
	}

	public void HideGameLoader()
	{
	}

	public void OpenMeetingRoom(PlayerControl reporter)
	{
	}

	public void SetAlertOverlay(bool enabled)
	{
	}

	public override void OnDestroy()
	{
	}

	public void NotifyOfDeath()
	{
	}

	public void NotifyOfDisconnect(PlayerControl pc)
	{
	}

	public void ToggleUseAndPetButton(IUsable useTarget, bool canPlayNormally, bool canPet)
	{
		if ((bool)UseButton)
		{
			UseButton.SetTarget(canPlayNormally ? useTarget : null);
		}
		if ((bool)PetButton)
		{
			PetButton.gameObject.SetActive(canPet);
		}
	}

	public void ShowLobbyTimer(int timeRemainingSeconds)
	{
	}

	public void ShowLobbyTimerPopup(int timeRemainingSeconds, int timeGrantedSeconds)
	{
	}

	public void OnLobbyTimerExtended()
	{
	}

	private void DelayedInitTouchType()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDelayedInitTouchType_003Ed__101))]
	private IEnumerator CoDelayedInitTouchType()
	{
		return null;
	}
}
