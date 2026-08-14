using System.Collections.Generic;
using UnityEngine;

public class MultistageMinigame : Minigame
{
	[Header("Multistage Minigame")]
	public Minigame[] Stages;

	private Minigame stage;

	private bool hasOverlayMenu;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public List<UiElement> ControllerSelectable;

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}
}
