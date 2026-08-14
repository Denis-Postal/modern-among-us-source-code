using System.IO;
using Hazel;

namespace AmongUs.GameOptions
{
	public class LegacyGameOptions : IGameOptions
	{
		private static readonly int[] RecommendedKillCooldown;

		private static readonly int[] RecommendedImpostors;

		private static readonly int[] MaxImpostors;

		private static readonly float[] KillDistances;

		private static readonly string[] KillDistanceStrings;

		private static readonly int[] MinPlayers;

		private const byte EmergencyCooldownSupportVersion = 1;

		private const byte VisualTaskOptionsSupportVersion = 2;

		private const byte ExtraVotingOptionsSupportVersion = 3;

		private const byte RolesSupportVersion = 4;

		public const byte ServerVersion = 2;

		public const byte NewestVersion = 5;

		public float PlayerSpeedMod;

		public float CrewLightMod;

		public float ImpostorLightMod;

		public float KillCooldown;

		public int NumCommonTasks;

		public int NumLongTasks;

		public int NumShortTasks;

		public int NumEmergencyMeetings;

		public int EmergencyCooldown;

		public bool GhostsDoTasks;

		public int KillDistance;

		public int DiscussionTime;

		public int VotingTime;

		public bool ConfirmImpostor;

		public bool VisualTasks;

		public bool AnonymousVotes;

		public TaskBarMode TaskBarMode;

		private readonly ILogger logger;

		private LegacyRoleOptionsCollection roleOptions;

		public byte Version { get; private set; }

		public GameModes GameMode { get; private set; }

		public SpecialGameModes SpecialMode => default(SpecialGameModes);

		public GameModes AprilFoolsOnMode => default(GameModes);

		public GameModes AprilFoolsOffMode => default(GameModes);

		public RulesPresets RulesPreset { get; set; }

		public int MaxPlayers { get; private set; }

		public GameKeywords Keywords { get; private set; }

		public byte MapId { get; private set; }

		public IRoleOptionsCollection RoleOptions => null;

		public int NumImpostors { get; private set; }

		public bool IsDefaults { get; private set; }

		public int TotalTaskCount => 0;

		public LegacyGameOptions(ILogger logger)
		{
		}

		public static void Serialize(BinaryWriter writer, LegacyGameOptions gameOptionsData)
		{
		}

		public static LegacyGameOptions Deserialize(BinaryReader reader, byte version, ILogger logger)
		{
			return null;
		}

		public bool AreInvalid(int maxExpectedPlayers)
		{
			return false;
		}

		public void SetRecommendations(int numPlayers, bool isOnline)
		{
		}

		public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets)
		{
		}

		public bool Validate(int numPlayers)
		{
			return false;
		}

		public void SetByte(ByteOptionNames optionName, byte value)
		{
		}

		public void SetFloat(FloatOptionNames optionName, float value)
		{
		}

		public void SetBool(BoolOptionNames optionName, bool value)
		{
		}

		public void SetInt(Int32OptionNames optionName, int value)
		{
		}

		public void SetUInt(UInt32OptionNames optionName, uint value)
		{
		}

		public byte GetByte(ByteOptionNames optionName)
		{
			return 0;
		}

		public float GetFloat(FloatOptionNames optionName)
		{
			return 0f;
		}

		public bool GetBool(BoolOptionNames optionName)
		{
			return false;
		}

		public int GetInt(Int32OptionNames optionName)
		{
			return 0;
		}

		public int[] GetIntArray(Int32ArrayOptionNames optionName)
		{
			return null;
		}

		public float[] GetFloatArray(FloatArrayOptionNames optionName)
		{
			return null;
		}

		public bool TryGetByte(ByteOptionNames optionName, out byte value)
		{
			value = default(byte);
			return false;
		}

		public bool TryGetFloat(FloatOptionNames optionName, out float value)
		{
			value = default(float);
			return false;
		}

		public bool TryGetBool(BoolOptionNames optionName, out bool value)
		{
			value = default(bool);
			return false;
		}

		public bool TryGetInt(Int32OptionNames optionName, out int value)
		{
			value = default(int);
			return false;
		}

		public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value)
		{
			value = null;
			return false;
		}

		public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value)
		{
			value = null;
			return false;
		}

		public bool TryClearAprilFoolsMode()
		{
			return false;
		}
	}
}
