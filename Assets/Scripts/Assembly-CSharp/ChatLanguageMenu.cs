using System.Collections.Generic;
using UnityEngine;

public class ChatLanguageMenu : MonoBehaviour
{
	public CreateOptionsPicker Parent;

	public ObjectPoolBehavior ButtonPool;

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

	public void OnDisable()
	{
	}

	public void Open()
	{
	}

	public void ChooseOption(uint language)
	{
	}

	public void Close()
	{
	}
}
