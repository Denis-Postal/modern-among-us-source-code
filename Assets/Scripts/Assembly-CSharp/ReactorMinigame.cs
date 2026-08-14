using TMPro;
using UnityEngine;

public class ReactorMinigame : Minigame
{
	private Color bad;

	private Color good;

	private ReactorSystemType reactor;

	public TextMeshPro statusText;

	public SpriteRenderer hand;

	private FloatRange YSweep;

	public SpriteRenderer sweeper;

	public AudioClip HandSound;

	private bool isButtonDown;

	public override void Begin(PlayerTask task)
	{
	}

	public void ButtonDown()
	{
	}

	public void FixedUpdate()
	{
	}

	public override void Close()
	{
	}
}
