using UnityEngine;

public class WaterWheelGame : Minigame
{
	public SpriteRenderer Wheel;

	public VerticalSpriteGauge WaterLevel;

	public SpriteRenderer Watertop;

	public int WheelScale;

	public AudioClip FillStart;

	public AudioClip FillLoop;

	public AudioClip WheelTurn;

	private TouchpadBehavior touchpad;

	private float Rate;

	private AudioSource fillSound;

	private Vector2 prevStickInput;

	private bool hadPrev;

	private bool grabbed;

	private float Water
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	public void Grab()
	{
	}

	public override void Close()
	{
	}
}
