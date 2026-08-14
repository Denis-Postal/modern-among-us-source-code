using System;
using UnityEngine;

internal class SelectableHyperLink : MonoBehaviour, ITextPart
{
	public SelectableHyperLink parentHyperlink;

	[SerializeField]
	private UiElement HyperLink;

	[SerializeField]
	private string selectedColor;

	[SerializeField]
	private string unselectedColor;

	private Action onNewSelection;

	private string hyperLinkText;

	private string hyperLinkUrl;

	private string fullHyperLinkText;

	public string LinkText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string TaglessLinkText => null;

	public UiElement SelectableObject => null;

	public void SetSelectionCallback(Action _onNewSelection)
	{
	}

	public string GetText()
	{
		return null;
	}

	public void RemoveUiElement(ControllerUiElementsState menu)
	{
	}

	public void AddUiElement(ControllerUiElementsState menu)
	{
	}

	public void OnSelection()
	{
	}

	public void OnUnselection()
	{
	}

	public void Clicked()
	{
	}
}
