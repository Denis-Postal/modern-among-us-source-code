using UnityEngine;

public class DynamicSound : ISoundPlayer
{
	public delegate void GetDynamicsFunction(AudioSource source, float dt);

	public GetDynamicsFunction volumeFunc;

	public string Name { get; set; }

	public AudioSource Player { get; set; }

	public void Update(float dt)
	{
	}

	public void SetTarget(AudioClip clip, GetDynamicsFunction volumeFunc)
	{
	}
}
