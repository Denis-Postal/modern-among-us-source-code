using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RegionMenu : MonoBehaviour
{
	public ObjectPoolBehavior ButtonPool;

	public TextMeshPro RegionText;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	private UiElement defaultButtonSelected;

	private List<UiElement> controllerSelectable;

	private void Awake()
	{
	}

	public void OnEnable()
	{
	}

	private void OpenCustomRegion()
	{
	}

	public void OnDisable()
	{
	}

	public void Open()
	{
	}

	public void ChooseOption(IRegionInfo region)
	{
	}

	public void Close()
	{
	}
}
