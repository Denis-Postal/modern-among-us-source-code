using System.Collections.Generic;
using Hazel;

namespace AmongUs.GameOptions
{
	public class GameOptionsFactory
	{
		public const byte FIRST_MODULAR_OPTIONS_DATA_VERSION = 7;

		public static readonly int LatestVersion;

		private static readonly Dictionary<int, GameOptionsDefinition> cachedVersionDefinitions;

		private readonly ILogger logger;

		private readonly Dictionary<byte, IGameOptionsMigrator> migrators;

		static GameOptionsFactory()
		{
		}

		public GameOptionsFactory(ILogger logger)
		{
		}

		public byte[] ToBytes(IGameOptions data, bool forceAprilFoolsMode)
		{
			return null;
		}

		public void ToNetworkMessageWithSize(MessageWriter writer, IGameOptions data)
		{
		}

		public IGameOptions FromBytes(byte[] rawBytes)
		{
			return null;
		}

		public IGameOptions FromNetworkMessageWithSize(MessageReader reader)
		{
			return null;
		}

		public bool TryGetMigrator(byte version, out IGameOptionsMigrator migrator)
		{
			migrator = null;
			return false;
		}

		private IGameOptions DeserializeByVersion(MessageReader reader, byte version)
		{
			return null;
		}

		private IGameOptions DeserializeModularByVersion(MessageReader reader, byte version)
		{
			return null;
		}
	}
}
