using System;
using System.Collections.Generic;
using Hazel;

internal class HqHudSystemType : ISystemType, IActivatable
{
	public enum Tags
	{
		DamageBit = 128,
		ActiveBit = 64,
		DeactiveBit = 32,
		FixBit = 16
	}

	public const byte TagMask = 240;

	public const byte IdMask = 15;

	private HashSet<Tuple<byte, byte>> ActiveConsoles;

	private HashSet<byte> CompletedConsoles;

	private const float ActiveTime = 10f;

	private float Timer;

	public int TargetNumber;

	public bool IsActive => false;

	public float NumComplete => 0f;

	public float PercentActive => 0f;

	public bool IsDirty { get; private set; }

	public void Deteriorate(float deltaTime)
	{
	}

	internal bool IsConsoleActive(int consoleId)
	{
		return false;
	}

	internal bool IsConsoleOkay(int consoleId)
	{
		return false;
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
