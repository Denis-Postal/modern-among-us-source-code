using UnityEngine;

public class TriggeredSound : MonoBehaviour
{
	public AudioClip[] SoundToPlay;

	public FloatRange PitchRange;

	private AudioSource Player;

	public float MaxVolume;

	public float MaxDist;

	public float HitModifier;

	private RaycastHit2D[] volumeBuffer;

	public void Start()
	{
	}

	public void PlaySound()
	{
	}

	private void GetAmbientSoundVolume(AudioSource player)
	{
	}
}
