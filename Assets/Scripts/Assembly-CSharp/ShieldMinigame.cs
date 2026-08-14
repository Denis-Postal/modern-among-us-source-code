using UnityEngine;

public class ShieldMinigame : Minigame
{
	public Color OnColor;

	public Color OffColor;

	public SpriteRenderer[] Shields;

	public SpriteRenderer Gauge;

	private byte shields;

	public AudioClip ShieldOnSound;

	public AudioClip ShieldOffSound;

	public Transform selectedButtonHighlight;

	private Controller controller;

	private int oldSelectedIndex;

	public override void Begin(PlayerTask task)
	{
	}

	public void ToggleShield(int i)
	{
	}

	private void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateButtons()
	{
	}
}
