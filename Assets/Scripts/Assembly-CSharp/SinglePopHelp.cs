using System.Collections.Generic;
using UnityEngine;

public class SinglePopHelp : MonoBehaviour
{
	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public bool GridNav;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}
}
