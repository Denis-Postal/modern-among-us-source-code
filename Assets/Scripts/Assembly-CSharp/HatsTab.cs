using UnityEngine;

public class HatsTab : InventoryTab
{
	private HatData currentHat;

	private bool currentHatIsEquipped;

	public override void OnEnable()
	{
		base.OnEnable();
		HatData[] unlockedHats = DestroyableSingleton<HatManager>.Instance.GetUnlockedHats();
		for (int i = 0; unlockedHats != null && i < unlockedHats.Length; i++)
		{
			HatData hat = unlockedHats[i];
			ColorChip chip = CreateChip(i);
			chip.Tag = hat;
			chip.ProductId = PlayerCustomization.GetCosmeticId(hat, HatData.EmptyId);
			if (chip.Inner != null)
			{
				chip.Inner.SetHat(hat, GetDisplayColor());
			}
			if (chip.Button != null)
			{
				chip.Button.OnClick.AddListener(delegate
				{
					SelectChip(chip);
					SelectHat(hat);
				});
			}
			ColorChips.Add(chip);
		}
		SetScrollerBounds();
		ColorChip defaultSelectable = GetDefaultSelectable();
		SelectChip(defaultSelectable);
		SelectHat(defaultSelectable?.Tag as HatData);
	}

	public void Update()
	{
		currentHatIsEquipped = PlayerCustomization.IsEquipped(currentHat);
	}

	private void SelectHat(HatData hat)
	{
		currentHat = hat;
		currentHatIsEquipped = PlayerCustomization.IsEquipped(currentHat);
		if (PlayerPreview != null && currentHat != null)
		{
			PlayerPreview.SetHat(currentHat, GetDisplayColor());
		}
		PlayerCustomizationMenu.Instance?.SetItemName(currentHat != null ? currentHat.GetItemName() : string.Empty);
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	public override bool IsSelectedItemEquipped()
	{
		return currentHatIsEquipped;
	}

	public override string GetCurrentProdID()
	{
		return PlayerCustomization.GetCosmeticId(currentHat, HatData.EmptyId);
	}

	public override void ClickEquip()
	{
		PlayerCustomization.EquipHat(currentHat);
		currentHatIsEquipped = true;
	}

	public override ColorChip GetDefaultSelectable()
	{
		return FindEquippedOrFirst<HatData>();
	}

	private ColorChip CreateChip(int index)
	{
		ColorChip chip = Object.Instantiate(ColorTabPrefab, scroller != null ? scroller.Inner : transform);
		float x = XRange.Lerp(NumPerRow <= 1 ? 0f : (float)(index % NumPerRow) / (NumPerRow - 1));
		float y = YStart - index / Mathf.Max(1, NumPerRow) * YOffset;
		chip.transform.localPosition = new Vector3(x, y, -1f);
		return chip;
	}

	private ColorChip FindEquippedOrFirst<T>() where T : CosmeticData
	{
		if (ColorChips == null)
		{
			return null;
		}
		for (int i = 0; i < ColorChips.Count; i++)
		{
			if (PlayerCustomization.IsEquipped(ColorChips[i].Tag as CosmeticData))
			{
				return ColorChips[i];
			}
		}
		return base.GetDefaultSelectable();
	}
}
