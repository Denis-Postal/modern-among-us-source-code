using TMPro;
using UnityEngine;

public class ViewSettingsInfoPanel : MonoBehaviour
{
	[SerializeField]
	protected SpriteRenderer labelBackground;

	[SerializeField]
	protected SpriteRenderer background;

	[SerializeField]
	protected SpriteRenderer disabledBackground;

	[SerializeField]
	protected SpriteRenderer checkMark;

	[SerializeField]
	protected SpriteRenderer checkMarkOff;

	[SerializeField]
	protected TextMeshPro titleText;

	[SerializeField]
	protected TextMeshPro settingText;

	public void SetInfo(StringNames title, string valueString, int maskLayer)
	{
	}

	public void SetInfoCheckbox(StringNames title, int maskLayer, bool isOn)
	{
	}

	protected virtual void SetMaskLayer(int maskLayer)
	{
	}
}
