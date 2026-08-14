using AmongUs.GameOptions;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Setting/MapSelectionGameSetting")]
public class MapSelectionGameSetting : BaseGameSetting
{
	public ByteOptionNames OptionName;

	public StringNames[] Values;

	public void TryGetInt(IGameOptions gameOptions, out int value)
	{
		byte mapId;
		value = gameOptions != null && gameOptions.TryGetByte(OptionName, out mapId) ? mapId : 0;
	}

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
