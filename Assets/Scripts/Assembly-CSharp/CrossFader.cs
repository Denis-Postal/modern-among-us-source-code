using UnityEngine;

public class CrossFader : ISoundPlayer
{
	public float MaxVolume;

	public AudioClip target;

	public float Duration;

	private float timer;

	private bool didSwitch;

	public string Name { get; set; }

	public AudioSource Player { get; set; }

	public void Update(float dt)
	{
	}

	public void SetTarget(AudioClip clip)
	{
	}
}
