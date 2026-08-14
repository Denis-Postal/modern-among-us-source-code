using Hazel;

namespace AmongUs.GameOptions
{
	public class GameOptionsDefinitionV07 : GameOptionsDefinition
	{
		public override byte Version => 0;

		public override IGameOptionsMigrator GetMigrator(ILogger logger)
		{
			return null;
		}

		public override void NormalModeSerialize(MessageWriter writer, IGameOptions optionsData)
		{
		}

		public override IGameOptions NormalModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger)
		{
			return null;
		}

		public override void HideAndSeekModeSerialize(MessageWriter writer, IGameOptions optionsData)
		{
		}

		public override IGameOptions HideAndSeekModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger)
		{
			return null;
		}
	}
}
