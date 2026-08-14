using UnityEngine;

public class TowelMinigame : Minigame
{
	private FloatRange towelRange;

	public SpriteRenderer BasketGauge;

	public Collider2D BasketHitbox;

	public Collider2D[] Towels;

	private Controller controller;

	private int towelsDone;

	public AudioClip TowelGrab;

	public AudioClip TowelLand;

	public Transform interactionCursor;

	public SpriteRenderer openHand;

	public SpriteRenderer holdingHand;

	public Vector2Range ValidArea;

	public float stickMoveSpeed;

	public float stickHeldSpeed;

	public float towelDragSpeed;

	private Collider2D[] overlapResults;

	private bool isHolding;

	private GameObject heldTowel;

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}
}
