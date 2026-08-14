using System.Text;
using AmongUs.GameOptions;

public static class IGameOptionsExtensions
{
	private const byte SkeldBit = 1;

	private const byte MiraBit = 2;

	private const byte PolusBit = 4;

	private const byte AirshipBit = 16;

	private const byte FungleBit = 32;

	private const byte MapMask = 55;

	private static StringBuilder SettingsStringBuilder;

	public static void SetRecommendations(this IGameOptions gameOptions, int numPlayers, NetworkModes modes)
	{
		gameOptions?.SetRecommendations(numPlayers, modes == NetworkModes.OnlineGame);
	}

	public static void SetRecommendations(this IGameOptions gameOptions, int numPlayers, NetworkModes modes, RulesPresets rulesPresets)
	{
		gameOptions?.SetRecommendations(numPlayers, modes == NetworkModes.OnlineGame, rulesPresets);
	}

	public static int GetAdjustedNumImpostors(this IGameOptions gameOptions, int playerCount)
	{
		if (gameOptions == null)
		{
			return 1;
		}
		return System.Math.Max(1, System.Math.Min(gameOptions.NumImpostors, playerCount < 7 ? 1 : (playerCount < 9 ? 2 : 3)));
	}

	public static void ToggleMapFilter(this IGameOptions gameOptions, byte newId)
	{
	}

	public static bool FilterContainsMap(this IGameOptions gameOptions, byte newId)
	{
		return false;
	}

	public static float GetValue(this IGameOptions gameOptions, BaseGameSetting data)
	{
		if (gameOptions == null || data == null)
		{
			return 0f;
		}
		FloatGameSetting floatSetting = data as FloatGameSetting;
		if (floatSetting != null)
		{
			return gameOptions.GetFloat(floatSetting.OptionName);
		}
		IntGameSetting intSetting = data as IntGameSetting;
		if (intSetting != null)
		{
			return gameOptions.GetInt(intSetting.OptionName);
		}
		CheckboxGameSetting checkboxSetting = data as CheckboxGameSetting;
		if (checkboxSetting != null)
		{
			return gameOptions.GetBool(checkboxSetting.OptionName) ? 1f : 0f;
		}
		StringGameSetting stringSetting = data as StringGameSetting;
		if (stringSetting != null)
		{
			return gameOptions.GetInt(stringSetting.OptionName);
		}
		MapSelectionGameSetting mapSetting = data as MapSelectionGameSetting;
		if (mapSetting != null)
		{
			return gameOptions.GetByte(mapSetting.OptionName);
		}
		return 0f;
	}

	public static string ToHudString(this IGameOptions gameOptions, int numPlayers)
	{
		if (gameOptions == null)
		{
			return string.Empty;
		}
		if (SettingsStringBuilder == null)
		{
			SettingsStringBuilder = new StringBuilder();
		}
		SettingsStringBuilder.Length = 0;
		AppendItem(SettingsStringBuilder, StringNames.GameMapName, ((MapNames)gameOptions.MapId).ToString());
		AppendItem(SettingsStringBuilder, StringNames.GameNumImpostors, gameOptions.NumImpostors);
		AppendItem(SettingsStringBuilder, StringNames.GamePlayerSpeed, gameOptions.GetFloat(FloatOptionNames.PlayerSpeedMod), "x");
		AppendItem(SettingsStringBuilder, StringNames.GameCrewLight, gameOptions.GetFloat(FloatOptionNames.CrewLightMod), "x");
		AppendItem(SettingsStringBuilder, StringNames.GameImpostorLight, gameOptions.GetFloat(FloatOptionNames.ImpostorLightMod), "x");
		AppendItem(SettingsStringBuilder, StringNames.GameKillCooldown, gameOptions.GetFloat(FloatOptionNames.KillCooldown), "s");
		AppendItem(SettingsStringBuilder, StringNames.GameKillDistance, gameOptions.GetInt(Int32OptionNames.KillDistance));
		AppendItem(SettingsStringBuilder, StringNames.GameCommonTasks, gameOptions.GetInt(Int32OptionNames.NumCommonTasks));
		AppendItem(SettingsStringBuilder, StringNames.GameLongTasks, gameOptions.GetInt(Int32OptionNames.NumLongTasks));
		AppendItem(SettingsStringBuilder, StringNames.GameShortTasks, gameOptions.GetInt(Int32OptionNames.NumShortTasks));
		return SettingsStringBuilder.ToString();
	}

	private static void AppendItem(StringBuilder settings, StringNames stringName, bool value)
	{
		AppendItem(settings, stringName, value ? "On" : "Off");
	}

	private static void AppendItem(StringBuilder settings, StringNames stringName, float value, string secs)
	{
		AppendItem(settings, stringName, value.ToString("0.##") + secs);
	}

	private static void AppendItem(StringBuilder settings, StringNames stringName, int value, string secs)
	{
		AppendItem(settings, stringName, value + secs);
	}

	private static void AppendItem(StringBuilder settings, StringNames stringName, string value)
	{
		string title = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(stringName) : stringName.ToString();
		AppendItem(settings, title + ": " + value);
	}

	private static void AppendItem(StringBuilder settings, StringNames stringName, int value)
	{
		AppendItem(settings, stringName, value.ToString());
	}

	private static void AppendItem(StringBuilder settings, string str)
	{
		if (settings.Length > 0)
		{
			settings.AppendLine();
		}
		settings.Append(str);
	}

	private static void AppendImpostorPlayerSetting(StringBuilder settings, IGameOptions options)
	{
	}

	public static StringNames GetRulesPresetTitle(this IGameOptions gameOptions)
	{
		return gameOptions != null && gameOptions.RulesPreset != RulesPresets.Standard ? StringNames.GameModeStandardRoles : StringNames.GameSettingsLabel;
	}
}
