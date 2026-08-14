using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class GamePresetsTab : MonoBehaviour
{
	[SerializeField]
	private List<SpriteRenderer> SpritesToDesaturate;

	[SerializeField]
	private PassiveButton StandardPresetButton;

	[SerializeField]
	private PassiveButton SecondPresetButton;

	[SerializeField]
	private GameOptionsMenu GameOptionsMenu;

	[SerializeField]
	private SpriteRenderer[] StandardRulesSprites;

	[SerializeField]
	private SpriteRenderer[] AlternateRulesSprites;

	[SerializeField]
	private TextMeshPro StandardRulesText;

	[SerializeField]
	private TextMeshPro AlternateRulesText;

	[SerializeField]
	private TextMeshPro PresetDescriptionText;

	[SerializeField]
	private TransitionOpen ConfirmPresetPopUp;

	[SerializeField]
	private PassiveButton PresetConfirmButton;

	[SerializeField]
	private PassiveButton[] PresetCancelButtons;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OpenMenu()
	{
	}

	public void CloseMenu()
	{
	}

	private void Start()
	{
	}

	private void SetSelectedText()
	{
	}

	private void ClickPresetButton(RulesPresets preset, bool standardButtonSelected)
	{
	}
}
