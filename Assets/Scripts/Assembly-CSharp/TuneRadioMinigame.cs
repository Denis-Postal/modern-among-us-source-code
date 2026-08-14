using UnityEngine;

public class TuneRadioMinigame : Minigame
{
	public RadioWaveBehaviour actualSignal;

	public DialBehaviour dial;

	public SpriteRenderer redLight;

	public SpriteRenderer greenLight;

	public float Tolerance;

	public float targetAngle;

	public bool finished;

	private float steadyTimer;

	public AudioClip StaticSound;

	public AudioClip RadioSound;

	public override void Begin(PlayerTask task)
	{
	}

	private void GetRadioVolume(AudioSource player, float dt)
	{
	}

	private void GetStaticVolume(AudioSource player, float dt)
	{
	}

	public void Update()
	{
	}

	private void FinishGame()
	{
	}

	public override void Close()
	{
	}
}
