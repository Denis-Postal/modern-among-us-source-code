using System.Collections.Generic;
using Hazel;

public class VentilationSystem : ISystemType
{
	public struct VentMoveInfo
	{
		public Operation Op;

		public byte VentId;

		public byte PlayerId;
	}

	public enum Operation
	{
		StartCleaning = 0,
		StopCleaning = 1,
		Enter = 2,
		Exit = 3,
		Move = 4,
		BootImpostors = 5
	}

	private const ushort OP_ID_START = 0;

	private readonly Dictionary<byte, SequenceBuffer<VentMoveInfo>> SeqBuffers;

	private readonly Dictionary<byte, byte> PlayersCleaningVents;

	private readonly Dictionary<byte, byte> PlayersInsideVents;

	private readonly HashSet<byte> ToRemove;

	public bool IsDirty { get; private set; }

	public static void Update(Operation op, int ventId)
	{
	}

	public void Deteriorate(float deltaTime)
	{
	}

	public bool IsVentCurrentlyBeingCleaned(int id)
	{
		return false;
	}

	public bool IsImpostorInsideVent(int ventId)
	{
		return false;
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	private void PerformVentOp(byte playerId, Operation op, byte ventId, SequenceBuffer<VentMoveInfo> seqBuffer)
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

	private void BootImpostorsFromVent(int ventId)
	{
	}

	private bool IsInvisiblePhantomOnVent(byte playerId)
	{
		return false;
	}

	private void BootImpostorFromVent(int ventId, byte playerId)
	{
	}

	private void UpdateVentArrows()
	{
	}
}
