using UnityEngine;

public class RefuelStage : Minigame
{
	public float RefuelDuration;

	private Color darkRed;

	private Color red;

	private Color green;

	public SpriteRenderer redLight;

	public SpriteRenderer greenLight;

	public VerticalGauge srcGauge;

	public VerticalGauge destGauge;

	public AudioClip RefuelSound;

	private float timer;

	private bool isDown;

	private bool complete;

	private bool usingController;

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
