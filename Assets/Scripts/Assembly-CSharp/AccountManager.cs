using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Epic.OnlineServices.KWS;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class AccountManager : DestroyableSingleton<AccountManager>
{
	[CompilerGenerated]
	private sealed class _003CCheckFriendCodeAndUpdateVisuals_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

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
		public _003CCheckFriendCodeAndUpdateVisuals_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CEditGuardianEmail_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

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
		public _003CEditGuardianEmail_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CGetInfoRequest_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CGetInfoRequest_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CShowAgeGate_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

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
		public _003CShowAgeGate_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CUpdateMissingGuardianEmail_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AccountManager _003C_003E4__this;

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
		public _003CUpdateMissingGuardianEmail_003Ed__33(int _003C_003E1__state)
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

	private static readonly string[] ACCOUNT_TAB_SCENES;

	[SerializeField]
	private AccountTab accountTab;

	[SerializeField]
	private GameObject accountWindow;

	[SerializeField]
	private PermissionsRequest enterGuardianEmailWindow;

	[SerializeField]
	private UpdateGuardianEmail updateGuardianEmailWindow;

	[SerializeField]
	private InfoTextBox guardianEmailConfirmWindow;

	[SerializeField]
	private InfoTextBox genericInfoDisplayBox;

	[SerializeField]
	private AgeGateScreen enterDateOfBirthScreen;

	public GameObject waitingText;

	public GameObject postLoadWaiting;

	public GameObject privacyPolicyBg;

	public SignInScreen signInScreen;

	public PrivacyPolicyScreen PrivacyPolicy;

	private IChatModeDisplay chatModeMenuScreen;

	public KWSPermissionStatus freeChatAllowed;

	public KWSPermissionStatus customDisplayName;

	public KWSPermissionStatus friendsListAllowed;

	public KWSPermissionStatus accountLinkingAllowed;

	public Action OnLoggedInStatusChange;

	private EOSManager.AccountLoginStatus prevLoggedInStatus;

	[SerializeField]
	private TextMeshPro accountDeletionText;

	private bool isAccountWaitingForDeletion;

	public bool IsAccountWaitingForDeletion => false;

	public bool AccountTabActive => false;

	public void UpdateKidAccountDisplay()
	{
	}

	public void SetChatModeButtonForUpdates(IChatModeDisplay modeCycle)
	{
	}

	public void UpdateAccountInfoDisplays()
	{
	}

	public void ShowGuardianEmailSentConfirm()
	{
	}

	public void ShowPermissionsRequestForm()
	{
	}

	public void CreateAccount()
	{
	}

	[IteratorStateMachine(typeof(_003CEditGuardianEmail_003Ed__32))]
	public IEnumerator EditGuardianEmail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUpdateMissingGuardianEmail_003Ed__33))]
	public IEnumerator UpdateMissingGuardianEmail()
	{
		return null;
	}

	public void UpdateGuardianEmailDisplay()
	{
	}

	[IteratorStateMachine(typeof(_003CShowAgeGate_003Ed__35))]
	public IEnumerator ShowAgeGate()
	{
		return null;
	}

	public void CheckAndRegenerateName()
	{
	}

	public bool CanMinorSetCustomDisplayName()
	{
		return false;
	}

	public bool HasMinorsGuardianEverUpdatedAnything()
	{
		return false;
	}

	public void RandomizeName()
	{
	}

	public string GetRandomName()
	{
		return null;
	}

	private bool ValidateRandomName()
	{
		return false;
	}

	public override void Awake()
	{
	}

	public override void OnDestroy()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public void SignInSuccess(Action callback)
	{
	}

	public void SignInFail(EOSManager.EOS_ERRORS error, Action callback)
	{
	}

	public void PlatformSignInFail()
	{
	}

	public void SetDLLErrorMode()
	{
	}

	public void UpdateVisuals()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckFriendCodeAndUpdateVisuals_003Ed__50))]
	private IEnumerator CheckFriendCodeAndUpdateVisuals()
	{
		return null;
	}

	public void UpdatePlayerCustomizationVisuals()
	{
	}

	public bool CanPlayOnline()
	{
		return false;
	}

	public void GetDeletionInfo()
	{
	}

	[IteratorStateMachine(typeof(_003CGetInfoRequest_003Ed__54))]
	private IEnumerator GetInfoRequest()
	{
		return null;
	}

	public void UpdateAccountDeletionStatus(bool shouldDelete)
	{
	}

	public void OpenAccountWindow()
	{
	}

	public void CloseAccountWindow()
	{
	}
}
