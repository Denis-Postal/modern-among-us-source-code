using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.InnerNet;
using Epic.OnlineServices;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Platform;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class EOSManager : DestroyableSingleton<EOSManager>
{
	public enum AccountLoginStatus
	{
		Offline = 0,
		LoggedIn = 1,
		WaitingForParent = 2,
		TempAccount = 3
	}

	public enum EOS_ERRORS
	{
		FailedEpicAuthToken = 0,
		UnsupportedPlatform = 1,
		LinkAccountFail = 2,
		SteamworksAppTicketFail = 3,
		SteamworksAuthFail = 4,
		iOSAuthFail = 5,
		GoogleAuthFail = 6,
		GoogleAuthNoToken = 7,
		NullContinuanceToken = 8,
		MismatchedProductUserIDs = 9,
		GenericLoginError = 10,
		XboxUserAddError = 11,
		XboxGetTokenError = 12,
		AccountCreationFail = 13,
		InterfaceInitFail = 14,
		InvalidParentEmail = 15,
		GuestModeAuthFail = 16,
		PlatformNotSupported = 17,
		NintendoAuthFailed = 18,
		PlayStationAuthFailed = 19,
		AccountLinkFail = 20,
		NoConnectionError = 21,
		ItchIOAuthFail = 22,
		UnlinkAccountFail = 23,
		FriendCodeFail = 24,
		TempAccountError = 25
	}

	[CompilerGenerated]
	private sealed class _003CCheckMissingGuardianEmail_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueryPermissionsCallbackInfo permissionsCallbackInfo;

		public Action cb;

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
		public _003CCheckMissingGuardianEmail_003Ed__101(int _003C_003E1__state)
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
	private sealed class _003CCoUpdateInventoryOrValidateReceipts_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

		private PlayerStorageManager.CloudPlayerPrefs _003Cprefs_003E5__2;

		private uint _003CplatformFlag_003E5__3;

		private CompletionToken<PurchaseStates> _003CvalidateSpecialItems_003E5__4;

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
		public _003CCoUpdateInventoryOrValidateReceipts_003Ed__118(int _003C_003E1__state)
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
	private sealed class _003CInitializeStore_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CInitializeStore_003Ed__117(int _003C_003E1__state)
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
	private sealed class _003CRefreshPlayerStorageManager_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

		public Action callback;

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
		public _003CRefreshPlayerStorageManager_003Ed__98(int _003C_003E1__state)
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
	private sealed class _003CRequestMergeGuestAccount_003Ed__141 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Request<MergeGuestAccount> requestData;

		public EOSManager _003C_003E4__this;

		public Action<ResponseState> resultCallback;

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
		public _003CRequestMergeGuestAccount_003Ed__141(int _003C_003E1__state)
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
	private sealed class _003CRunLogin_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

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
		public _003CRunLogin_003Ed__81(int _003C_003E1__state)
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
	private sealed class _003CShowAgePrompt_003Ed__123 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

		public Action callback;

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
		public _003CShowAgePrompt_003Ed__123(int _003C_003E1__state)
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
	private sealed class _003CShowSignInWindow_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

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
		public _003CShowSignInWindow_003Ed__93(int _003C_003E1__state)
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
	private sealed class _003CUpdateFriendCodeAndInventory_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

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
		public _003CUpdateFriendCodeAndInventory_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CWaitForLoginFlow_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

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
		public _003CWaitForLoginFlow_003Ed__153(int _003C_003E1__state)
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
	private sealed class _003CWaitForStorageToSave_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EOSManager _003C_003E4__this;

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
		public _003CWaitForStorageToSave_003Ed__115(int _003C_003E1__state)
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

	[SerializeField]
	private string productName;

	[SerializeField]
	private string productVersion;

	[SerializeField]
	private string productId;

	[SerializeField]
	private string sandboxId;

	private string deploymentId;

	[SerializeField]
	private string clientId;

	[SerializeField]
	private string clientSecret;

	[SerializeField]
	private string friendCode;

	private bool hasRunLoginFlow;

	private const float platformTickInterval = 0.1f;

	private float platformTickTimer;

	private bool platformInitialized;

	private bool loginFlowFinished;

	private bool tryingToLogin;

	private bool stopTimeOutCheck;

	public GameObject TimeOutPopup;

	public float TimeOutTime;

	public bool FinishedAssets;

	private PlatformInterface platformInterface;

	private ProductUserId userId;

	private ProductUserId deviceIDuserID;

	public bool announcementsVisible;

	private bool attemptAuthAgain;

	private uint numLinkedAccounts;

	public List<ExternalAccountInfo> linkedExternalAccounts;

	public EditAccountUsername editAccountUsername;

	public AskToMergeGuest askToMergeAccount;

	private string freeChatKey;

	private string customNameKey;

	private string friendsListKey;

	private string accountLinkKey;

	[SerializeField]
	private List<TextMeshProUGUI> watermark;

	[SerializeField]
	private GameObject watermarkCanvas;

	private readonly Logger logger;

	private int ageOfConsent;

	private string kwsUserId;

	private bool isKWSMinor;

	private ContinuanceToken continuanceToken;

	public string exchangeToken;

	private string platformAuthToken;

	private DateTime serverTimeOnLaunch;

	private bool authExpiredCallbackTriggered;

	private bool silentLoginFailed;

	public CompletionToken<PurchaseStates> validateOldDLC;

	public bool isRedeemingDLC;

	private PlatformInterface s_eosPlatformInterface;

	private CallResult<EncryptedAppTicketResponse_t> OnEncryptedAppTicketResponseCallResult;

	private OnLoginCallback successCallback;

	private Action onLoginFailedCallback;

	public string ProductName => null;

	public string ProductVersion => null;

	public string ProductId => null;

	public string SandboxId => null;

	public string DeploymentId => null;

	public string ClientId => null;

	public string ClientSecret => null;

	public string FriendCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PlatformInterface PlatformInterface => null;

	public string ProductUserId => null;

	public string UserIDToken => null;

	public string DeviceIDUserIDToken => null;

	public string DeviceIDProductUserId => null;

	public DateTime ApproximateServerTime => default(DateTime);

	public bool HasServerTimestamp => false;

	public override void Awake()
	{
	}

	public void InitializePlatformInterface()
	{
	}

	private void KWSPermissionsUpdatedCallback(ref PermissionsUpdateReceivedCallbackInfo permissionsCallbackInfo)
	{
	}

	private void OnAuthExpirationCallback(ref AuthExpirationCallbackInfo data)
	{
	}

	public void ShowTimeout()
	{
	}

	public void HideTimeout()
	{
	}

	public void PlayOffline()
	{
	}

	[IteratorStateMachine(typeof(_003CRunLogin_003Ed__81))]
	public IEnumerator RunLogin()
	{
		return null;
	}

	public void StartInitialLoginFlow()
	{
	}

	private void BeginLoginFlowWithDeviceID()
	{
	}

	private void LogInToDeviceIDOnStartupCallback(ref LoginCallbackInfo loginCallbackInfo)
	{
	}

	private void BeginLoginFlowWithPlatform()
	{
	}

	private void PlatformAuthReturn()
	{
	}

	private void AbortToMainMenuThrowError()
	{
	}

	private void GetAgeOfConsentFromKWS()
	{
	}

	private void KWSQueryAgeGateCallback(ref QueryAgeGateCallbackInfo ageGateCallbackInfo)
	{
	}

	private void UpdateGuardianEmailDisplayAndLoginToPlatform()
	{
	}

	public void LoginWithCorrectPlatform()
	{
	}

	private void EOSConnectPlatformLoginCallback(ref LoginCallbackInfo loginCallbackInfo)
	{
	}

	[IteratorStateMachine(typeof(_003CShowSignInWindow_003Ed__93))]
	private IEnumerator ShowSignInWindow()
	{
		return null;
	}

	private void ShowSignInScreen()
	{
	}

	public void CreateAccountWithPlatformAuth()
	{
	}

	private void EOSConnectCreateUserCallback(ref Epic.OnlineServices.Connect.CreateUserCallbackInfo createUserCallbackInfo)
	{
	}

	private void EndLoginFlowWithPlatform()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshPlayerStorageManager_003Ed__98))]
	private IEnumerator RefreshPlayerStorageManager(Action callback)
	{
		return null;
	}

	private void BeginKWSPermissionsFlow()
	{
	}

	private void QueryKWSPermissions()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckMissingGuardianEmail_003Ed__101))]
	private IEnumerator CheckMissingGuardianEmail(QueryPermissionsCallbackInfo permissionsCallbackInfo, Action cb)
	{
		return null;
	}

	private void KWSQueryPermissionsOnPlatformLoginCallback(ref QueryPermissionsCallbackInfo permissionsCallbackInfo)
	{
	}

	private void AdultPermissionsFlow()
	{
	}

	public void CreateKWSUer()
	{
	}

	private void CreateKWSUserCallback(ref Epic.OnlineServices.KWS.CreateUserCallbackInfo createUserCallbackInfo)
	{
	}

	private void UpdatePermissionKeys(Action callback)
	{
	}

	private void FinishInitialLoginFlowAndDisplayLoginSuccess()
	{
	}

	private void EndKWSPermissionsFlow()
	{
	}

	private void BeginMergeGuestAccountFlow()
	{
	}

	private void CheckGuestAccountMigrationStuff()
	{
	}

	private void DeleteDeviceID(Action callback)
	{
	}

	private void MergeGuestAccountIntoPlatform()
	{
	}

	private void EndMergeGuestAccountFlow()
	{
	}

	private void BeginFinalPartsOfLoginFlow()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForStorageToSave_003Ed__115))]
	private IEnumerator WaitForStorageToSave()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUpdateFriendCodeAndInventory_003Ed__116))]
	private IEnumerator UpdateFriendCodeAndInventory()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInitializeStore_003Ed__117))]
	private IEnumerator InitializeStore()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoUpdateInventoryOrValidateReceipts_003Ed__118))]
	private IEnumerator CoUpdateInventoryOrValidateReceipts()
	{
		return null;
	}

	private void HandleEosLogging(ref LogMessage msg)
	{
	}

	public void ContinueInOfflineMode()
	{
	}

	private void IsAllowedOnline(bool canOnline)
	{
	}

	private void CheckAndShowAgePromptIfNeeded(Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CShowAgePrompt_003Ed__123))]
	private IEnumerator ShowAgePrompt(Action callback)
	{
		return null;
	}

	public void LoginFromAccountTab()
	{
	}

	private void EOSConnectPlatformSilentLoginCallback(ref LoginCallbackInfo loginCallbackInfo)
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private GameObject FindPlayOnlineButton()
	{
		return null;
	}

	public void GoOfflineFromPermissionsWindow()
	{
	}

	public void GoOfflineFromPlatformSignout()
	{
	}

	public void GetExternalAccountInfo(string targetPUID, Platforms targetAccountPlatform, Action<ExternalAccountInfo?> callback)
	{
	}

	private ExternalAccountInfo? GetExternalAccountInfo(ProductUserId targetPUID, ExternalAccountType? targetAccountType)
	{
		return null;
	}

	public void UpdateInventory()
	{
	}

	public void EndFinalPartsOfLoginFlow()
	{
	}

	public void EndFinalPartsOfLoginFlowFullAccount()
	{
	}

	public void EndFinalPartsOfLoginFlowTempAccount()
	{
	}

	public void EndFinalPartsOfLoginFlowOffline()
	{
	}

	[IteratorStateMachine(typeof(_003CRequestMergeGuestAccount_003Ed__141))]
	private IEnumerator RequestMergeGuestAccount(Request<MergeGuestAccount> requestData, Action<ResponseState> resultCallback)
	{
		return null;
	}

	public void ClearAuthToken()
	{
	}

	public string GetPlatformAuthToken()
	{
		return null;
	}

	public void UpdateGuardianEmail()
	{
	}

	public void ResendGuardianEmail()
	{
	}

	private void RequestPermissionsCallback(ref RequestPermissionsCallbackInfo requestPermissionsCallbackInfo)
	{
	}

	private void UpdateGuardianEmailSettingsCallback(ref UpdateParentEmailCallbackInfo updateParentEmailCallbackInfo)
	{
	}

	public bool IsMinorByDate(DateTime date)
	{
		return false;
	}

	public bool IsMinorByDate(int year, int month, int day)
	{
		return false;
	}

	public bool IsMinorOrWaiting()
	{
		return false;
	}

	public bool IsFriendsListAllowed()
	{
		return false;
	}

	public bool IsFreechatAllowed()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWaitForLoginFlow_003Ed__153))]
	public IEnumerator WaitForLoginFlow()
	{
		return null;
	}

	public bool HasFinishedLoginFlow()
	{
		return false;
	}

	public void SetServerTimeStamp(DateTime utcTime)
	{
	}

	private void CloseStartupWaitScreen()
	{
	}

	private void ShowCallbackWaitAnim()
	{
	}

	private void HideCallbackWaitAnim()
	{
	}

	private void OnEnable()
	{
	}

	private new void OnDestroy()
	{
	}

	private void Update()
	{
	}

	[ContextMenu("Shutdown")]
	private void DoShutdown()
	{
	}

	private void DumpEGSPluginLogs()
	{
	}

	public void StartTempAccountFlow()
	{
	}

	private void LoginWithDeviceID()
	{
	}

	private void AuthWithCorrectPlatformImpl()
	{
	}

	private void OnSteamEncryptedAppTicketLoginCallback(EncryptedAppTicketResponse_t pCallback, bool bIOFailure)
	{
	}

	private void LoginWithCorrectPlatformImpl(OnLoginCallback successCallback, Action onLoginFailed = null)
	{
	}

	public void LoginSilentlyImpl()
	{
	}

	private void RetryAuthAndLoginImpl(OnLoginCallback successCallback, Action onLoginFailed = null)
	{
	}

	private void OnSteamEncryptedAppTicketLoginCallbackRetry(EncryptedAppTicketResponse_t pCallback, bool bIOFailure)
	{
	}
}
