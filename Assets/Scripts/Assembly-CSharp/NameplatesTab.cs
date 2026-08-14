using UnityEngine;

public class NameplatesTab : InventoryTab
{
	public PlayerVoteArea previewArea;

	private string plateId;

	private NamePlateData currentNameplate;

	private bool currentNameplateIsEquipped;

	private void Awake()
	{
	}

	public override void OnEnable()
	{
		base.OnEnable();
		NamePlateData[] unlockedNamePlates = DestroyableSingleton<HatManager>.Instance.GetUnlockedNamePlates();
		for (int i = 0; unlockedNamePlates != null && i < unlockedNamePlates.Length; i++)
		{
			NamePlateData plate = unlockedNamePlates[i];
			ColorChip chip = Object.Instantiate(ColorTabPrefab, scroller != null ? scroller.Inner : transform);
			float x = XRange.Lerp(NumPerRow <= 1 ? 0f : (float)(i % NumPerRow) / (NumPerRow - 1));
			float y = YStart - i / Mathf.Max(1, NumPerRow) * YOffset;
			chip.transform.localPosition = new Vector3(x, y, -1f);
			chip.Tag = plate;
			chip.ProductId = PlayerCustomization.GetCosmeticId(plate, NamePlateData.EmptyId);
			NamePlateViewData plateView = plate != null ? CosmeticAssetLoader.LoadReference<NamePlateViewData>(plate.ViewDataRef, plate.name) : null;
			SetChipSprite(chip, plateView != null ? plateView.Image : null, GetDisplayColor());
			if (chip.Button != null)
			{
				chip.Button.OnClick.AddListener(delegate
				{
					SelectChip(chip);
					SelectNameplate(plate);
				});
			}
			ColorChips.Add(chip);
		}
		SetScrollerBounds();
		ColorChip defaultSelectable = GetDefaultSelectable();
		SelectChip(defaultSelectable);
		SelectNameplate(defaultSelectable?.Tag as NamePlateData);
	}

	public void Update()
	{
		currentNameplateIsEquipped = PlayerCustomization.IsEquipped(currentNameplate);
	}

	public override void ClickEquip()
	{
		PlayerCustomization.EquipNameplate(currentNameplate);
		currentNameplateIsEquipped = true;
	}

	private void SelectNameplate(NamePlateData plate)
	{
		currentNameplate = plate;
		plateId = PlayerCustomization.GetCosmeticId(plate, NamePlateData.EmptyId);
		currentNameplateIsEquipped = PlayerCustomization.IsEquipped(currentNameplate);
		if (previewArea != null && previewArea.Background != null)
		{
			NamePlateViewData plateView = plate != null ? CosmeticAssetLoader.LoadReference<NamePlateViewData>(plate.ViewDataRef, plate.name) : null;
			previewArea.Background.sprite = plateView != null ? plateView.Image : null;
		}
		PlayerCustomizationMenu.Instance?.SetItemName(currentNameplate != null ? currentNameplate.GetItemName() : string.Empty);
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	public override ColorChip GetDefaultSelectable()
	{
		if (ColorChips != null)
		{
			for (int i = 0; i < ColorChips.Count; i++)
			{
				if (PlayerCustomization.IsEquipped(ColorChips[i].Tag as CosmeticData))
				{
					return ColorChips[i];
				}
			}
		}
		return base.GetDefaultSelectable();
	}

	public override bool IsSelectedItemEquipped()
	{
		return currentNameplateIsEquipped;
	}

	public override string GetCurrentProdID()
	{
		return plateId;
	}
}
