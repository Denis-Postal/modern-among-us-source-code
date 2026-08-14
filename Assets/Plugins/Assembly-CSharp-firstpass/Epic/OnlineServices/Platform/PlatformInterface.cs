using System;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.AntiCheatClient;
using Epic.OnlineServices.AntiCheatServer;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.CustomInvites;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.IntegratedPlatform;
using Epic.OnlineServices.Inventory;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Metrics;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.ReceiptValidator;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;

namespace Epic.OnlineServices.Platform
{
	public sealed class PlatformInterface : Handle
	{
		public const int AndroidInitializeoptionssysteminitializeoptionsApiLatest = 2;

		public static readonly Utf8String CheckforlauncherandrestartEnvVar;

		public const int ClientcredentialsClientidMaxLength = 64;

		public const int ClientcredentialsClientsecretMaxLength = 64;

		public const int CountrycodeMaxBufferLen = 5;

		public const int CountrycodeMaxLength = 4;

		public const int GetdesktopcrossplaystatusApiLatest = 1;

		public const int InitializeApiLatest = 4;

		public const int InitializeThreadaffinityApiLatest = 3;

		public const int InitializeoptionsProductnameMaxLength = 64;

		public const int InitializeoptionsProductversionMaxLength = 64;

		public const int LocalecodeMaxBufferLen = 10;

		public const int LocalecodeMaxLength = 9;

		public const int OptionsApiLatest = 14;

		public const int OptionsDeploymentidMaxLength = 64;

		public const int OptionsEncryptionkeyLength = 64;

		public const int OptionsProductidMaxLength = 64;

		public const int OptionsSandboxidMaxLength = 64;

		public const int RtcoptionsApiLatest = 2;

		public const int Ps4InitializeoptionssysteminitializeoptionsApiLatest = 8;

		public const int Ps5InitializeoptionssysteminitializeoptionsApiLatest = 3;

		public const int WindowsRtcoptionsplatformspecificoptionsApiLatest = 1;

		public const int XboxonegdkInitializeoptionssysteminitializeoptionsApiLatest = 3;

		public const int XboxonegdkOptionssystemspecificoptionsApiLatest = 1;

		public const int XsxInitializeoptionssysteminitializeoptionsApiLatest = 3;

		public const int XsxOptionssystemspecificoptionsApiLatest = 1;

		public static Result Initialize(ref AndroidInitializeOptions options)
		{
			return default(Result);
		}

		public PlatformInterface()
		{
		}

		public PlatformInterface(IntPtr innerHandle)
		{
		}

		public Result CheckForLauncherAndRestart()
		{
			return default(Result);
		}

		public static PlatformInterface Create(ref Options options)
		{
			return null;
		}

		public AchievementsInterface GetAchievementsInterface()
		{
			return null;
		}

		public Result GetActiveCountryCode(EpicAccountId localUserId, out Utf8String outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result GetActiveLocaleCode(EpicAccountId localUserId, out Utf8String outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public AntiCheatClientInterface GetAntiCheatClientInterface()
		{
			return null;
		}

		public AntiCheatServerInterface GetAntiCheatServerInterface()
		{
			return null;
		}

		public ApplicationStatus GetApplicationStatus()
		{
			return default(ApplicationStatus);
		}

		public AuthInterface GetAuthInterface()
		{
			return null;
		}

		public ConnectInterface GetConnectInterface()
		{
			return null;
		}

		public CustomInvitesInterface GetCustomInvitesInterface()
		{
			return null;
		}

		public Result GetDesktopCrossplayStatus(ref GetDesktopCrossplayStatusOptions options, out DesktopCrossplayStatusInfo outDesktopCrossplayStatusInfo)
		{
			outDesktopCrossplayStatusInfo = default(DesktopCrossplayStatusInfo);
			return default(Result);
		}

		public EcomInterface GetEcomInterface()
		{
			return null;
		}

		public FriendsInterface GetFriendsInterface()
		{
			return null;
		}

		public IntegratedPlatformInterface GetIntegratedPlatformInterface()
		{
			return null;
		}

		public InventoryInterface GetInventoryInterface()
		{
			return null;
		}

		public KWSInterface GetKWSInterface()
		{
			return null;
		}

		public LeaderboardsInterface GetLeaderboardsInterface()
		{
			return null;
		}

		public LobbyInterface GetLobbyInterface()
		{
			return null;
		}

		public MetricsInterface GetMetricsInterface()
		{
			return null;
		}

		public ModsInterface GetModsInterface()
		{
			return null;
		}

		public NetworkStatus GetNetworkStatus()
		{
			return default(NetworkStatus);
		}

		public Result GetOverrideCountryCode(out Utf8String outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public Result GetOverrideLocaleCode(out Utf8String outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public P2PInterface GetP2PInterface()
		{
			return null;
		}

		public PlayerDataStorageInterface GetPlayerDataStorageInterface()
		{
			return null;
		}

		public PresenceInterface GetPresenceInterface()
		{
			return null;
		}

		public ProgressionSnapshotInterface GetProgressionSnapshotInterface()
		{
			return null;
		}

		public RTCAdminInterface GetRTCAdminInterface()
		{
			return null;
		}

		public RTCInterface GetRTCInterface()
		{
			return null;
		}

		public ReceiptValidatorInterface GetReceiptValidatorInterface()
		{
			return null;
		}

		public ReportsInterface GetReportsInterface()
		{
			return null;
		}

		public SanctionsInterface GetSanctionsInterface()
		{
			return null;
		}

		public SessionsInterface GetSessionsInterface()
		{
			return null;
		}

		public StatsInterface GetStatsInterface()
		{
			return null;
		}

		public TitleStorageInterface GetTitleStorageInterface()
		{
			return null;
		}

		public UIInterface GetUIInterface()
		{
			return null;
		}

		public UserInfoInterface GetUserInfoInterface()
		{
			return null;
		}

		public static Result Initialize(ref InitializeOptions options)
		{
			return default(Result);
		}

		public void Release()
		{
		}

		public Result SetApplicationStatus(ApplicationStatus newStatus)
		{
			return default(Result);
		}

		public Result SetNetworkStatus(NetworkStatus newStatus)
		{
			return default(Result);
		}

		public Result SetOverrideCountryCode(Utf8String newCountryCode)
		{
			return default(Result);
		}

		public Result SetOverrideLocaleCode(Utf8String newLocaleCode)
		{
			return default(Result);
		}

		public static Result Shutdown()
		{
			return default(Result);
		}

		public void Tick()
		{
		}

		public static Utf8String ToString(ApplicationStatus applicationStatus)
		{
			return null;
		}

		public static Utf8String ToString(NetworkStatus networkStatus)
		{
			return null;
		}

		public static Result Initialize(ref PS4InitializeOptions options)
		{
			return default(Result);
		}

		public Result ManagedByApplicationNotificationMessages(IntPtr inEvent)
		{
			return default(Result);
		}

		public static Result Initialize(ref PS5InitializeOptions options)
		{
			return default(Result);
		}

		public static PlatformInterface Create(ref WindowsOptions options)
		{
			return null;
		}

		public static PlatformInterface Create(ref XboxOneGDKOptions options)
		{
			return null;
		}

		public static Result Initialize(ref XboxOneGDKInitializeOptions options)
		{
			return default(Result);
		}

		public static PlatformInterface Create(ref XSXOptions options)
		{
			return null;
		}

		public static Result Initialize(ref XSXInitializeOptions options)
		{
			return default(Result);
		}
	}
}
