using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class PlayerOption : OptionBehaviour
{
	public TextMeshPro TitleText;

	public TextMeshPro ValueText;

	[SerializeField]
	private TextMeshPro PlusTxt;

	[SerializeField]
	private TextMeshPro MinusTxt;

	[SerializeField]
	private TextMeshPro OptionUnavailableTxt;

	[SerializeField]
	private GameOptionButton PlusBtn;

	[SerializeField]
	private GameOptionButton MinusBtn;

	[SerializeField]
	private GameObject ValueBox;

	private List<NetworkedPlayerInfo> Values;

	public int Value;

	private int oldValue;

	private int playerIndex;

	private Int32OptionNames optionName;

	public override void SetUpFromData(BaseGameSetting data, int maskLayer)
	{
	}

	public void OnEnable()
	{
	}

	private void SetValueText()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Increase()
	{
	}

	public void Decrease()
	{
	}

	public override int GetInt()
	{
		return 0;
	}

	private void UpdatePlayerIndex(int index)
	{
	}

	private void CheckValueChanged()
	{
	}

	private void UpdateValue()
	{
	}

	private void AdjustButtonsActiveState()
	{
	}
}
