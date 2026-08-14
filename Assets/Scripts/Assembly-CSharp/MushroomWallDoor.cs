using Hazel;
using UnityEngine;

public class MushroomWallDoor : OpenableDoor
{
	[SerializeField]
	private BoxCollider2D wallCollider;

	[SerializeField]
	private Collider2D shadowColl;

	[SerializeField]
	private Collider2D bottomColl;

	[SerializeField]
	private MushroomWallMushroom[] mushrooms;

	[SerializeField]
	private AudioClip openSound;

	[SerializeField]
	private AudioClip closeSound;

	private bool open;

	private bool allowAudio;

	public override bool IsOpen => false;

	private void Start()
	{
	}

	public override void SetDoorway(bool open)
	{
	}

	private void DoorDynamics(AudioSource source, float dt)
	{
	}

	public override void Serialize(MessageWriter writer)
	{
	}

	public override void Deserialize(MessageReader reader)
	{
	}

	public override bool DoUpdate(float deltaTime)
	{
		return false;
	}
}
