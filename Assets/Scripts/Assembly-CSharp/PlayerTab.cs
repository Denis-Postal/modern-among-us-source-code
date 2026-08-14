using System.Collections.Generic;
using UnityEngine;

public class PlayerTab : InventoryTab
{
	private const int Columns = 4;

	public Transform ColorTabArea;

	private HashSet<int> AvailableColors;

	private bool currentColorIsEquipped;

	private int currentColor;

	private static readonly Color32[] FallbackPlayerColors =
	{
		new Color32(198, 17, 17, byte.MaxValue),
		new Color32(19, 46, 210, byte.MaxValue),
		new Color32(17, 128, 45, byte.MaxValue),
		new Color32(238, 84, 187, byte.MaxValue),
		new Color32(240, 125, 13, byte.MaxValue),
		new Color32(246, 246, 87, byte.MaxValue),
		new Color32(63, 71, 78, byte.MaxValue),
		new Color32(215, 225, 241, byte.MaxValue),
		new Color32(107, 47, 188, byte.MaxValue),
		new Color32(113, 73, 30, byte.MaxValue),
		new Color32(56, byte.MaxValue, 221, byte.MaxValue),
		new Color32(80, 240, 57, byte.MaxValue)
	};

	public override void OnEnable()
	{
		base.OnEnable();
		NumPerRow = Columns;
		int count = Palette.PlayerColors != null && Palette.PlayerColors.Length > 0 ? Palette.PlayerColors.Length : 12;
		for (int i = 0; i < count; i++)
		{
			int colorId = i;
			ColorChip chip = Object.Instantiate(ColorTabPrefab, ColorTabArea != null ? ColorTabArea : transform);
			float x = XRange.Lerp((float)(i % Columns) / (Columns - 1));
			float y = YStart - i / Columns * YOffset;
			chip.transform.localPosition = new Vector3(x, y, -1f);
			chip.Tag = colorId;
			chip.ProductId = colorId.ToString();
			SetChipColor(chip, colorId);
			if (chip.Button != null)
			{
				chip.Button.OnClick.AddListener(delegate
				{
					SelectChip(chip);
					SelectColor(colorId);
				});
			}
			ColorChips.Add(chip);
		}
		SelectChip(GetDefaultSelectable());
		SelectColor(PlayerCustomization.ColorId);
	}

	public void Update()
	{
		currentColorIsEquipped = currentColor == PlayerCustomization.ColorId;
	}

	private void SelectColor(int colorId)
	{
		currentColor = colorId;
		currentColorIsEquipped = currentColor == PlayerCustomization.ColorId;
		if (PlayerPreview != null)
		{
			PlayerPreview.SetBodyColor(colorId);
		}
		PlayerCustomizationMenu.Instance?.SetItemName("Color " + colorId);
		PlayerCustomizationMenu.Instance?.UpdateEquipState();
	}

	public override ColorChip GetDefaultSelectable()
	{
		if (ColorChips != null)
		{
			for (int i = 0; i < ColorChips.Count; i++)
			{
				if ((int)ColorChips[i].Tag == PlayerCustomization.ColorId)
				{
					return ColorChips[i];
				}
			}
		}
		return base.GetDefaultSelectable();
	}

	public override void ClickEquip()
	{
		PlayerCustomization.EquipColor(currentColor);
		currentColorIsEquipped = true;
	}

	public override bool IsSelectedItemEquipped()
	{
		return currentColorIsEquipped;
	}

	private void UpdateAvailableColors()
	{
		if (AvailableColors == null)
		{
			AvailableColors = new HashSet<int>();
		}
	}

	private static void SetChipColor(ColorChip chip, int colorId)
	{
		if (chip == null)
		{
			return;
		}
		Color color = GetPlayerColor(colorId);
		SpriteRenderer[] renderers = chip.GetComponentsInChildren<SpriteRenderer>(true);
		for (int i = 0; i < renderers.Length; i++)
		{
			if (renderers[i] == null || IsOverlayRenderer(chip, renderers[i]))
			{
				continue;
			}
			renderers[i].color = color;
			PlayerMaterial.SetColors(color, renderers[i]);
		}
	}

	private static bool IsOverlayRenderer(ColorChip chip, SpriteRenderer renderer)
	{
		return (chip.SelectionHighlight != null && renderer == chip.SelectionHighlight) || IsChildOf(chip.InUseForeground, renderer) || IsChildOf(chip.PlayerEquippedForeground, renderer);
	}

	private static bool IsChildOf(GameObject parent, SpriteRenderer renderer)
	{
		return parent != null && renderer != null && renderer.transform.IsChildOf(parent.transform);
	}

	private static Color GetPlayerColor(int colorId)
	{
		Color32[] colors = Palette.PlayerColors != null && Palette.PlayerColors.Length > 0 ? Palette.PlayerColors : FallbackPlayerColors;
		return colors[Mathf.Abs(colorId) % colors.Length];
	}
}
