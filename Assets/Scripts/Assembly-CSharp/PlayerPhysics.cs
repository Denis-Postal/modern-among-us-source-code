using System.Collections;
using System.Linq;
using Hazel;
using InnerNet;
using UnityEngine;

public class PlayerPhysics : InnerNetObject
{
	private enum RpcCalls
	{
		EnterVent = 0,
		ExitVent = 1,
		ClimbLadder = 2,
		BootFromVent = 3,
		Pet = 4,
		CancelPet = 5
	}

	public AudioClip ImpostorDiscoveredSound;

	public PlayerAnimations Animations;

	[System.NonSerialized]
	public SpecialInputHandler inputHandler;

	public float Speed = 4.5f;

	public float GhostSpeed = 3f;

	private const float ClimbPositionTolerance = 0.0005f;

	private readonly Logger logger = new Logger(Logger.Category.Gameplay, "PlayerPhysics");

	private Rigidbody2D body;

	private PlayerControl myPlayer;

	private PlayerBodyTypes bodyType = PlayerBodyTypes.Normal;

	private Coroutine petCoroutine;

	private byte lastClimbLadderSid;

	public bool DoingCustomAnimation { get; private set; }

	public float TrueSpeed => Speed * SpeedMod;

	public float SpeedMod => GameManager.Instance != null && GameManager.Instance.LogicOptions != null ? GameManager.Instance.LogicOptions.GetPlayerSpeedMod(myPlayer) : 1f;

	private bool FlipX
	{
		get
		{
			return myPlayer != null && myPlayer.cosmetics != null && myPlayer.cosmetics.FlipX;
		}
		set
		{
			if (myPlayer != null && myPlayer.cosmetics != null)
			{
				myPlayer.cosmetics.SetFlipX(value);
			}
		}
	}

	public Vector2 Velocity => body != null ? body.velocity : Vector2.zero;

	public void Awake()
	{
		body = GetComponent<Rigidbody2D>();
		myPlayer = GetComponent<PlayerControl>();
		if (Animations == null)
		{
			Animations = GetComponent<PlayerAnimations>();
		}
		if (myPlayer != null && myPlayer.cosmetics != null)
		{
			SetBodyType(PlayerBodyTypes.Normal);
		}
	}

	public void EnableInterpolation()
	{
		if (body != null)
		{
			body.interpolation = RigidbodyInterpolation2D.Interpolate;
		}
	}

	public void SetBodyType(PlayerBodyTypes bodyType)
	{
		this.bodyType = bodyType;
		if (myPlayer == null)
		{
			myPlayer = GetComponent<PlayerControl>();
		}
		if (myPlayer != null && myPlayer.cosmetics != null)
		{
			myPlayer.cosmetics.SetBodyType(bodyType);
			if (Animations != null)
			{
				Animations.SetBodyType(bodyType, myPlayer.cosmetics.FlippedCosmeticOffset, myPlayer.cosmetics.NormalCosmeticOffset);
			}
			myPlayer.SetPlayerMaterialColors(GetComponentInChildren<SpriteRenderer>());
		}
	}

	private void FixedUpdate()
	{
		if (body == null || myPlayer == null)
		{
			Awake();
		}
		if (myPlayer == null || body == null)
		{
			return;
		}
		NetworkedPlayerInfo data = myPlayer.Data;
		bool amDead = data != null && data.IsDead;
		HandleAnimation(amDead);
		bool localOwner = IsLocalOwner();
		if (localOwner && myPlayer.CanMove && !DoingCustomAnimation)
		{
			SetNormalizedVelocity(GetMovementInput());
		}
		else if (!localOwner || !myPlayer.CanMove)
		{
			SetNormalizedVelocity(Vector2.zero);
		}
	}

	private bool IsLocalOwner()
	{
		if (AmOwner || myPlayer == PlayerControl.LocalPlayer)
		{
			return true;
		}
		return AmongUsClient.Instance != null && myPlayer != null && myPlayer.OwnerId == AmongUsClient.Instance.ClientId;
	}

	private Vector2 GetMovementInput()
	{
		Vector2 input = Vector2.zero;
		if (DestroyableSingleton<HudManager>.InstanceExists && DestroyableSingleton<HudManager>.Instance.joystick != null)
		{
			input = DestroyableSingleton<HudManager>.Instance.joystick.DeltaL;
		}
		if (input.sqrMagnitude < 0.0001f)
		{
			input.x = (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ? 1f : 0f) - (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ? 1f : 0f);
			input.y = (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ? 1f : 0f) - (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) ? 1f : 0f);
		}
		return input;
	}

	public Vector2 GetVelocity()
	{
		return Velocity;
	}

	public void SetNormalizedVelocity(Vector2 direction)
	{
		if (body == null)
		{
			body = GetComponent<Rigidbody2D>();
		}
		if (body == null)
		{
			return;
		}
		float speed = TrueSpeed;
		NetworkedPlayerInfo data = myPlayer != null ? myPlayer.Data : null;
		if (data != null && data.IsDead)
		{
			speed = GhostSpeed * SpeedMod;
		}
		if (direction.x < -0.01f)
		{
			FlipX = true;
		}
		else if (direction.x > 0.01f)
		{
			FlipX = false;
		}
		body.velocity = Vector2.ClampMagnitude(direction, 1f) * speed;
	}

	private void LateUpdate()
	{
		Vector3 position = transform.position;
		position.z = position.y / 1000f;
		transform.position = position;
	}

	public Vector3 Vec2ToPosition(Vector2 pos)
	{
		return new Vector3(pos.x, pos.y, pos.y / 1000f);
	}

	public void SetSkin(string skinId, int color)
	{
		if (myPlayer == null)
		{
			myPlayer = GetComponent<PlayerControl>();
		}
		if (myPlayer != null && myPlayer.cosmetics != null)
		{
			myPlayer.cosmetics.SetSkin(skinId, color);
		}
	}

	public void StartClimb(bool down)
	{
		FlipX = false;
		if (Animations != null)
		{
			Animations.PlayClimbAnimation(down);
		}
		if (myPlayer != null && myPlayer.cosmetics != null)
		{
			myPlayer.cosmetics.SetBodyCosmeticsVisible(false);
			myPlayer.cosmetics.SetPetVisible(false);
			myPlayer.cosmetics.AnimateClimb(down);
		}
	}

	private void ClimbLadder(Ladder source, byte climbLadderSid)
	{
		if (source == null || !SidGreaterThan(climbLadderSid, lastClimbLadderSid))
		{
			return;
		}
		lastClimbLadderSid = climbLadderSid;
		ResetMoveState();
		StartCoroutine(CoClimbLadder(source, climbLadderSid));
	}

	private void PetPet(Vector2 pos, Vector2 petPos)
	{
		CancelPet();
		petCoroutine = StartCoroutine(CoPet(pos, petPos));
	}

	private IEnumerator CoClimbLadder(Ladder source, byte climbLadderSid)
	{
		myPlayer.moveable = false;
		myPlayer.onLadder = true;
		if (myPlayer.NetTransform != null)
		{
			myPlayer.NetTransform.enabled = false;
			myPlayer.NetTransform.ClearPositionQueues();
		}
		myPlayer.SetKinematic(true);
		yield return WalkPlayerTo(source.transform.position, ClimbPositionTolerance);
		yield return new WaitForSeconds(0.1f);
		StartClimb(source.IsTop);
		if (Constants.ShouldPlaySfx() && PlayerControl.LocalPlayer == myPlayer && myPlayer.FootSteps != null)
		{
			myPlayer.FootSteps.clip = source.UseSound;
			myPlayer.FootSteps.loop = true;
			myPlayer.FootSteps.Play();
		}
		if (source.Destination != null)
		{
			yield return WalkPlayerTo(source.Destination.transform.position, 0.001f, source.IsTop ? 2f : 1f);
		}
		myPlayer.SetPetPosition(myPlayer.transform.position);
		yield return new WaitForSeconds(0.1f);
		ResetAnimState();
		if (myPlayer.cosmetics != null)
		{
			myPlayer.cosmetics.SetBodyCosmeticsVisible(true);
			myPlayer.cosmetics.SetPetVisible(true);
		}
		myPlayer.moveable = true;
		if (myPlayer.NetTransform != null)
		{
			myPlayer.NetTransform.enabled = true;
		}
		myPlayer.SetKinematic(false);
		myPlayer.onLadder = false;
	}

	public void ResetMoveState(bool stopCoroutines = true)
	{
		if (myPlayer == null)
		{
			myPlayer = GetComponent<PlayerControl>();
		}
		if (myPlayer == null)
		{
			return;
		}
		if (myPlayer.FootSteps != null)
		{
			myPlayer.FootSteps.Stop();
			myPlayer.FootSteps.loop = false;
		}
		if (body != null)
		{
			body.velocity = Vector2.zero;
		}
		if (stopCoroutines)
		{
			StopAllCoroutines();
		}
		CancelPet();
		DoingCustomAnimation = false;
		enabled = true;
		myPlayer.inVent = false;
		myPlayer.walkingToVent = false;
		myPlayer.petting = false;
		myPlayer.onLadder = false;
		myPlayer.Visible = true;
		if (myPlayer.NetTransform != null)
		{
			myPlayer.NetTransform.enabled = true;
		}
		myPlayer.SetKinematic(false);
	}

	public void ResetAnimState()
	{
		ResetMoveState(false);
		NetworkedPlayerInfo data = myPlayer != null ? myPlayer.Data : null;
		if (data != null && data.IsDead)
		{
			if (myPlayer.cosmetics != null)
			{
				myPlayer.cosmetics.SetGhost();
				myPlayer.cosmetics.SetBodyCosmeticsVisible(true);
			}
			Animations?.PlayGhostIdleAnimation();
			myPlayer.SetHatAndVisorAlpha(0.5f);
		}
		else
		{
			if (myPlayer.cosmetics != null)
			{
				myPlayer.cosmetics.AnimateSkinIdle();
				myPlayer.cosmetics.SetBodyCosmeticsVisible(true);
				myPlayer.cosmetics.Visible = true;
			}
			Animations?.PlayIdleAnimation();
			myPlayer.SetHatAndVisorAlpha(1f);
		}
	}

	private void HandleAnimation(bool amDead)
	{
		if (DoingCustomAnimation || Animations == null || Animations.IsPlayingSpawnAnimation() || Animations.IsPlayingAnyLadderAnimation())
		{
			return;
		}
		Vector2 velocity = Velocity;
		if (!amDead)
		{
			if (velocity.sqrMagnitude >= 0.05f)
			{
				if (!Animations.IsPlayingRunAnimation())
				{
					Animations.PlayRunAnimation();
					myPlayer.cosmetics?.AnimateSkinRun();
				}
				if (velocity.x < -0.01f)
				{
					FlipX = true;
				}
				else if (velocity.x > 0.01f)
				{
					FlipX = false;
				}
			}
			else if (Animations.IsPlayingRunAnimation() || Animations.IsPlayingSpawnAnimation() || !Animations.IsPlayingSomeAnimation())
			{
				myPlayer.cosmetics?.AnimateSkinIdle();
				Animations.PlayIdleAnimation();
				myPlayer.SetHatAndVisorAlpha(1f);
			}
		}
		else
		{
			myPlayer.cosmetics?.SetGhost();
			if (!Animations.IsPlayingGhostIdleAnimation() && !Animations.IsPlayingGuardianAngelIdleAnimation())
			{
				Animations.PlayGhostIdleAnimation();
				myPlayer.SetHatAndVisorAlpha(0.5f);
			}
			if (velocity.x < -0.01f)
			{
				FlipX = true;
			}
			else if (velocity.x > 0.01f)
			{
				FlipX = false;
			}
		}
	}

	public void AnimateCustom(AnimationClip anim)
	{
		StartCoroutine(CoAnimateCustom(anim));
	}

	private IEnumerator CoAnimateCustom(AnimationClip anim)
	{
		DoingCustomAnimation = true;
		SetNormalizedVelocity(Vector2.zero);
		if (Animations != null && anim != null)
		{
			yield return Animations.CoPlayCustomAnimation(anim);
		}
		DoingCustomAnimation = false;
		ResetAnimState();
	}

	public IEnumerator CoSpawnPlayer(LobbyBehaviour lobby)
	{
		if (lobby == null || lobby.SpawnPositions == null || lobby.SpawnPositions.Length == 0 || myPlayer == null)
		{
			yield break;
		}
		int spawnSeatId = myPlayer.PlayerId % lobby.SpawnPositions.Length;
		Vector3 spawnPos = Vec2ToPosition(lobby.SpawnPositions[spawnSeatId]);
		bool amFlipped = myPlayer.PlayerId > lobby.SpawnPositions.Length / 2;
		myPlayer.transform.position = spawnPos;
		myPlayer.Collider.enabled = false;
		myPlayer.moveable = false;
		myPlayer.cosmetics?.ToggleName(false);
		FlipX = amFlipped;
		if (SoundManager.Instance != null && lobby.SpawnSound != null)
		{
			AudioSource audioSource = SoundManager.Instance.PlaySound(lobby.SpawnSound, false, 0.75f);
			if (audioSource != null)
			{
				audioSource.volume = 0.75f;
			}
		}
		myPlayer.cosmetics?.SetBodyType(PlayerBodyTypes.Normal);
		myPlayer.cosmetics?.SetBodyCosmeticsVisible(true);
		myPlayer.cosmetics?.AnimateSkinIdle();
		if (Animations != null)
		{
			yield return Animations.CoPlaySpawnAnimation(amFlipped);
		}
		myPlayer.cosmetics?.SetBodyType(PlayerBodyTypes.Normal);
		myPlayer.cosmetics?.SetBodyCosmeticsVisible(true);
		transform.position = spawnPos + new Vector3(amFlipped ? -0.3f : 0.3f, -0.24f, 0f);
		ResetAnimState();
		Vector2 targetPos = (-(Vector2)spawnPos).normalized;
		yield return WalkPlayerTo((Vector2)spawnPos + targetPos);
		myPlayer.Collider.enabled = true;
		myPlayer.moveable = true;
		myPlayer.cosmetics?.ToggleName(true);
	}

	public void ExitAllVents()
	{
		ResetAnimState();
		myPlayer.moveable = true;
		if (ShipStatus.Instance != null && ShipStatus.Instance.AllVents != null)
		{
			for (int i = 0; i < ShipStatus.Instance.AllVents.Length; i++)
			{
				ShipStatus.Instance.AllVents[i]?.SetButtons(false);
			}
		}
	}

	private IEnumerator CoPet(Vector2 pos, Vector2 petPos)
	{
		myPlayer.petting = true;
		myPlayer.moveable = false;
		yield return WalkPlayerTo(pos);
		PetBehaviour pet = myPlayer.GetPet();
		if (pet != null)
		{
			pet.SetGettingPet(true, petPos);
			pet.StartPetAnim();
		}
		yield return new WaitForSeconds(2f);
		CancelPet();
	}

	private void CheckCancelPetting()
	{
		if (myPlayer != null && myPlayer.petting && Velocity.sqrMagnitude > 0.01f)
		{
			CancelPet();
		}
	}

	private void CancelPet()
	{
		if (petCoroutine != null)
		{
			StopCoroutine(petCoroutine);
			petCoroutine = null;
		}
		if (myPlayer != null)
		{
			myPlayer.petting = false;
			myPlayer.moveable = true;
			PetBehaviour pet = myPlayer.GetPet();
			if (pet != null)
			{
				pet.SetGettingPet(false, Vector2.zero);
				pet.SetIdleOrMourning();
			}
		}
	}

	private IEnumerator CoEnterVent(int id)
	{
		Vent vent = ShipStatus.Instance != null && ShipStatus.Instance.AllVents != null ? ShipStatus.Instance.AllVents.FirstOrDefault(v => v != null && v.Id == id) : Object.FindObjectsOfType<Vent>().FirstOrDefault(v => v.Id == id);
		if (vent == null)
		{
			yield break;
		}
		myPlayer.walkingToVent = true;
		myPlayer.moveable = false;
		yield return WalkPlayerTo(vent.transform.position);
		vent.EnterVent(myPlayer);
		myPlayer.cosmetics?.AnimateSkinEnterVent();
		if (Animations != null)
		{
			yield return Animations.CoPlayEnterVentAnimation(vent.NumFramesUntilPlayerDisappears);
		}
		myPlayer.Visible = false;
		myPlayer.inVent = true;
		myPlayer.walkingToVent = false;
	}

	private IEnumerator CoExitVent(int id)
	{
		Vent vent = ShipStatus.Instance != null && ShipStatus.Instance.AllVents != null ? ShipStatus.Instance.AllVents.FirstOrDefault(v => v != null && v.Id == id) : Object.FindObjectsOfType<Vent>().FirstOrDefault(v => v.Id == id);
		myPlayer.Visible = true;
		myPlayer.inVent = false;
		if (vent != null)
		{
			yield return vent.ExitVent(myPlayer);
		}
		myPlayer.cosmetics?.AnimateSkinExitVent();
		if (Animations != null)
		{
			yield return Animations.CoPlayExitVentAnimation();
		}
		ResetAnimState();
		myPlayer.moveable = true;
	}

	public IEnumerator WalkPlayerTo(Vector2 worldPos, float tolerance = 0.01f, float speedMul = 1f, bool ignoreColliderOffset = false)
	{
		if (!ignoreColliderOffset && myPlayer != null && myPlayer.Collider != null)
		{
			worldPos -= myPlayer.Collider.offset;
		}
		Rigidbody2D rigidBody = body != null ? body : GetComponent<Rigidbody2D>();
		Vector2 del = worldPos - (Vector2)transform.position;
		float timeout = Mathf.Clamp(del.magnitude / Mathf.Max(0.01f, Speed * speedMul) + 1f, 1f, 5f);
		float timer = 0f;
		float toleranceSqr = tolerance * tolerance;
		while (del.sqrMagnitude > toleranceSqr && timer < timeout)
		{
			float mag = Mathf.Clamp(del.magnitude * 2f, 0.05f, 1f);
			Vector2 velocity = mag * Speed * speedMul * del.normalized;
			rigidBody.velocity = velocity;
			if (rigidBody.isKinematic || !rigidBody.simulated)
			{
				Vector2 currentPosition = transform.position;
				transform.position = Vec2ToPosition(Vector2.MoveTowards(currentPosition, worldPos, velocity.magnitude * Time.deltaTime));
			}
			else
			{
				rigidBody.MovePosition(Vector2.MoveTowards(rigidBody.position, worldPos, velocity.magnitude * Time.deltaTime));
			}
			yield return null;
			timer += Time.deltaTime;
			if (rigidBody.velocity.magnitude < 0.005f && del.sqrMagnitude < 0.01f)
			{
				break;
			}
			del = worldPos - (Vector2)transform.position;
		}
		rigidBody.velocity = Vector2.zero;
	}

	public override void ClearOrDecrementDirt()
	{
		ClearDirtyBits();
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private void BootFromVent(int ventId)
	{
		StartCoroutine(CoExitVent(ventId));
	}

	public void RpcClimbLadder(Ladder source)
	{
		if (source == null || AmongUsClient.Instance == null)
		{
			return;
		}
		if (AmongUsClient.Instance.AmClient)
		{
			ClimbLadder(source, (byte)(lastClimbLadderSid + 1));
		}
		else
		{
			lastClimbLadderSid++;
		}
		MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(NetId, (byte)RpcCalls.ClimbLadder, SendOption.Reliable);
		writer.Write(source.Id);
		writer.Write(lastClimbLadderSid);
		AmongUsClient.Instance.FinishRpcImmediately(writer);
	}

	public void RpcEnterVent(int ventId)
	{
		if (AmongUsClient.Instance != null && AmongUsClient.Instance.AmClient)
		{
			StartCoroutine(CoEnterVent(ventId));
		}
		SendVentRpc(RpcCalls.EnterVent, ventId);
	}

	public void RpcExitVent(int ventId)
	{
		if (AmongUsClient.Instance != null && AmongUsClient.Instance.AmClient)
		{
			StartCoroutine(CoExitVent(ventId));
		}
		SendVentRpc(RpcCalls.ExitVent, ventId);
	}

	public void RpcBootFromVent(int ventId)
	{
		BootFromVent(ventId);
		SendVentRpc(RpcCalls.BootFromVent, ventId);
	}

	public void RpcPet(Vector2 pos, Vector2 petPos)
	{
		PetPet(pos, petPos);
		if (AmongUsClient.Instance == null)
		{
			return;
		}
		MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(NetId, (byte)RpcCalls.Pet, SendOption.Reliable);
		WriteVector2(writer, pos);
		WriteVector2(writer, petPos);
		AmongUsClient.Instance.FinishRpcImmediately(writer);
	}

	public void RpcCancelPet()
	{
		CancelPet();
		if (AmongUsClient.Instance == null)
		{
			return;
		}
		MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(NetId, (byte)RpcCalls.CancelPet, SendOption.Reliable);
		AmongUsClient.Instance.FinishRpcImmediately(writer);
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
		switch ((RpcCalls)callId)
		{
		case RpcCalls.EnterVent:
			StartCoroutine(CoEnterVent(reader.ReadPackedInt32()));
			break;
		case RpcCalls.ExitVent:
			StartCoroutine(CoExitVent(reader.ReadPackedInt32()));
			break;
		case RpcCalls.ClimbLadder:
			if (ShipStatus.Instance != null && ShipStatus.Instance.Ladders != null)
			{
				byte ladderId = reader.ReadByte();
				byte climbSid = reader.ReadByte();
				ClimbLadder(ShipStatus.Instance.Ladders.FirstOrDefault(l => l != null && l.Id == ladderId), climbSid);
			}
			break;
		case RpcCalls.BootFromVent:
			BootFromVent(reader.ReadPackedInt32());
			break;
		case RpcCalls.Pet:
			PetPet(ReadVector2(reader), ReadVector2(reader));
			break;
		case RpcCalls.CancelPet:
			CancelPet();
			break;
		}
	}

	private void SendVentRpc(RpcCalls call, int ventId)
	{
		if (AmongUsClient.Instance == null)
		{
			return;
		}
		MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(NetId, (byte)call, SendOption.Reliable);
		writer.WritePacked(ventId);
		AmongUsClient.Instance.FinishRpcImmediately(writer);
	}

	private static void WriteVector2(MessageWriter writer, Vector2 vector)
	{
		writer.Write(vector.x);
		writer.Write(vector.y);
	}

	private static Vector2 ReadVector2(MessageReader reader)
	{
		return new Vector2(reader.ReadSingle(), reader.ReadSingle());
	}

	private static bool SidGreaterThan(byte newSid, byte prevSid)
	{
		return newSid != prevSid && (byte)(newSid - prevSid) < 128;
	}
}
