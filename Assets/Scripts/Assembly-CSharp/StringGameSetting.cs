using AmongUs.GameOptions;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Setting/StringGameSetting")]
public class StringGameSetting : BaseGameSetting
{
	public Int32OptionNames OptionName;

	public StringNames[] Values;

	public int Index;

	public override string GetValueString(float value)
	{
		if (Values == null || Values.Length == 0)
		{
			return Mathf.RoundToInt(value).ToString();
		}
		int index = Mathf.Clamp(Mathf.RoundToInt(value), 0, Values.Length - 1);
		StringNames stringName = Values[index];
		return DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(stringName) : stringName.ToString();
	}
}
