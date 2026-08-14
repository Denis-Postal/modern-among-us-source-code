using System.Collections.Generic;
using Hazel;
using InnerNet;
using InnerNet.GizmoHelpers;
using UnityEngine;

[DisallowMultipleComponent]
public class CustomNetworkTransform : InnerNetObject
{
	private const float SEND_MOVEMENT_THRESHOLD = 0.0001f;

	private const float REPLAY_POSITION_THRESHOLD = 0.003f;

	private const float NEUTRAL_BAND_MODIFIER = 0.995f;

	private const float SMOOTHING_BAND_MODIFIER = 0.5f;

	private const float SMOOTHING_LERP_RATE = 3f;

	private const int QUEUE_LENGTH_FOR_SNAPPING = 12;

	private const int QUEUE_LENGTH_FOR_SECOND_SNAP = 14;

	private const int QUEUE_THRESHOLD_FOR_SMOOTHING = 5;

	private const int SNAP_TO_SEQUENCE_ID_BUFFER = 2;

	private PlayerControl myPlayer;

	private Rigidbody2D body;

	private Queue<Vector2> sendQueue;

	private Queue<Vector2> incomingPosQueue;

	[SerializeField]
	private float rubberbandModifier;

	[SerializeField]
	private float idealSpeed;

	private bool isPaused;

	private ushort lastSequenceId;

	private Vector2 lastPosition;

	private Vector2 lastPosSent;

	private Vector2? tempSnapPosition;

	private ITransformGhost debugPopPositions;

	private ITransformGhost debugTargetPositions;

	private ITransformGhost debugTruePositions;

	private INetTransformLogger debugNetLogger;

	private void Awake()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void OnEnable()
	{
	}

	public void SetPaused(bool isPaused)
	{
	}

	public void Halt()
	{
	}

	public void RpcSnapTo(Vector2 position)
	{
	}

	public void SnapTo(Vector2 position)
	{
	}

	public void ClearPositionQueues()
	{
	}

	private bool IsInMiddleOfAnimationThatMakesPlayerInvisible()
	{
		return false;
	}

	private void SnapTo(Vector2 position, ushort minSid)
	{
	}

	private void FixedUpdate()
	{
	}

	private bool HasMoved()
	{
		return false;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	public override void ClearOrDecrementDirt()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private void MoveTowardNextPoint()
	{
	}

	private void SkipExcessiveFrames()
	{
	}

	private bool ShouldExtendCurrentFrame(Vector2 nextPos, Vector2 currentPos)
	{
		return false;
	}

	private bool DidPassPosition(Vector2 nextPos, Vector2 lastPos, Vector2 currentPos)
	{
		return false;
	}

	private void SetMovementSmoothingModifier()
	{
	}
}
