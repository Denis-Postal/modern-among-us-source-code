using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerData : AbstractUserSaveData
	{
		private static readonly byte[] DEFAULT_ENCRYPTED;

		[JsonProperty("account")]
		private PlayerAccountData account;

		[JsonProperty("customization")]
		private PlayerCustomizationData customization;

		[JsonProperty("onboarding")]
		private PlayerOnboardingData onboarding;

		[JsonProperty("age")]
		private byte[] encryptedAge;

		private PlayerAgeData age;

		[JsonProperty("store")]
		private byte[] encryptedStore;

		private PlayerStoreData store;

		[JsonProperty("ads")]
		private byte[] encryptedAds;

		private PlayerAdsData ads;

		[JsonProperty("ban")]
		private byte[] encryptedBan;

		private PlayerBanData ban;

		[JsonProperty("announcements")]
		private PlayerAnnouncementData announcements;

		[JsonProperty("friends")]
		private PlayerFriendData friends;

		private PlayerPurchasesData purchases;

		private PlayerStatsData stats;

		protected override int CurrentVersion => 0;

		public PlayerAccountData Account => null;

		public PlayerCustomizationData Customization => null;

		public PlayerStatsData Stats => null;

		public PlayerOnboardingData Onboarding => null;

		public PlayerAgeData Age => null;

		public PlayerStoreData Store => null;

		public PlayerAdsData Ads => null;

		public PlayerBanData Ban => null;

		public PlayerPurchasesData Purchases => null;

		public PlayerAnnouncementData Announcements => null;

		public PlayerFriendData Friends => null;

		protected override string FileName => null;

		protected override AbstractSaveDataGroup[] Groups => null;

		protected override void OnSaveStart()
		{
		}

		protected override void OnLoadComplete()
		{
		}

		protected override void HandleVersionMigration(int version)
		{
		}
	}
}
