using Hazel;

namespace AmongUs.GameOptions
{
	public class GameOptionsMigratorV08toV09 : IGameOptionsMigrator
	{
		private readonly ILogger logger;

		public GameOptionsMigratorV08toV09(ILogger logger)
		{
		}

		public bool TryMigrate(IGameOptions previousVersion, out IGameOptions updatedVersion)
		{
			updatedVersion = null;
			return false;
		}

		private bool TryMigrateNormal(IGameOptions previousVersion, out IGameOptions updatedVersion)
		{
			updatedVersion = null;
			return false;
		}

		private bool TryMigrateHideAndSeek(IGameOptions previousVersion, out IGameOptions updatedVersion)
		{
			updatedVersion = null;
			return false;
		}

		private void CopyFloat(IGameOptions newVersion, IGameOptions oldVersion, FloatOptionNames option)
		{
		}

		private void CopyBool(IGameOptions newVersion, IGameOptions oldVersion, BoolOptionNames option)
		{
		}

		private void CopyInt32(IGameOptions newVersion, IGameOptions oldVersion, Int32OptionNames option)
		{
		}
	}
}
