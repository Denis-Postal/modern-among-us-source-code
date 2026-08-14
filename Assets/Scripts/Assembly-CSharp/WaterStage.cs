using UnityEngine;

public class WaterStage : Minigame
{
	public float RefuelDuration;

	public SpriteRenderer waterButton;

	public Sprite buttonDownSprite;

	public Sprite buttonUpSprite;

	public VerticalGauge srcGauge;

	public VerticalGauge destGauge;

	public AudioClip RefuelSound;

	private float timer;

	private bool isDown;

	private bool complete;

	public override void Begin(PlayerTask task)
	{
	}

	public void FixedUpdate()
	{
	}

	public void Refuel()
	{
	}

	private void GetRefuelDynamics(AudioSource player, float dt)
	{
	}

	public override void Close()
	{
	}
}
