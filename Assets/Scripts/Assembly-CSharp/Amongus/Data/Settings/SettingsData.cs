using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class SettingsData : AbstractUserSaveData
	{
		[JsonProperty("gameplay")]
		private GameplaySettingsData gameplay;

		[JsonProperty("accessibility")]
		private AccessibilitySettingsData accessibility;

		[JsonProperty("audio")]
		private AudioSettingsData audio;

		[JsonProperty("video")]
		private VideoSettingsData video;

		[JsonProperty("language")]
		private LanguageSettingsData language;

		[JsonProperty("input")]
		private InputSettingsData input;

		[JsonProperty("multiplayer")]
		private MultiplayerSettingsData multiplayer;

		protected override int CurrentVersion => 0;

		public GameplaySettingsData Gameplay => null;

		public AccessibilitySettingsData Accessibility => null;

		public AudioSettingsData Audio => null;

		public VideoSettingsData Video => null;

		public InputSettingsData Input => null;

		public LanguageSettingsData Language => null;

		public MultiplayerSettingsData Multiplayer => null;

		protected override string FileName => null;

		protected override AbstractSaveDataGroup[] Groups => null;

		protected override void HandleVersionMigration(int version)
		{
		}
	}
}
