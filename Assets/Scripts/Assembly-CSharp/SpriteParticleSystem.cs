using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class SpriteParticleSystem : MonoBehaviour
{
	public Sprite sprite;

	public ParticleSystemRenderer ren;

	private MaterialPropertyBlock block;

	private void OnEnable()
	{
	}

	private void SetPropertyBlock()
	{
	}

	private void OnValidate()
	{
	}
}
