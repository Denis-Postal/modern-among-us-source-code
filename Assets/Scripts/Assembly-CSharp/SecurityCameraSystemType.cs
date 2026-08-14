using System.Collections.Generic;
using Hazel;

public class SecurityCameraSystemType : ISystemType
{
	public const byte IncrementOp = 1;

	public const byte DecrementOp = 2;

	private HashSet<byte> PlayersUsing;

	private HashSet<byte> ToRemove;

	public bool InUse => false;

	public bool IsDirty { get; private set; }

	public void Deteriorate(float deltaTime)
	{
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	private void UpdateCameras()
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
