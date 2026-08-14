using System;
using System.Collections.Generic;
using Hazel;

public class ReactorSystemType : ISystemType, IActivatable, ICriticalSabotage
{
	private const float SyncRate = 2f;

	private float timer;

	public const byte StartCountdown = 128;

	public const byte AddUserOp = 64;

	public const byte RemoveUserOp = 32;

	public const byte ClearCountdown = 16;

	public const float CountdownStopped = 10000f;

	public readonly float ReactorDuration;

	public const byte ConsoleIdMask = 3;

	public const byte RequiredUserCount = 2;

	private HashSet<Tuple<byte, byte>> UserConsolePairs;

	private SystemTypes system;

	public float Countdown { get; private set; }

	public bool IsDirty { get; private set; }

	public int UserCount => 0;

	public bool IsActive => false;

	public ReactorSystemType(float duration, SystemTypes system)
	{
	}

	public bool GetConsoleComplete(int consoleId)
	{
		return false;
	}

	public void ClearSabotage()
	{
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	public void Deteriorate(float deltaTime)
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
