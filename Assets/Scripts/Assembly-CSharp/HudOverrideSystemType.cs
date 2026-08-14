using Hazel;

internal class HudOverrideSystemType : ISystemType, IActivatable
{
	public const byte DamageBit = 128;

	public const byte TaskMask = 127;

	public bool IsActive { get; private set; }

	public bool IsDirty { get; private set; }

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
}
