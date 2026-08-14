using AmongUs.GameOptions;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Setting/PlayerSelectionGameSetting")]
public class PlayerSelectionGameSetting : BaseGameSetting
{
	public Int32OptionNames OptionName;

	public override string GetValueString(float value)
	{
		return null;
	}
}
