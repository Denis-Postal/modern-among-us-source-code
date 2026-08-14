using System;
using System.Globalization;
using System.Threading;

public static class Constants
{
	public static class BuildSymbols
	{
		public const string Steam = "STEAMWORKS";

		public const string DisableSteam = "DISABLESTEAMWORKS";

		public const string EGS = "EPICGAMESSTORE";

		public const string DisableEGS = "DISABLEEPIC";

		public const string XboxOneEGS = "EOS_PLATFORM_XBOXONEGDK";

		public const string SeriesXEGS = "EOS_PLATFORM_XSX";

		public const string Itchio = "ITCHIO";

		public const string Win10 = "MICROSOFT_GAME_CORE";

		public const string Console = "CONSOLE";

		public const string Controller = "CONTROLLER";

		public const string ItchioAndroid = "ITCHIO_ANDROID";

		public const string Staging = "STAGING";

		public const string QABuild = "QA_BUILD";

		public const string IsMinorDebug = "IS_MINOR_DEBUG";

		public const string DebugTool = "DEBUG_TOOL";

		public const string Debug = "DEBUG";

		public const string ExternalPlaytest = "EXTERNAL_PLAYTEST";

		public const string DisableObfuscator = "BEEBYTE_OBFUSCATOR_DISABLE";
	}

	public static class CDNPlatforms
	{
		public const string Steam = "Steam";

		public const string EGS = "EGS";

		public const string Itch = "Itch";

		public const string Win10 = "Win10";

		public const string ItchAndroid = "ItchAndroid";

		public const string GPAndroid = "GPAndroid";

		public const string iOS = "iOS";

		public const string PS4 = "PS4";

		public const string PS5 = "PS5";

		public const string Switch = "Switch";

		public const string XB1 = "XB1";

		public const string XSX = "XSX";
	}

	public const float ButtonLongClickTime = 0.5f;

	public const int AnimationFrameRate = 24;

	public const int MinNumPlayers = 4;

	public const int MaxNumPlayers = 15;

	public const string LocalNetAddress = "127.0.0.1";

	public const ushort GamePlayPort = 22023;

	public const ushort AnnouncementPort = 22024;

	public const string InfinitySymbol = "∞";

	public const string DummyNamePrefix = "Dummy";

	public static readonly int ShipOnlyMask;

	public static readonly int ShipAndObjectsMask;

	public static readonly int ShipAndAllObjectsMask;

	public static readonly int NotShipMask;

	public static readonly int Usables;

	public static readonly int PlayersOnlyMask;

	public static readonly int LivingPlayersOnlyMask;

	public static readonly int ShadowMask;

	public static readonly string[] MapNames;

	public static readonly string Beans;

	public static readonly string[] PlayStationControllers;

	public static readonly string PrivacyPolicyURL;

	public static readonly string TermsOfUseURL;

	public static readonly string ParentPortalURL;

	public static readonly string UserIdTokenError;

	public static string CCDBucketAccessToken;

	public static CultureInfo CultureInfo;

	public static readonly int[] CompatVersions;

	public const int Year = 2026;

	public const int Month = 2;

	public const int Day = 2;

	public const int Revision = 0;

	public const int VisualRevision = 0;

	public const string AddressablesVersion = "2026_2_25_1109";

	public const string extraBuildVersionInfo = "(build num: 6768)";

	public const int pipelineBuildNumber = 6768;

	public const BuildEnvironment environment = BuildEnvironment.Production;

	public const byte EmptyPlayerID = byte.MaxValue;

	private static Thread _MainThread;

	public const string DefaultSpriteShader = "Sprites/Default";

	public const string PlayerColorShaderName = "PlayerShader";

	public const string PlayerColorShaderPath = "Unlit/PlayerShader";

	public const int LADDER_COOLDOWN = 5;

	public const int ZIPLINE_COOLDOWN = 7;

	public const int INITIAL_SABOTAGE_COOLDOWN = 10;

	public const int LOW_END_MEMORY_SIZE = 2500;

	private static int MODDER_VERSION;

	private const int MODDED_REVISION_MODIFIER_VALUE = 25;

	public const string SECUREFILE_FILENAME = "secureNew";

	public const string PLAYER_FILENAME = "player.amogus";

	public const string SETTINGS_FILENAME = "settings.amogus";

	public const string MAIN_MENU_SCENE = "MainMenu";

	public const string MATCHMAKING_SCENE = "MatchMaking";

	public const string ONLINE_SCENE = "OnlineGame";

	public const string FIND_GAME_SCENE = "FindAGame";

	public const string TUTORIAL = "Tutorial";

	public const int MAX_ADS_PER_DAY = 1;

	public const int MINUTES_BETWEEN_ADS = 60;

	private static string cachedPlatformName;

	public static Thread MainThread => null;

	public static void SetMainThread()
	{
	}

	internal static int GetBroadcastVersion()
	{
		return 0;
	}

	internal static bool IsVersionModded()
	{
		return false;
	}

	internal static int GetVersion(int year, int month, int day, int rev)
	{
		return 0;
	}

	internal static (int, int, int, int) GetVersionComponents(int broadcastVersion)
	{
		return default((int, int, int, int));
	}

	internal static byte[] GetBroadcastVersionBytes()
	{
		return null;
	}

	public static bool ShouldPlaySfx()
	{
		return false;
	}

	public static PlatformSpecificData GetPlatformData()
	{
		return null;
	}

	public static void UpdateCachedPlatformName()
	{
	}

	public static string GetPlatformName()
	{
		return null;
	}

	public static string GetPurchasingPlatformType()
	{
		return null;
	}

	public static Platforms GetPlatformType()
	{
		return default(Platforms);
	}

	public static string GetCurrentPlatformName()
	{
		return null;
	}

	public static void OpenURL(string url)
	{
	}

	public static DateTime ParseDate(string date)
	{
		return default(DateTime);
	}
}
