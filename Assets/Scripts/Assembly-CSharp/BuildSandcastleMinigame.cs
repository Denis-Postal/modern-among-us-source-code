using Rewired;
using UnityEngine;

public class BuildSandcastleMinigame : Minigame
{
	private const float CLOSE_ENOUGH_TO_TOP = 0.8f;

	[Header("Timing")]
	[SerializeField]
	[Tooltip("The speed at which lifting with an analog stick moves towards the true lift value.")]
	private float liftLerpSpeed;

	[SerializeField]
	[Tooltip("The acceleration at which the bucket falls back down, per second. (Added to fallVelocity per second)")]
	private float fallGravity;

	[SerializeField]
	[Header("Lift Range")]
	private Transform startPosition;

	[SerializeField]
	private Transform endPosition;

	[SerializeField]
	[Header("Bucket")]
	private Collider2D bucketCollider;

	[SerializeField]
	private SpriteRenderer bucketSprite;

	[SerializeField]
	private SpriteRenderer bucketBackSprite;

	[SerializeField]
	private GameObject bucketGlyph;

	[Header("Sounds")]
	[SerializeField]
	private AudioClip grabSound;

	[SerializeField]
	private AudioClip completeSound;

	private readonly Controller controller;

	private Player player;

	private bool hasInput;

	private float fallVelocity;

	private float targetBucketY;

	private float trueBucketY;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void UpdateDefaultInput()
	{
	}

	private void UpdateJoystickInput()
	{
	}

	private void SetBucketY(float newValue, bool instant)
	{
	}

	private void UpdateBucketPosition()
	{
	}

	private void Success()
	{
	}
}
