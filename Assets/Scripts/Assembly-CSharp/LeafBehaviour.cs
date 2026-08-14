using UnityEngine;

public class LeafBehaviour : MonoBehaviour
{
	public Sprite[] Images;

	public FloatRange SpinSpeed;

	public Vector2Range StartVel;

	public float AccelRate;

	[HideInInspector]
	public LeafMinigame Parent;

	public bool Held;

	private static RandomFill<Sprite> ImageFiller;

	[HideInInspector]
	public Rigidbody2D body;

	public void Start()
	{
	}

	public void FixedUpdate()
	{
	}
}
