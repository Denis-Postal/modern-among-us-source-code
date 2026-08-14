using System;
using System.Collections.Generic;

[Serializable]
public class ControllerUiElementsState
{
	public string MenuName;

	public UiElement CurrentSelection;

	public List<UiElement> SelectableUiElements;

	public UiElement BackButton;

	public bool EnforceGridNavigation;

	public float zPos;

	public bool IsScene;

	public void Reset()
	{
	}
}
