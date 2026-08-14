using UnityEngine;

public class FungleSunsetParallax : MonoBehaviour
{
	[SerializeField]
	private Transform content;

	[SerializeField]
	private Transform parallaxRoot;

	[SerializeField]
	private Vector2 parallaxMultiplier;

	private Transform camera;

	private Vector3 origin;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}
}
