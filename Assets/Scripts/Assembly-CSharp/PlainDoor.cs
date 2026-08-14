using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using PowerTools;
using UnityEngine;

public class PlainDoor : OpenableDoor
{
	[CompilerGenerated]
	private sealed class _003CCoCloseDoorway_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlainDoor _003C_003E4__this;

		public bool isHort;

		private Vector2 _003Cs_003E5__2;

		private float _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCoCloseDoorway_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public bool Open;

	public BoxCollider2D myCollider;

	public Collider2D shadowCollider;

	public SpriteAnim animator;

	public AnimationClip OpenDoorAnim;

	public AnimationClip CloseDoorAnim;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	private float size;

	public override bool IsOpen => false;

	protected virtual void Start()
	{
	}

	public override void SetDoorway(bool open)
	{
	}

	private void UpdateShadow()
	{
	}

	[IteratorStateMachine(typeof(_003CCoCloseDoorway_003Ed__14))]
	private IEnumerator CoCloseDoorway(bool isHort)
	{
		return null;
	}

	private void DoorDynamics(AudioSource source, float dt)
	{
	}

	public override void Serialize(MessageWriter writer)
	{
	}

	public override void Deserialize(MessageReader reader)
	{
	}

	public override bool DoUpdate(float dt)
	{
		return false;
	}
}
