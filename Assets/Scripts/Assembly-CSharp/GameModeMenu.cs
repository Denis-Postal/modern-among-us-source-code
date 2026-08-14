using System.Collections.Generic;
using AmongUs.GameOptions;
using UnityEngine;

public class GameModeMenu : MonoBehaviour
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

	public void ChooseOption(GameModes mode)
	{
	}

	public void Close()
	{
	}
}
