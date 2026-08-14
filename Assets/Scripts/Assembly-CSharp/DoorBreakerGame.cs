using UnityEngine;

public class DoorBreakerGame : Minigame, IDoorMinigame
{
	public OpenableDoor MyDoor;

	public SpriteRenderer[] Buttons;

	public AudioClip FlipSound;

	public void SetDoor(OpenableDoor door)
	{
	}

	public void Start()
	{
	}

	public void FlipSwitch(SpriteRenderer button)
	{
	}
}
