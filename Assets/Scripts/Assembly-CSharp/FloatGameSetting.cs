using AmongUs.GameOptions;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Setting/FloatGameSetting")]
public class FloatGameSetting : BaseGameSetting
{
	public FloatOptionNames OptionName;

	public float Value;

	public float Increment;

	public FloatRange ValidRange;

	public bool ZeroIsInfinity;

	public NumberSuffixes SuffixType;

	public string FormatString;

	public override string GetValueString(float value)
	{
		if (ZeroIsInfinity && value <= 0f)
		{
			return Constants.InfinitySymbol;
		}
		string text = string.IsNullOrEmpty(FormatString) ? value.ToString("0.##") : string.Format(FormatString, value);
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
