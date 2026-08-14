using UnityEngine;

public class VisorsTab : InventoryTab
{
	private string visorId;

	private VisorData currentVisor;

	private bool currentVisorIsEquipped;

	public override void OnEnable()
	{
		base.OnEnable();
		VisorData[] unlockedVisors = DestroyableSingleton<HatManager>.Instance.GetUnlockedVisors();
		for (int i = 0; unlockedVisors != null && i < unlockedVisors.Length; i++)
		{
			VisorData visor = unlockedVisors[i];
			ColorChip chip = CreateChip(i);
			chip.Tag = visor;
			chip.ProductId = PlayerCustomization.GetCosmeticId(visor, VisorData.EmptyId);
			VisorViewData visorView = visor != null ? CosmeticAssetLoader.LoadReference<VisorViewData>(visor.ViewDataRef, visor.name) : null;
			SetChipSprite(chip, visorView != null ? visorView.IdleFrame : null, GetDisplayColor());
			if (chip.Button != null)
			{
				chip.Button.OnClick.AddListener(delegate
				{
					SelectChip(chip);
					SelectVisor(visor);
				});
			}
			ColorChips.Add(chip);
		}
		SetScrollerBounds();
		ColorChip defaultSelectable = GetDefaultSelectable();
		SelectChip(defaultSelectable);
		SelectVisor(defaultSelectable?.Tag as VisorData);
	}

	public void Update()
	{
		currentVisorIsEquipped = PlayerCustomization.IsEquipped(currentVisor);
	}

	public override void ClickEquip()
	{
		PlayerCustomization.EquipVisor(currentVisor);
		currentVisorIsEquipped = true;
	}

	public override ColorChip GetDefaultSelectable()
	{
		return FindEquippedOrFirst();
	}

	public override bool IsSelectedItemEquipped()
	{
		return currentVisorIsEquipped;
	}

	public override string GetCurrentProdID()
	{
		return visorId;
	}

	private void SelectVisor(VisorData visor)
	{
		currentVisor = visor;
		visorId = PlayerCustomization.GetCosmeticId(visor, VisorData.EmptyId);
		currentVisorIsEquipped = PlayerCustomization.IsEquipped(currentVisor);
		if (PlayerPreview != null && currentVisor != null)
		{
			PlayerPreview.SetVisor(currentVisor, GetDisplayColor());
		}
		PlayerCustomizationMenu.Instance?.SetItemName(currentVisor != null ? currentVisor.GetItemName() : string.Empty);
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	private ColorChip CreateChip(int index)
	{
		ColorChip chip = Object.Instantiate(ColorTabPrefab, scroller != null ? scroller.Inner : transform);
		float x = XRange.Lerp(NumPerRow <= 1 ? 0f : (float)(index % NumPerRow) / (NumPerRow - 1));
		float y = YStart - index / Mathf.Max(1, NumPerRow) * YOffset;
		chip.transform.localPosition = new Vector3(x, y, -1f);
		return chip;
	}

	private ColorChip FindEquippedOrFirst()
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
}
