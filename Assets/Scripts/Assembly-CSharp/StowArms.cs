using UnityEngine;

public class StowArms : Minigame
{
	public GameObject GunContent;

	public GameObject RifleContent;

	public Transform selectorObject;

	public GameObject[] selectorSubobjects;

	public SpriteRenderer[] handSprites;

	public AudioClip pickupGun;

	public AudioClip placeGun;

	public Collider2D[] GunColliders;

	public DragSlot[] GunsSlots;

	public AudioClip pickupRifle;

	public AudioClip placeRifle;

	public Collider2D[] RifleColliders;

	public DragSlot[] RifleSlots;

	private Controller cont;

	private Collider2D currentGrabbedObject;

	private Vector3 grabOffset;

	private AudioClip PickupSound => null;

	private AudioClip PlaceSound => null;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	private void DoUpdate(Collider2D[] colliders, DragSlot[] slots)
	{
	}

	private void CheckForWin(Collider2D[] colliders, DragSlot[] slots)
	{
	}
}
