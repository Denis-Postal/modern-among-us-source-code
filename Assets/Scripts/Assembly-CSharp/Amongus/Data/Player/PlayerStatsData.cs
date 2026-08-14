using System.Collections.Generic;
using AmongUs.GameOptions;

namespace AmongUs.Data.Player
{
	public class PlayerStatsData
	{
		public static readonly Logger Logger;

		private uint level;

		private uint xp;

		private uint xpForNextLevel;

		private Dictionary<StatID, uint> statsCache;

		private Dictionary<StatID, uint> statsToIngest;

		private bool isTrackingStats;

		public bool IsTrackingStats => false;

		public uint Level
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint Xp
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint XpForNextLevel
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public void InitializeStats()
		{
		}

		public void SetStatTrackingEnabled(bool enabled)
		{
		}

		private bool ValidateStat(StatID stat)
		{
			return false;
		}

		public void IncrementStat(StatID stat)
		{
		}

		public void ResetStat(StatID stat)
		{
		}

		public uint GetStat(StatID stat)
		{
			return 0u;
		}

		public void SetStatAsMinTime(StatID stat, float timeInSeconds)
		{
		}

		public float GetStatAsMinTime(StatID stat)
		{
			return 0f;
		}

		public string GetStatAsMinTimeString(StatID stat)
		{
			return null;
		}

		public uint GetMapStat(MapNames map, MapStat stat)
		{
			return 0u;
		}

		public void IncrementMapStat(MapNames map, MapStat stat)
		{
		}

		private static RoleTypes ValidateRole(RoleTypes role)
		{
			return default(RoleTypes);
		}

		public uint GetRoleStat(RoleTypes role, RoleStat stat)
		{
			return 0u;
		}

		public void IncrementRoleStat(RoleTypes role, RoleStat stat)
		{
		}

		public uint GetGameResultStat(GameOverReason reason, GameResultStat stat)
		{
			return 0u;
		}

		public void IncrementGameResultStat(GameOverReason reason, GameResultStat stat)
		{
		}

		public void IncrementWinStats(GameOverReason reason, MapNames map, RoleTypes role)
		{
		}

		public void SaveStats()
		{
		}

		private void CacheStats(StatID[] stats)
		{
		}
	}
}
