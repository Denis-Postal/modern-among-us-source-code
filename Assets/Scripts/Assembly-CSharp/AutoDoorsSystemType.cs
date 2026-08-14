using Hazel;

public class AutoDoorsSystemType : ISystemType, IActivatable, RunTimer, IDoorSystem
{
	private uint dirtyBits;

	private float initialCooldown;

	public bool IsActive => false;

	public bool IsDirty => false;

	public void Deteriorate(float deltaTime)
	{
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	public void MarkClean()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public void SetDoor(AutoOpenDoor door, bool open)
	{
	}

	public void CloseDoorsOfType(SystemTypes room)
	{
	}

	public float GetTimer(SystemTypes room)
	{
		return 0f;
	}

	public void SetInitialSabotageCooldown()
	{
	}
}
