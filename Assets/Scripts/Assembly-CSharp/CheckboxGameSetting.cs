using AmongUs.GameOptions;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Setting/CheckboxGameSetting")]
public class CheckboxGameSetting : BaseGameSetting
{
	public BoolOptionNames OptionName;

	public override string GetValueString(float value)
	{
		StringNames stringName = value > 0.5f ? StringNames.SettingsOn : StringNames.SettingsOff;
		return DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(stringName) : stringName.ToString();
	}
}
