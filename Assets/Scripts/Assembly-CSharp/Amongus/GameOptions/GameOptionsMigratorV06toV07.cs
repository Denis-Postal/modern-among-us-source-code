using Hazel;

namespace AmongUs.GameOptions
{
	public class GameOptionsMigratorV06toV07 : IGameOptionsMigrator
	{
		private readonly ILogger logger;

		public GameOptionsMigratorV06toV07(ILogger logger)
		{
		}

		public bool TryMigrate(IGameOptions previousVersion, out IGameOptions updatedVersion)
		{
			updatedVersion = null;
			return false;
		}
	}
}
