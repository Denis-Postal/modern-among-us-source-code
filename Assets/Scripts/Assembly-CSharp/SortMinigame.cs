using UnityEngine;

public class SortMinigame : Minigame
{
	public SortGameObject[] Objects;

	public BoxCollider2D AnimalBox;

	public BoxCollider2D PlantBox;

	public BoxCollider2D MineralBox;

	public AudioClip[] PickUpSounds;

	public AudioClip[] DropSounds;

	private Controller myController;

	public Transform selectorObject;

	public SpriteRenderer selectorHand;

	private bool prevHadButton;

	private int currentlyGrabbedObject;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private bool CheckBox(SortGameObject obj, bool dropped)
	{
		return false;
	}
}
