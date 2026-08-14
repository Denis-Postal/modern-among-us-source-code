using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartFansMinigame : Minigame
{
	public TextMeshPro ActionText;

	public SpriteRenderer[] CodeIcons;

	public Sprite[] IconSprites;

	public AudioClip revealSound;

	public AudioClip cycleSound;

	public AudioClip completeSound;

	public PassiveButton mainCodeButton;

	public PassiveButton closeButton;

	public List<UiElement> codeButtons;

	public ControllerButtonBehavior enterCodeHotkey;

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	public void RevealCode()
	{
	}

	public void RotateImage(SpriteRenderer target)
	{
	}
}
