using Hazel;

namespace AmongUs.GameOptions
{
	public class GameOptionsMigratorV07toV08 : IGameOptionsMigrator
	{
		private readonly ILogger logger;

		public GameOptionsMigratorV07toV08(ILogger logger)
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
	}
}
