using UnityEngine;

public class DressUpMinigame : Minigame
{
	public SpriteRenderer DummyHat;

	public SpriteRenderer DummyAccessory;

	public SpriteRenderer DummyClothes;

	public SpriteRenderer ActualHat;

	public SpriteRenderer ActualAccessory;

	public SpriteRenderer ActualClothes;

	public DressUpCosmetic[] buttons;

	public Sprite[] Hats;

	public Sprite[] Accessories;

	public Sprite[] Clothes;

	public Collider2D hatHitbox;

	public Collider2D faceHitbox;

	public Collider2D bodyHitbox;

	public SpriteRenderer draggable;

	public AudioClip hatSound;

	public AudioClip faceSound;

	public AudioClip clothesSound;

	public AudioClip correctSound;

	public AudioClip incorrectSound;

	public AudioClip finishedSound;

	private Controller controller;

	public SpriteRenderer grabbyHand;

	public Transform cursorObject;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	public void SetHat(int i)
	{
	}

	public void SetAccessory(int i)
	{
	}

	public void SetClothes(int i)
	{
	}

	private void CheckOutfit()
	{
	}
}
