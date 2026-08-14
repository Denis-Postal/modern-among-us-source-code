using UnityEngine;

public class AmbientSoundPlayer : MonoBehaviour
{
	public AudioClip AmbientSound;

	public Collider2D[] HitAreas;

	public float MaxVolume;

	public float DistanceFallOff;

	public float FallOffRate;

	[SerializeField]
	private bool useMuffled;

	public void Start()
	{
	}

	private void Dynamics(AudioSource source, float dt)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
