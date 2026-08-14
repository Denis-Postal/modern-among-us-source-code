using System.Collections.Generic;
using Hazel;

public class MedScanSystem : ISystemType
{
	public const byte Request = 128;

	public const byte Release = 64;

	public const byte NumMask = 31;

	public const byte NoPlayer = byte.MaxValue;

	public List<byte> UsersList;

	public byte CurrentUser { get; private set; }

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
