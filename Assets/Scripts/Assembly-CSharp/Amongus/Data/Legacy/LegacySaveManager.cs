using System;
using System.Collections.Generic;
using Assets.InnerNet;
using InnerNet;

namespace AmongUs.Data.Legacy
{
	public static class LegacySaveManager
	{
		private const int schemaVersion = 1;

		private static int lastSchemaVersion;

		private static bool loaded;

		private static bool loadedStats;

		private static bool loadedAnnounce;

		private static bool loadedQCFavorites;

		private static bool loadedStoreTabViewDates;

		private static bool loadedCachedPurchases;

		private static int accountLoginStatus;

		private static string guardianEmail;

		private static bool deleteDeviceIDFailed;

		private static bool hasLoggedIn;

		private static bool isGuest;

		private static string epicAccountId;

		private static string lastPlayerName;

		private static uint colorConfig;

		private static string lastPet;

		private static string lastHat;

		private static string lastSkin;

		private static string lastVisor;

		private static string lastNamePlate;

		private static uint playerLevel;

		private static uint playerXp;

		private static uint playerXpRequiredForNextLevel;

		private static int privacyPolicyVersion;

		private static Announcement lastAnnounce;

		private static bool showOnlineHelp;

		private static bool askRedeemDLC;

		private static bool warnedAboutGuestModeProgression;

		private static bool showMinPlayerWarning;

		private static string dobInfo;

		private static string birthDateSetDate;

		private static int birthDateDay;

		private static int birthDateMonth;

		private static int birthDateYear;

		private static string lastCosmicube;

		private static string storeBundlesViewDate;

		private static string storeHatsViewDate;

		private static string storeOutfitsViewDate;

		private static string storeVisorsViewDate;

		private static string storePetsViewDate;

		private static string storeNameplatesViewDate;

		private static string storeCosmicubeViewDate;

		private static byte showAdsScreen;

		private static bool screenshake;

		private static bool streamerMode;

		private static bool colorblindMode;

		private static byte sfxVolume;

		private static byte musicVolume;

		private static bool vsync;

		private static uint lastLanguage;

		private static ControlTypes touchConfig;

		private static bool enableMouseMovement;

		private static float joyStickSize;

		private static bool crossplayAllPlatforms;

		private static bool enableFriendsListInvites;

		private static bool censorChat;

		private static int chatModeType;

		private static string[] quickChatFavorites;

		private static LegacySecureDataFile purchaseFile;

		private static HashSet<string> purchases;

		public static EOSManager.AccountLoginStatus AccountLoginStatus => default(EOSManager.AccountLoginStatus);

		public static bool DeleteDeviceIDFailed => false;

		public static string GuardianEmail => null;

		public static string PlayerName => null;

		public static byte BodyColor => 0;

		public static string LastPet => null;

		public static string LastHat => null;

		public static string LastSkin => null;

		public static string LastVisor => null;

		public static string LastNamePlate => null;

		public static uint PlayerLevel => 0u;

		public static uint PlayerXp => 0u;

		public static uint XpRequiredForNextLevel => 0u;

		public static int AcceptedPrivacyPolicy => 0;

		public static bool ShowOnlineHelp => false;

		public static bool ShowMinPlayerWarning => false;

		public static Announcement LastAnnouncement => default(Announcement);

		public static string LastCosmicube => null;

		public static string BirthDateSetDate => null;

		public static bool BoughtNoAds => false;

		public static ShowAdsState ShowAdsScreen => default(ShowAdsState);

		public static bool Screenshake => false;

		public static bool StreamerMode => false;

		public static bool ColorBlindMode => false;

		public static float MusicVolume => 0f;

		public static float SfxVolume => 0f;

		public static bool VSync => false;

		public static uint LastLanguage => 0u;

		public static ControlTypes ControlMode => default(ControlTypes);

		public static bool EnableMouseMovement => false;

		public static float JoystickSize => 0f;

		public static bool CrossplayAllPlatforms => false;

		public static bool EnableFriendsListInvites => false;

		public static bool CensorChat => false;

		public static QuickChatModes ChatModeType => default(QuickChatModes);

		public static string[] QuickChatFavorites => null;

		public static bool PlayerPrefsExists()
		{
			return false;
		}

		public static void LoadPlayerPrefs(bool overrideLoad = false)
		{
		}

		public static void DeleteAll()
		{
		}

		private static string GetPrefsName()
		{
			return null;
		}

		private static void TryGetBool(string[] parts, int index, out bool value, bool @default = false)
		{
			value = default(bool);
		}

		private static void TryGetByte(string[] parts, int index, out byte value)
		{
			value = default(byte);
		}

		private static void TryGetFloat(string[] parts, int index, out float value, float @default = 0f)
		{
			value = default(float);
		}

		private static void TryGetDateTime(string[] parts, int index, out DateTime value)
		{
			value = default(DateTime);
		}

		private static void TryGetInt(string[] parts, int index, out int value)
		{
			value = default(int);
		}

		private static void TryGetUint(string[] parts, int index, out uint value, uint @default = 0u)
		{
			value = default(uint);
		}

		private static void TryGetUlong(string[] parts, int index, out ulong value, ulong @default = 0uL)
		{
			value = default(ulong);
		}

		private static void TryGetString(string[] parts, int index, out string value, string @default = "")
		{
			value = null;
		}

		public static void LoadQuickChatFavorites()
		{
		}

		public static bool GetPurchase(string itemKey, string bundleKey)
		{
			return false;
		}

		public static int[] LoadLocalDoB()
		{
			return null;
		}

		private static void LoadSecureData()
		{
		}

		private static void LoadAnnouncement()
		{
		}

		public static bool StoreTabViewDatesFileExists()
		{
			return false;
		}

		public static void LoadStoreTabViewDates()
		{
		}

		public static bool TryGetStoreTabViewDate(StoreTab tab, out string output)
		{
			output = null;
			return false;
		}

		private static bool RunMigrations()
		{
			return false;
		}
	}
}
