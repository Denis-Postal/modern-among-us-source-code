public class AutoCloseDoor : PlainDoor
{
	private const float OpenDuration = 10f;

	private float OpenTime;

	public override void SetDoorway(bool open)
	{
	}

	public override bool DoUpdate(float dt)
	{
		return false;
	}
}
