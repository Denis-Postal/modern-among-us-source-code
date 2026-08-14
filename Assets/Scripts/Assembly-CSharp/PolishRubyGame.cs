using UnityEngine;

public class PolishRubyGame : Minigame
{
	public PassiveButton[] Buttons;

	public SpriteRenderer[] Sparkles;

	public int[] swipes;

	public Vector2[] directions;

	public int swipesToClean;

	public AudioClip[] rubSounds;

	public AudioClip sparkleSound;

	public Transform cursorObject;

	public Transform handWipeObject;

	public SpriteRenderer[] handSprites;

	public BoxCollider2D rubyCursorBounds;

	private Controller cont;

	private bool oldCursorOverlapsSmudge;

	public void Start()
	{
	}

	private void UpdateSpriteColor(bool cursorOverlapsSmudge)
	{
	}

	public void PlaySparkleSound()
	{
	}

	public void Update()
	{
	}
}
