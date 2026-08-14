using System;
using System.Collections.Generic;
using AmongUs.Matchmaking;
using TMPro;
using UnityEngine;

public class FilterMapPicker : GameOptionsMapPicker
{
	[SerializeField]
	private StringNames[] mapStrings;

	[SerializeField]
	private TextMeshPro mapNames;

	private const string COMMA_SPACE_TEXT = ", ";

	private List<int> mapIDs;

	public override void Initialize(int maskLayer)
	{
		base.Initialize(maskLayer);
	}

	protected override void UpdateValue()
	{
		base.UpdateValue();
	}

	public bool IsFilterEnabled()
	{
		return mapIDs != null && mapIDs.Count > 0;
	}

	public void SetupSelectedIcons(MapGameFilter gameFilter)
	{
	}

	private void AddMapName(int mapID)
	{
	}

	private void RemoveMapName(int mapID)
	{
	}

	private void ClearMapNames()
	{
	}

	private void SetupMapNameString()
	{
	}

	public void SetupClickAction(Action checkFilterLimit = null)
	{
	}

	public List<MapSelectButton> GetMapButtons()
	{
		return MapButtons;
	}

	public void SetupMouseOver(Action<int> action)
	{
	}
}
