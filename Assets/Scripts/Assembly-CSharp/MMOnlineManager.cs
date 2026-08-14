using System.Collections.Generic;
using UnityEngine;

public class MMOnlineManager : DestroyableSingleton<MMOnlineManager>
{
	public GameObject HelpMenu;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public bool IsControllerManagerSceneInit;

	public void Start()
	{
	}

	private void Update()
	{
	}
}
