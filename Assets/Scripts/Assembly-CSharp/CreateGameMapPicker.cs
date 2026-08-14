using System;
using System.Collections.Generic;

public class CreateGameMapPicker : GameOptionsMapPicker
{
	private Action<int> toolTipAction;

	public override void Initialize(int maskLayer)
	{
		base.Initialize(maskLayer);
	}

	protected override void UpdateValue()
	{
		base.UpdateValue();
	}

	public void SetupMouseOver(Action<int> action)
	{
	}

	public int GetSelectedID()
	{
		return selectedMapId;
	}

	public List<MapSelectButton> GetMapButtons()
	{
		return MapButtons;
	}
}
