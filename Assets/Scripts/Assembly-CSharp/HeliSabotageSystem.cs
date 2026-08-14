using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class HeliSabotageSystem : MonoBehaviour, ISystemType, ICriticalSabotage, IActivatable
{
	private struct ActiveConsoleData
	{
		public readonly byte PlayerId;

		public readonly byte ConsoleId;

		public ActiveConsoleData(byte playerId, byte consoleId)
		{
			PlayerId = 0;
			ConsoleId = 0;
		}
	}

	public enum Tags
	{
		DamageBit = 128,
		ActiveBit = 64,
		DeactiveBit = 32,
		FixBit = 16
	}

	public const float CountdownStopped = 10000f;

	public const byte TagMask = 240;

	public const byte IdMask = 15;

	public SpriteRenderer Helicopter;

	public AnimationCurve ScaleCurve;

	private const float CharlesDuration = 90f;

	private const float CodeActiveDuration = 10f;

	private const float SyncRate = 1f;

	private HashSet<ActiveConsoleData> ActiveConsoles;

	private HashSet<byte> CompletedConsoles;

	private float codeResetTimer;

	private float syncTimer;

	private bool wasActive;

	public float Countdown { get; private set; }

	public bool IsActive => false;

	public float PercentActive => 0f;

	public int TargetCode { get; private set; }

	public bool IsDirty { get; private set; }

	public int UserCount => 0;

	public void ClearSabotage()
	{
	}

	public void Deteriorate(float deltaTime)
	{
	}

	private void UpdateHeliSize()
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
