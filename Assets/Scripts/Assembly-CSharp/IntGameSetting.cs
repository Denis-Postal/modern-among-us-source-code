using AmongUs.GameOptions;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Setting/IntGameSetting")]
public class IntGameSetting : BaseGameSetting
{
	public Int32OptionNames OptionName;

	public int Value;

	public int Increment;

	public IntRange ValidRange;

	public bool ZeroIsInfinity;

	public NumberSuffixes SuffixType;

	public string FormatString;

	public override string GetValueString(float value)
	{
		int intValue = Mathf.RoundToInt(value);
		if (ZeroIsInfinity && intValue <= 0)
		{
			return Constants.InfinitySymbol;
		}
		string text = string.IsNullOrEmpty(FormatString) ? intValue.ToString() : string.Format(FormatString, intValue);
		if (SuffixType == NumberSuffixes.Multiplier)
		{
			text += "x";
		}
		else if (SuffixType == NumberSuffixes.Seconds)
		{
			text += "s";
		}
		return text;
	}
}
