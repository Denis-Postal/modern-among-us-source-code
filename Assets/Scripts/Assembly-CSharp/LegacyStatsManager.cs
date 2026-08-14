using System;
using System.Collections.Generic;
using System.IO;
using AmongUs.GameOptions;

public class LegacyStatsManager
{
	public class LegacyStats
	{
		public byte version;

		public float FastestCrewmateWin_HideAndSeek;

		public float FastestImpostorWin_HideAndSeek;

		public readonly Dictionary<StringNames, uint> gameplayStats;

		public readonly Dictionary<GameOverReason, uint> winReasons;

		public readonly Dictionary<GameOverReason, uint> loseReasons;

		public readonly Dictionary<GameOverReason, uint> drawReasons;

		public readonly Dictionary<MapNames, uint> mapWins;

		public readonly Dictionary<RoleTypes, uint> roleWins;

		private static readonly List<StringNames> SimpleStats;

		public void MigrateFromPlayerStats2ToPlayerStats3(BinaryReader reader)
		{
		}

		public void Reset()
		{
		}

		public void Deserialize(BinaryReader reader)
		{
		}

		private void ReadEnumDict<T>(Dictionary<T, uint> enumDict, BinaryReader reader) where T : Enum
		{
		}

		private void TryReadFloat(ref float value, BinaryReader reader)
		{
		}
	}

	public static LegacyStatsManager Instance;

	public const string LEGACY_STATS_FILENAME = "playerStats3";

	public const string LEGACY_PREVIOUS_STATS_FILENAME = "playerStats2";

	private const byte FINAL_LEGACY_STATS_MANAGER_VERISON = 6;

	private const byte StatsVersion = 6;

	private static string playerStats2Path;

	private static string playerStats3Path;

	protected LegacyStats stats;

	private bool loadedStats;

	private LegacyStats TheStats => null;

	public void ForceLoadStats()
	{
	}

	public static bool Exists()
	{
		return false;
	}

	protected virtual void LoadStats()
	{
	}

	private void ResetStatDisplay()
	{
	}

	public void MigrateToPlayerStatsData(Dictionary<StatID, uint> statsToIngest)
	{
	}
}
