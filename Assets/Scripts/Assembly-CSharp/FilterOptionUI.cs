using System;
using System.Collections.Generic;
using AmongUs.Matchmaking;
using TMPro;
using UnityEngine;

public class FilterOptionUI : MonoBehaviour
{
	public enum ButtonSize
	{
		Short = 0,
		Med = 1,
		Long = 2
	}

	public FilterPopUp.FilterInfoUI FilterInfo;

	public Action<int, int, string> toolTipCallback;

	public int HighlightIndex;

	[SerializeField]
	private List<PassiveButton> currentButtons;

	[SerializeField]
	private PassiveButton[] buttonPrefabs;

	[SerializeField]
	private TextMeshPro label;

	[SerializeField]
	private SpriteRenderer blackSquare;

	private const int MASK_LAYER = 51;

	private const float SHORT_DISTANCE = 0.55f;

	private const float X_START_SHORT = -0.65f;

	private const float MED_DISTANCE = 1.05f;

	private const float X_START_MED = 0f;

	private const float LONG_DISTANCE = 2f;

	private const float X_START_LONG = 0.11f;

	private Action<bool, int, FilterPopUp.FilterInfoUI> onClickAction;

	private GameFilter gameFilter;

	private static readonly int STENCIL_COMP;

	private static readonly int STENCIL;

	public void SetupButtons(Action<bool, int, FilterPopUp.FilterInfoUI> clickAction, Collider2D clickMask)
	{
	}

	public SpriteRenderer GetBlackSquare()
	{
		return null;
	}

	public void ResetFilterSelection()
	{
	}

	public List<PassiveButton> GetButtons()
	{
		return null;
	}

	public void SetupButtonMaskLayer()
	{
	}

	private void SetupNav()
	{
	}

	private void HandleSelection(int index)
	{
	}

	public void SetInactiveButton(bool isEnabled)
	{
	}

	public bool isFilterActive()
	{
		return false;
	}
}
