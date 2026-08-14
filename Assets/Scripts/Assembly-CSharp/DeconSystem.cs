using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using UnityEngine;

public class DeconSystem : MonoBehaviour, ISystemType
{
	[Flags]
	public enum States : byte
	{
		Idle = 0,
		Enter = 1,
		Closed = 2,
		Exit = 4,
		HeadingUp = 8
	}

	[CompilerGenerated]
	private sealed class _003CCoRunSprayers_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DeconSystem _003C_003E4__this;

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
		public _003CCoRunSprayers_003Ed__25(int _003C_003E1__state)
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

	private const byte HeadUpCmd = 1;

	private const byte HeadDownCmd = 2;

	private const byte HeadUpInsideCmd = 3;

	private const byte HeadDownInsideCmd = 4;

	public SomeKindaDoor UpperDoor;

	public SomeKindaDoor LowerDoor;

	public float DoorOpenTime;

	public float DeconTime;

	public AudioClip SpraySound;

	public ParticleSystem[] Particles;

	public SystemTypes TargetSystem;

	private float timer;

	public Collider2D RoomArea;

	public DecontamNumController FloorText;

	private Coroutine sprayers;

	public States CurState { get; private set; }

	public bool IsDirty { get; private set; }

	public void Deteriorate(float dt)
	{
	}

	[IteratorStateMachine(typeof(_003CCoRunSprayers_003Ed__25))]
	private IEnumerator CoRunSprayers()
	{
		return null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	public void OpenDoor(bool upper)
	{
	}

	public void OpenFromInside(bool upper)
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

	private void UpdateDoorsViaState()
	{
	}
}
