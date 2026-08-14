using System;
using System.Collections;
using Hazel;
using PowerTools;
using UnityEngine;

public class AutoOpenDoor : PlainDoor
{
	public const float CooldownDuration = 30f;

	private const float ClosedDuration = 10f;

	public float ClosedTimer;

	public float CooldownTimer;

	private float size;

	public override bool IsOpen => Open;

	protected override void Start()
	{
		base.Start();
		InitializeDoor();
	}

	private void Awake()
	{
		InitializeDoor();
	}

	private void InitializeDoor()
	{
		if (!myCollider)
		{
			myCollider = GetComponent<BoxCollider2D>();
		}
		if (!animator)
		{
			animator = GetComponent<SpriteAnim>();
		}
		if (!myCollider)
		{
			return;
		}
		Vector2 colliderSize = myCollider.size;
		size = colliderSize.x > colliderSize.y ? colliderSize.y : colliderSize.x;
		Open = myCollider.isTrigger;
		UpdateShadow();
		if ((bool)animator)
		{
			animator.Play(Open ? OpenDoorAnim : CloseDoorAnim, 1000f);
		}
	}

	public override void SetDoorway(bool open)
	{
		if (!open)
		{
			ClosedTimer = ClosedDuration;
			CooldownTimer = CooldownDuration;
		}
		Open = open;
		if ((bool)myCollider)
		{
			myCollider.isTrigger = open;
		}
		UpdateShadow();
		if ((bool)animator)
		{
			animator.Play(open ? OpenDoorAnim : CloseDoorAnim);
		}
		StopAllCoroutines();
		if (!open && (bool)myCollider)
		{
			Vector2 colliderSize = myCollider.size;
			StartCoroutine(CoCloseDoorway(colliderSize.x > colliderSize.y));
			PlayDoorSound(CloseSound);
		}
		else
		{
			PlayDoorSound(OpenSound);
		}
	}

	private void UpdateShadow()
	{
		if ((bool)shadowCollider)
		{
			shadowCollider.enabled = !Open;
		}
	}

	private IEnumerator CoCloseDoorway(bool isHorizontal)
	{
		if (!(bool)myCollider)
		{
			yield break;
		}
		Vector2 colliderSize = myCollider.size;
		float timer = 0f;
		while (timer < 0.1f)
		{
			timer += Time.deltaTime;
			if (isHorizontal)
			{
				colliderSize.y = Mathf.Lerp(0.0001f, size, timer / 0.1f);
			}
			else
			{
				colliderSize.x = Mathf.Lerp(0.0001f, size, timer / 0.1f);
			}
			myCollider.size = colliderSize;
			yield return null;
		}
	}

	private void PlayDoorSound(AudioClip clip)
	{
		if (!clip || !Constants.ShouldPlaySfx() || SoundManager.Instance == null)
		{
			return;
		}
		SoundManager.Instance.PlayDynamicSound(base.name, clip, false, DoorDynamics, null);
	}

	private void DoorDynamics(AudioSource source, float dt)
	{
		if (!PlayerControl.LocalPlayer)
		{
			source.volume = 0f;
			return;
		}
		Vector2 doorPosition = base.transform.position;
		Vector2 playerPosition = PlayerControl.LocalPlayer.GetTruePosition();
		float distance = Vector2.Distance(doorPosition, playerPosition);
		if (distance > 4f)
		{
			source.volume = 0f;
			return;
		}
		float targetVolume = 1f - distance / 4f;
		source.volume = Mathf.Lerp(source.volume, targetVolume, dt);
	}

	public override void Serialize(MessageWriter writer)
	{
		writer.Write(Open);
	}

	public override void Deserialize(MessageReader reader)
	{
		SetDoorway(reader.ReadBoolean());
	}

	public override bool DoUpdate(float dt)
	{
		CooldownTimer = Math.Max(CooldownTimer - dt, 0f);
		if (ClosedTimer > 0f)
		{
			ClosedTimer = Math.Max(ClosedTimer - dt, 0f);
			if (ClosedTimer == 0f)
			{
				SetDoorway(true);
				return true;
			}
		}
		return false;
	}
}
