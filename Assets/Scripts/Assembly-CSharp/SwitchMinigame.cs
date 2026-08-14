using UnityEngine;

public class SwitchMinigame : Minigame
{
	public Color OnColor;

	public Color OffColor;

	private ShipStatus ship;

	public SpriteRenderer[] switches;

	public SpriteRenderer[] lights;

	public RadioWaveBehaviour top;

	public HorizontalGauge middle;

	public FlatWaveBehaviour bottom;

	public AudioClip FlipSound;

	public Transform selectorHighlight;

	private int selectedIndex;

	private float selectorCooldown;

	private bool prevHadVerticalInput;

	public override void Begin(PlayerTask task)
	{
	}

	public void FixedUpdate()
	{
	}

	public void FlipSwitch(int switchIdx)
	{
	}
}
