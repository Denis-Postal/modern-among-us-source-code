using System.Collections.Generic;
using UnityEngine;

public class ShapeshifterMinigame : Minigame
{
	public ShapeshifterPanel PanelPrefab;

	public float XStart;

	public float YStart;

	public float XOffset;

	public float YOffset;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	private List<ShapeshifterPanel> potentialVictims;

	public override void Begin(PlayerTask task)
	{
	}

	private void Shapeshift(PlayerControl target)
	{
	}

	private void OnDisable()
	{
	}
}
