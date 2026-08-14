using AmongUs.GameOptions;

public static class StatIDUtilities
{
	private const string EOS_STAT_PREFIX = "PlayerStat_";

	public static bool TryGetStatID(out StatID stat, params object[] search)
	{
		stat = default(StatID);
		return false;
	}

	public static StatID GetStatID(params object[] search)
	{
		return default(StatID);
	}

	public static StatID GetMapStatID(MapNames map, MapStat stat)
	{
		return default(StatID);
	}

	public static StatID GetRoleStatID(RoleTypes role, RoleStat stat)
	{
		return default(StatID);
	}

	public static StatID GetRoleStatID(RoleTypes role, string stat)
	{
		return default(StatID);
	}

	public static StatID GetGameResultStatID(GameOverReason reason, GameResultStat stat)
	{
		return default(StatID);
	}

	public static string GetStatNameForEOS(StatID stat)
	{
		return null;
	}

	public static StatID GetStatIDFromEOSStatName(string name)
	{
		return default(StatID);
	}
}
