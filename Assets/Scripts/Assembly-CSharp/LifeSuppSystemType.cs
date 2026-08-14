using System.Collections.Generic;
using Hazel;

public class LifeSuppSystemType : ISystemType, IActivatable
{
	private const float SyncRate = 2f;

	private float timer;

	public const byte StartCountdown = 128;

	public const byte AddUserOp = 64;

	public const byte ClearCountdown = 16;

	public const float CountdownStopped = 10000f;

	public readonly float LifeSuppDuration;

	public const byte ConsoleIdMask = 3;

	public const byte RequiredUserCount = 2;

	public float Countdown;

	private HashSet<int> CompletedConsoles;

	public bool IsDirty { get; private set; }

	public int UserCount => 0;

	public bool IsActive => false;

	public LifeSuppSystemType(float duration)
	{
	}

	public bool GetConsoleComplete(int consoleId)
	{
		return false;
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
