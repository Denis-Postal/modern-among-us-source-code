using AmongUs.Data.Player;
using AmongUs.Data.Settings;

namespace AmongUs.Data
{
	public static class DataManager
	{
		private static PlayerData player;

		private static SettingsData settings;

		private static readonly Logger logger;

		public static bool IsPlayerLoaded => false;

		public static bool IsSettingsLoaded => false;

		public static PlayerData Player => null;

		public static SettingsData Settings => null;

		public static Logger Logger => null;

		public static void DeleteAll()
		{
		}
	}
}
