using TMPro;
using UnityEngine;

public class CubesTab : InventoryTab
{
	public CosmicubeMenu cosmicubeMenu;

	public GameObject viewButton;

	public PassiveButton activateButton;

	public TextMeshPro activateText;

	public TextMeshPro itemName;

	public SpriteRenderer podIcon;

	public SpriteRenderer maskArea;

	private CosmicubeData currentCube;

	private void Awake()
	{
	}

	public override void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void SelectCube(ColorChip chip, CosmicubeData cube)
	{
	}

	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	public void ViewCube()
	{
	}

	public override void ClickEquip()
	{
	}

	public override bool IsSelectedItemEquipped()
	{
		return false;
	}

	private void ActivateCube()
	{
	}

	private void DeactivateCube()
	{
	}
}
