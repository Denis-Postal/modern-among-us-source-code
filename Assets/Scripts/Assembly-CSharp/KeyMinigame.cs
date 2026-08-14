using UnityEngine;

public class KeyMinigame : Minigame
{
	public KeySlotBehaviour[] Slots;

	private int keyState;

	public SpriteRenderer KeyImage;

	public Sprite normalImage;

	public Sprite insertImage;

	public BoxCollider2D key;

	private int targetSlotId;

	private Controller controller;

	public AudioClip KeyGrab;

	public AudioClip KeyInsert;

	public AudioClip KeyOpen;

	public AudioClip KeyTurn;

	private TouchpadBehavior touchpad;

	private Vector3 initialPos;

	private bool prevHadInput;

	private Vector2 prevInputDir;

	private float currentAngle;

	public GameObject moveKeyGlyph;

	public GameObject turnKeyGlyph;

	public void Start()
	{
	}

	public void Update()
	{
	}
}
