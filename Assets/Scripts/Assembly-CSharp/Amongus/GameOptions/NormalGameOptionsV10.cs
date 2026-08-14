using Hazel;

namespace AmongUs.GameOptions
{
	public class NormalGameOptionsV10 : IGameOptions
	{
		private static readonly int[] RecommendedKillCooldown;

		private static readonly int[] RecommendedImpostors;

		private static readonly int[] MaxImpostors;

		private static readonly float[] KillDistances;

		private static readonly string[] KillDistanceStrings;

		private static readonly int[] MinPlayers;

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

		public int Tag;

		private readonly ILogger logger;

		private RoleOptionsCollectionV10 roleOptions;

		public byte Version => 0;

		public GameModes GameMode { get; private set; }

		public SpecialGameModes SpecialMode { get; set; }

		public GameModes AprilFoolsOnMode => default(GameModes);

		public GameModes AprilFoolsOffMode => default(GameModes);

		public RulesPresets RulesPreset { get; set; }

		public int MaxPlayers { get; set; }

		public GameKeywords Keywords { get; set; }

		public byte MapId { get; set; }

		public bool IsDefaults { get; set; }

		public IRoleOptionsCollection RoleOptions => null;

		public int NumImpostors { get; set; }

		public int TotalTaskCount => NumCommonTasks + NumLongTasks + NumShortTasks;

		public NormalGameOptionsV10(ILogger logger)
		{
			this.logger = logger;
			GameMode = GameModes.Normal;
			SetRecommendations(10, isOnline: false);
		}

		public static void Serialize(MessageWriter writer, NormalGameOptionsV10 gameOptions)
		{
		}

		public static NormalGameOptionsV10 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger)
		{
			return null;
		}

		public bool AreInvalid(int maxExpectedPlayers)
		{
			return false;
		}

		public void SetRecommendations(int numPlayers, bool isOnline)
		{
			SetRecommendations(numPlayers, isOnline, RulesPresets.Standard);
		}

		public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets)
		{
			RulesPreset = rulesPresets;
			MaxPlayers = UnityEngine.Mathf.Clamp(numPlayers > 0 ? numPlayers : 10, 4, 15);
			MapId = 0;
			NumImpostors = UnityEngine.Mathf.Clamp(MaxPlayers >= 9 ? 2 : 1, 1, 3);
			PlayerSpeedMod = 1f;
			CrewLightMod = 1f;
			ImpostorLightMod = 1.5f;
			KillCooldown = 45f;
			KillDistance = 1;
			NumCommonTasks = 1;
			NumLongTasks = 1;
			NumShortTasks = 2;
			NumEmergencyMeetings = 1;
			EmergencyCooldown = 15;
			DiscussionTime = 15;
			VotingTime = 120;
			ConfirmImpostor = true;
			VisualTasks = true;
			AnonymousVotes = false;
			GhostsDoTasks = true;
			TaskBarMode = AmongUs.GameOptions.TaskBarMode.Normal;
			IsDefaults = true;
		}

		public void SetByte(ByteOptionNames optionName, byte value)
		{
			if (optionName == ByteOptionNames.MapId)
			{
				MapId = value;
			}
		}

		public void SetFloat(FloatOptionNames optionName, float value)
		{
			switch (optionName)
			{
			case FloatOptionNames.KillCooldown:
				KillCooldown = value;
				break;
			case FloatOptionNames.PlayerSpeedMod:
				PlayerSpeedMod = value;
				break;
			case FloatOptionNames.ImpostorLightMod:
				ImpostorLightMod = value;
				break;
			case FloatOptionNames.CrewLightMod:
				CrewLightMod = value;
				break;
			}
			IsDefaults = false;
		}

		public void SetBool(BoolOptionNames optionName, bool value)
		{
			switch (optionName)
			{
			case BoolOptionNames.VisualTasks:
				VisualTasks = value;
				break;
			case BoolOptionNames.GhostsDoTasks:
				GhostsDoTasks = value;
				break;
			case BoolOptionNames.ConfirmImpostor:
				ConfirmImpostor = value;
				break;
			case BoolOptionNames.AnonymousVotes:
				AnonymousVotes = value;
				break;
			case BoolOptionNames.IsDefaults:
				IsDefaults = value;
				break;
			}
		}

		public void SetInt(Int32OptionNames optionName, int value)
		{
			switch (optionName)
			{
			case Int32OptionNames.NumImpostors:
				NumImpostors = UnityEngine.Mathf.Clamp(value, 1, 3);
				break;
			case Int32OptionNames.KillDistance:
				KillDistance = UnityEngine.Mathf.Clamp(value, 0, 2);
				break;
			case Int32OptionNames.NumEmergencyMeetings:
				NumEmergencyMeetings = value;
				break;
			case Int32OptionNames.EmergencyCooldown:
				EmergencyCooldown = value;
				break;
			case Int32OptionNames.DiscussionTime:
				DiscussionTime = value;
				break;
			case Int32OptionNames.VotingTime:
				VotingTime = value;
				break;
			case Int32OptionNames.MaxPlayers:
				MaxPlayers = UnityEngine.Mathf.Clamp(value, 4, 15);
				break;
			case Int32OptionNames.NumCommonTasks:
				NumCommonTasks = value;
				break;
			case Int32OptionNames.NumShortTasks:
				NumShortTasks = value;
				break;
			case Int32OptionNames.NumLongTasks:
				NumLongTasks = value;
				break;
			case Int32OptionNames.TaskBarMode:
				TaskBarMode = (TaskBarMode)value;
				break;
			case Int32OptionNames.Tag:
				Tag = value;
				break;
			case Int32OptionNames.RulePreset:
				RulesPreset = (RulesPresets)value;
				break;
			}
			IsDefaults = false;
		}

		public void SetUInt(UInt32OptionNames optionName, uint value)
		{
		}

		public byte GetByte(ByteOptionNames optionName)
		{
			return optionName == ByteOptionNames.MapId ? MapId : (byte)0;
		}

		public float GetFloat(FloatOptionNames optionName)
		{
			switch (optionName)
			{
			case FloatOptionNames.KillCooldown:
				return KillCooldown;
			case FloatOptionNames.PlayerSpeedMod:
				return PlayerSpeedMod;
			case FloatOptionNames.ImpostorLightMod:
				return ImpostorLightMod;
			case FloatOptionNames.CrewLightMod:
				return CrewLightMod;
			default:
				return 0f;
			}
		}

		public bool GetBool(BoolOptionNames optionName)
		{
			switch (optionName)
			{
			case BoolOptionNames.VisualTasks:
				return VisualTasks;
			case BoolOptionNames.GhostsDoTasks:
				return GhostsDoTasks;
			case BoolOptionNames.ConfirmImpostor:
				return ConfirmImpostor;
			case BoolOptionNames.AnonymousVotes:
				return AnonymousVotes;
			case BoolOptionNames.IsDefaults:
				return IsDefaults;
			default:
				return false;
			}
		}

		public int GetInt(Int32OptionNames optionName)
		{
			switch (optionName)
			{
			case Int32OptionNames.NumImpostors:
				return NumImpostors;
			case Int32OptionNames.KillDistance:
				return KillDistance;
			case Int32OptionNames.NumEmergencyMeetings:
				return NumEmergencyMeetings;
			case Int32OptionNames.EmergencyCooldown:
				return EmergencyCooldown;
			case Int32OptionNames.DiscussionTime:
				return DiscussionTime;
			case Int32OptionNames.VotingTime:
				return VotingTime;
			case Int32OptionNames.MaxPlayers:
				return MaxPlayers;
			case Int32OptionNames.NumCommonTasks:
				return NumCommonTasks;
			case Int32OptionNames.NumShortTasks:
				return NumShortTasks;
			case Int32OptionNames.NumLongTasks:
				return NumLongTasks;
			case Int32OptionNames.TaskBarMode:
				return (int)TaskBarMode;
			case Int32OptionNames.Tag:
				return Tag;
			case Int32OptionNames.RulePreset:
				return (int)RulesPreset;
			default:
				return 0;
			}
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
			value = GetByte(optionName);
			return optionName != ByteOptionNames.Invalid;
		}

		public bool TryGetFloat(FloatOptionNames optionName, out float value)
		{
			value = GetFloat(optionName);
			return optionName == FloatOptionNames.KillCooldown || optionName == FloatOptionNames.PlayerSpeedMod || optionName == FloatOptionNames.ImpostorLightMod || optionName == FloatOptionNames.CrewLightMod;
		}

		public bool TryGetBool(BoolOptionNames optionName, out bool value)
		{
			value = GetBool(optionName);
			return optionName != BoolOptionNames.Invalid;
		}

		public bool TryGetInt(Int32OptionNames optionName, out int value)
		{
			value = GetInt(optionName);
			return optionName != Int32OptionNames.Invalid;
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
