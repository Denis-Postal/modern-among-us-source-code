using TMPro;
using UnityEngine;

public class ViewSettingsInfoPanelRoleVariant : ViewSettingsInfoPanel
{
	[SerializeField]
	protected SpriteRenderer chanceBackground;

	[SerializeField]
	protected SpriteRenderer iconSprite;

	[SerializeField]
	protected TextMeshPro chanceText;

	[SerializeField]
	protected TextMeshPro chanceTitle;

	[SerializeField]
	protected Sprite disabledCube;

	[SerializeField]
	protected Sprite crewmateCube;

	[SerializeField]
	protected Sprite impostorCube;

	public void SetInfo(string name, int count, int chance, int maskLayer, Color32 color, Sprite roleIcon, bool crewmateTeam, bool showDisabledBackground = false)
	{
	}

	protected override void SetMaskLayer(int maskLayer)
	{
	}
}
