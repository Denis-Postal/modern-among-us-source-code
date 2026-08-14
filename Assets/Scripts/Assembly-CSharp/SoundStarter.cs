using UnityEngine;

public class SoundStarter : MonoBehaviour
{
	public string Name;

	public AudioClip SoundToPlay;

	public bool StopAll;

	[Range(0f, 1f)]
	public float Volume;

	public void Awake()
	{
	}
}
