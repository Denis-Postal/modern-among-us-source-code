using UnityEngine;

public class PetsTab : InventoryTab
{
	private string petId;

	private PetData currentPet;

	private bool currentPetIsEquipped;

	private bool initialized;

	public override void OnEnable()
	{
		base.OnEnable();
		PetData[] unlockedPets = DestroyableSingleton<HatManager>.Instance.GetUnlockedPets();
		for (int i = 0; unlockedPets != null && i < unlockedPets.Length; i++)
		{
			PetData pet = unlockedPets[i];
			ColorChip chip = Object.Instantiate(ColorTabPrefab, scroller != null ? scroller.Inner : transform);
			float x = XRange.Lerp(NumPerRow <= 1 ? 0f : (float)(i % NumPerRow) / (NumPerRow - 1));
			float y = YStart - i / Mathf.Max(1, NumPerRow) * YOffset;
			chip.transform.localPosition = new Vector3(x, y, -1f);
			chip.Tag = pet;
			chip.ProductId = PlayerCustomization.GetCosmeticId(pet, PetData.EmptyId);
			PetBehaviour petPrefab = pet != null ? CosmeticAssetLoader.LoadReference<PetBehaviour>(pet.PetPrefabRef) : null;
			SpriteRenderer petRenderer = petPrefab != null ? petPrefab.GetComponentInChildren<SpriteRenderer>(true) : null;
			SetChipSprite(chip, petRenderer != null ? petRenderer.sprite : null, GetDisplayColor());
			if (chip.Button != null)
			{
				chip.Button.OnClick.AddListener(delegate
				{
					SelectChip(chip);
					SelectPet(chip, pet);
				});
			}
			ColorChips.Add(chip);
		}
		initialized = true;
		SetScrollerBounds();
		ColorChip defaultSelectable = GetDefaultSelectable();
		SelectChip(defaultSelectable);
		SelectPet(defaultSelectable, defaultSelectable?.Tag as PetData);
	}

	public void Update()
	{
		currentPetIsEquipped = PlayerCustomization.IsEquipped(currentPet);
	}

	private void SelectPet(ColorChip sender, PetData pet)
	{
		currentPet = pet;
		petId = PlayerCustomization.GetCosmeticId(pet, PetData.EmptyId);
		currentPetIsEquipped = PlayerCustomization.IsEquipped(currentPet);
		if (PlayerPreview != null && currentPet != null)
		{
			PlayerPreview.SetPetIdle(currentPet, GetDisplayColor());
		}
		PlayerCustomizationMenu.Instance?.SetItemName(currentPet != null ? currentPet.GetItemName() : string.Empty);
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	public override void ClickEquip()
	{
		PlayerCustomization.EquipPet(currentPet);
		currentPetIsEquipped = true;
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
		return currentPetIsEquipped;
	}

	public override string GetCurrentProdID()
	{
		return petId;
	}
}
