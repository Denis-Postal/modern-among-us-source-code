using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.QuickChat;
using TMPro;
using UnityEngine;

public class ChatController : MonoBehaviour
{
	private delegate string GetFormattedNameFunc(string name);

	[CompilerGenerated]
	private sealed class _003CBounceDot_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

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
		public _003CBounceDot_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CCoClose_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private Vector3 _003Cscale_003E5__3;

		private float _003CtargetScale_003E5__4;

		private float _003Ctimer_003E5__5;

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
		public _003CCoClose_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CCoOpen_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatController _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private Vector3 _003Cscale_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CCoOpen_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CWaitForNameToExist_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkedPlayerInfo player;

		public Action<NetworkedPlayerInfo> onNameExistsCallback;

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
		public _003CWaitForNameToExist_003Ed__65(int _003C_003E1__state)
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

	private const float SCREEN_SIZE_PERCENT = 0.8f;

	private const float MAX_CHAT_SEND_RATE = 3f;

	private const float X_DISTANCE_FROM_QUICKCHAT = -0.39f;

	private static readonly Logger Logger;

	[Header("Buttons")]
	[SerializeField]
	private PassiveButton chatButton;

	[SerializeField]
	private AspectPosition chatButtonAspectPosition;

	[SerializeField]
	[Space(10f)]
	private BanMenu banButton;

	[SerializeField]
	private GameObject openKeyboardButton;

	[SerializeField]
	private PassiveButton quickChatButton;

	[Header("Chat Screen")]
	[SerializeField]
	private GameObject chatScreen;

	[SerializeField]
	private ObjectPoolBehavior chatBubblePool;

	[SerializeField]
	private Scroller scroller;

	[SerializeField]
	private SpriteRenderer backgroundImage;

	[SerializeField]
	private SpriteRenderer chatNotifyDot;

	[SerializeField]
	private TextMeshPro sendRateMessageText;

	[SerializeField]
	private AspectPosition aspectPosition;

	[SerializeField]
	[Header("Free Chat")]
	private FreeChatInputField freeChatField;

	[Header("Quick Chat")]
	[SerializeField]
	private QuickChatMenu quickChatMenu;

	[SerializeField]
	private QuickChatPreviewField quickChatField;

	[Header("SFX")]
	[SerializeField]
	private AudioClip messageSound;

	[SerializeField]
	private AudioClip warningSound;

	[Header("Animations")]
	[SerializeField]
	private AnimationCurve chatAnimationIn;

	[SerializeField]
	private AnimationCurve chatAnimationOut;

	[Header("Console Controller Navigation")]
	[SerializeField]
	private UiElement backButton;

	[SerializeField]
	private UiElement defaultButtonSelected;

	[SerializeField]
	private List<UiElement> controllerSelectable;

	[SerializeField]
	private ChatNotification chatNotification;

	private ChatControllerState state;

	private Vector3 targetChatPosition;

	private float timeSinceLastMessage;

	private Coroutine notificationRoutine;

	private SpecialInputHandler specialInputHandler;

	private float targetScale;

	public ChatControllerState State => default(ChatControllerState);

	public bool IsOpenOrOpening => false;

	public bool IsClosedOrClosing => false;

	public bool IsAnimating => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void SendChat()
	{
	}

	public void OnMeetingStart()
	{
	}

	private void UpdateChatMode()
	{
	}

	private void CheckKeyboardButton()
	{
	}

	private void OnChatModeSettingsChanged()
	{
	}

	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public void Close()
	{
	}

	public void ForceClosed()
	{
	}

	public void Toggle()
	{
	}

	public void HideBanButton()
	{
	}

	public void UpdateVoteTimerText(StringNames key, int value)
	{
	}

	[IteratorStateMachine(typeof(_003CCoOpen_003Ed__59))]
	private IEnumerator CoOpen()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoClose_003Ed__60))]
	private IEnumerator CoClose()
	{
		return null;
	}

	public void AddChatNote(NetworkedPlayerInfo srcPlayer, ChatNoteTypes noteType)
	{
	}

	public void AddChat(PlayerControl sourcePlayer, string chatText, bool censor = true)
	{
	}

	public void AddChatWarning(string warningText)
	{
	}

	private void SetChatBubbleName(ChatBubble bubble, NetworkedPlayerInfo playerInfo, bool isDead, bool didVote, Color nameColor, GetFormattedNameFunc getFormattedNameFunc = null)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForNameToExist_003Ed__65))]
	private IEnumerator WaitForNameToExist(NetworkedPlayerInfo player, Action<NetworkedPlayerInfo> onNameExistsCallback)
	{
		return null;
	}

	private void AlignAllBubbles()
	{
	}

	[IteratorStateMachine(typeof(_003CBounceDot_003Ed__67))]
	private IEnumerator BounceDot()
	{
		return null;
	}

	private ChatBubble GetPooledBubble()
	{
		return null;
	}

	private void OnFreeChatSubmit()
	{
	}

	private void OnFreeChatChanged()
	{
	}

	private void SendFreeChat()
	{
	}

	private void OpenQuickChat()
	{
	}

	private void OnQuickChatOpened()
	{
	}

	private void OnQuickChatClosed()
	{
	}

	private void OnQuickChatSubmit()
	{
	}

	private void OnQuickChatClearPressed()
	{
	}

	private void OnQuickChatUndoPressed()
	{
	}

	private void OnQuickChatBuilderChanged(QuickChatPhraseBuilder builder)
	{
	}

	private void OnQuickChatButtonClicked()
	{
	}

	private void SendQuickChat()
	{
	}
}
