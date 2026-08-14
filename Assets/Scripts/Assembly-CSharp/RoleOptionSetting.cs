using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class RoleOptionSetting : OptionBehaviour
{
	[SerializeField]
	private TextMeshPro titleText;

	[SerializeField]
	private TextMeshPro countText;

	[SerializeField]
	private TextMeshPro chanceText;

	[SerializeField]
	private SpriteRenderer labelSprite;

	[SerializeField]
	private List<PassiveButton> controllerSelectable;

	[SerializeField]
	private GameOptionButton CountPlusBtn;

	[SerializeField]
	private GameOptionButton CountMinusBtn;

	[SerializeField]
	private GameOptionButton ChancePlusBtn;

	[SerializeField]
	private GameOptionButton ChanceMinusBtn;

	private RoleBehaviour role;

	private int roleMaxCount;

	private int roleChance;

	public int RoleMaxCount => 0;

	public int RoleChance => 0;

	public RoleBehaviour Role => null;

	public List<PassiveButton> ControllerSelectable => null;

	private int RoleMax => 0;

	public void SetRole(IRoleOptionsCollection options, RoleBehaviour role, int maskLayer)
	{
	}

	public void UpdateValuesAndText(IRoleOptionsCollection options)
	{
	}

	public void IncreaseCount()
	{
	}

	public void DecreaseCount()
	{
	}

	public void IncreaseChance()
	{
	}

	public void DecreaseChance()
	{
	}

	private void AdjustCountButtonsActiveState()
	{
	}

	private void AdjustChanceButtonsActiveState()
	{
	}
}
