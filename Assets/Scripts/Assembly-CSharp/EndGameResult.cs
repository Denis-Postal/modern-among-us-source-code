using System.Collections.Generic;
using Hazel;

public class EndGameResult
{
	public static List<CachedPlayerData> CachedWinners;

	public static CachedPlayerData CachedLocalPlayer;

	public static GameOverReason CachedGameOverReason;

	public static bool CachedShowAd;

	public static ProgressionManager.XpGrantResult CachedXpGrantResult;

	public static ProgressionManager.CurrencyGrantResult CachedBeansGrantResult;

	public static ProgressionManager.CurrencyGrantResult CachedPodsGrantResult;

	public readonly GameOverReason GameOverReason;

	public readonly bool ShowAd;

	public readonly ProgressionManager.XpGrantResult XpGrantResult;

	public readonly ProgressionManager.CurrencyGrantResult PodsGrantResult;

	public readonly ProgressionManager.CurrencyGrantResult BeansGrantResult;

	private EndGameResult(GameOverReason gameOverReason, bool showAd, ProgressionManager.XpGrantResult xpGrantResult = null, ProgressionManager.CurrencyGrantResult podsGrantResult = null, ProgressionManager.CurrencyGrantResult beansGrantResult = null)
	{
	}

	public static void ResetCachedValues()
	{
	}

	public static EndGameResult Create(MessageReader reader)
	{
		return null;
	}
}
