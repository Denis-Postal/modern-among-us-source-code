public class ProgressionManager
{
	public class XpGrantResult
	{
		public readonly uint GrantedXp;

		public readonly uint OldXpAmount;

		public readonly uint XpRequiredToLevelUp;

		public readonly uint XpRequiredToLevelUpNextLevel;

		public readonly uint OldLevel;

		public readonly uint NewLevel;

		public readonly uint MaxLevel;

		public readonly bool LevelledUp;

		public XpGrantResult(uint grantedXp, uint oldXpAmount, uint xpRequiredToLevelUp, uint xpRequiredToLevelUpNextLevel, bool levelledUp, uint oldLevel, uint newLevel, uint maxLevel)
		{
		}

		public static XpGrantResult Default()
		{
			return null;
		}
	}

	public class CurrencyGrantResult
	{
		public readonly string PodId;

		public readonly uint OldPodAmount;

		public readonly uint GrantedPodsWithMultiplierApplied;

		public readonly float Multiplier;

		public uint GrantedPodsPreMultiplier => 0u;

		public CurrencyGrantResult(string podId, uint oldPodAmount, uint grantedPodsWithMultiplierApplied, float multiplier)
		{
		}

		public static CurrencyGrantResult Default()
		{
			return null;
		}
	}

	public const int FirstLevel = 0;

	public static ProgressionManager Instance;

	private const uint MaxLevel = 99u;

	public string CurrentVisualLevel => null;

	public static string FormatVisualLevel(uint playerLevel)
	{
		return null;
	}
}
