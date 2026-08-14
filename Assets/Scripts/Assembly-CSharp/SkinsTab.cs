using UnityEngine;

public class SkinsTab : InventoryTab
{
	private string skinId;

	private SkinData currentSkin;

	private bool currentSkinIsEquipped;

	public override void OnEnable()
	{
		base.OnEnable();
		SkinData[] unlockedSkins = DestroyableSingleton<HatManager>.Instance.GetUnlockedSkins();
		for (int i = 0; unlockedSkins != null && i < unlockedSkins.Length; i++)
		{
			SkinData skin = unlockedSkins[i];
			ColorChip chip = CreateChip(i);
			chip.Tag = skin;
			chip.ProductId = PlayerCustomization.GetCosmeticId(skin, SkinData.EmptyId);
			SkinViewData skinView = skin != null ? CosmeticAssetLoader.LoadReference<SkinViewData>(skin.ViewDataRef, skin.name) : null;
			SetChipSprite(chip, skinView != null ? skinView.IdleFrame : null, GetDisplayColor());
			if (chip.Button != null)
			{
				chip.Button.OnClick.AddListener(delegate
				{
					SelectChip(chip);
					SelectSkin(skin);
				});
			}
			ColorChips.Add(chip);
		}
		SetScrollerBounds();
		ColorChip defaultSelectable = GetDefaultSelectable();
		SelectChip(defaultSelectable);
		SelectSkin(defaultSelectable?.Tag as SkinData);
	}

	public void Update()
	{
		currentSkinIsEquipped = PlayerCustomization.IsEquipped(currentSkin);
	}

	public override void ClickEquip()
	{
		PlayerCustomization.EquipSkin(currentSkin);
		currentSkinIsEquipped = true;
	}

	private void SelectSkin(SkinData skin)
	{
		currentSkin = skin;
		skinId = PlayerCustomization.GetCosmeticId(skin, SkinData.EmptyId);
		currentSkinIsEquipped = PlayerCustomization.IsEquipped(currentSkin);
		if (PlayerPreview != null && currentSkin != null)
		{
			PlayerPreview.SetSkin(currentSkin, GetDisplayColor());
		}
		PlayerCustomizationMenu.Instance?.SetItemName(currentSkin != null ? currentSkin.GetItemName() : string.Empty);
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	public override ColorChip GetDefaultSelectable()
	{
		return FindEquippedOrFirst();
	}

	public override bool IsSelectedItemEquipped()
	{
		return currentSkinIsEquipped;
	}

	public override string GetCurrentProdID()
	{
		return skinId;
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
