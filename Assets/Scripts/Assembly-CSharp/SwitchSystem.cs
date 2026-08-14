using Hazel;

public class SwitchSystem : ISystemType, IActivatable
{
	public const byte MaxValue = byte.MaxValue;

	public const int NumSwitches = 5;

	public const byte DamageSystem = 128;

	public const byte SwitchesMask = 31;

	public float DetoriorationTime;

	public byte Value;

	private float timer;

	public byte ExpectedSwitches;

	public byte ActualSwitches;

	public bool IsDirty { get; private set; }

	public float Level => 0f;

	public bool IsActive => false;

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

	protected static bool HasTask<T>()
	{
		return false;
	}
}
