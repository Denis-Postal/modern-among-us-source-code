using System.Collections.Generic;
using UnityEngine;

public class RaycastAmbientSoundPlayer : MonoBehaviour
{
	public AudioClip AmbientSound;

	public float AmbientVolume;

	public float AmbientMaxDist;

	public float HitModifier;

	public bool ShouldVibrate;

	public static List<RaycastAmbientSoundPlayer> players;

	public float ambientVolume;

	public float t;

	private RaycastHit2D[] volumeBuffer;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Start()
	{
	}

	private void GetAmbientSoundVolume(AudioSource player, float dt)
	{
	}
}
