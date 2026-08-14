using System.Collections.Generic;
using UnityEngine;

public class InventoryTab : MonoBehaviour
{
	public ColorChip ColorTabPrefab;

	public PoolablePlayer PlayerPreview;

	public FloatRange XRange;

	public float YStart;

	public float YOffset;

	public int NumPerRow;

	public Scroller scroller;

	protected int NumRowsVisible;

	[HideInInspector]
	public List<ColorChip> ColorChips;

	public bool ignoreLongMode;

	protected bool HasLocalPlayer()
	{
		return (bool)PlayerControl.LocalPlayer;
	}

	protected int GetDisplayColor()
	{
		return PlayerCustomization.ColorId;
	}

	public int CurrentColorId()
	{
		return GetDisplayColor();
	}

	public virtual void ClickEquip()
	{
	}

	public virtual void OnEnable()
	{
		if (ColorChips == null)
		{
			ColorChips = new List<ColorChip>();
		}
	}

	public virtual void OnDisable()
	{
		if (ColorChips == null)
		{
			return;
		}
		for (int i = 0; i < ColorChips.Count; i++)
		{
			if (ColorChips[i] != null)
			{
				UnityEngine.Object.Destroy(ColorChips[i].gameObject);
			}
		}
		ColorChips.Clear();
	}

	public virtual ColorChip GetDefaultSelectable()
	{
		return ColorChips != null && ColorChips.Count > 0 ? ColorChips[0] : null;
	}

	public virtual bool IsSelectedItemEquipped()
	{
		return false;
	}

	public virtual string GetCurrentProdID()
	{
		return null;
	}

	protected void SelectChip(ColorChip selectedChip)
	{
		if (ColorChips != null)
		{
			for (int i = 0; i < ColorChips.Count; i++)
			{
				if (ColorChips[i] != null)
				{
					ColorChips[i].Deselect();
				}
			}
		}
		if (selectedChip != null)
		{
			selectedChip.ShowSelected();
		}
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	protected void UpdateMaterials(SpriteRenderer spriteRenderer, CosmeticData data)
	{
		if (spriteRenderer != null)
		{
			PlayerMaterial.SetColors(GetDisplayColor(), spriteRenderer);
		}
	}

	protected void SetScrollerBounds()
	{
		if (scroller == null || ColorChips == null || NumPerRow <= 0)
		{
			return;
		}
		int rows = Mathf.CeilToInt((float)ColorChips.Count / NumPerRow);
		scroller.YBounds.max = Mathf.Max(0f, rows * Mathf.Abs(YOffset) - 3f);
	}

	protected void SetChipSprite(ColorChip chip, Sprite sprite, int colorId)
	{
		if (chip == null)
		{
			return;
		}
		SpriteRenderer target = chip.Inner != null && chip.Inner.FrontLayer != null ? chip.Inner.FrontLayer : chip.GetComponentInChildren<SpriteRenderer>(true);
		if (target != null)
		{
			target.sprite = sprite;
			target.enabled = sprite != null;
			PlayerMaterial.SetColors(colorId, target);
		}
		if (chip.Inner != null && chip.Inner.BackLayer != null)
		{
			chip.Inner.BackLayer.sprite = null;
			chip.Inner.BackLayer.enabled = false;
		}
	}
}
