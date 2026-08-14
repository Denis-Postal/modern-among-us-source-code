using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using UnityEngine;

public class MovingPlatformBehaviour : MonoBehaviour, ISystemType
{
	[CompilerGenerated]
	private sealed class _003CUsePlatform_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MovingPlatformBehaviour _003C_003E4__this;

		public PlayerControl target;

		private float _003CplatformTime_003E5__2;

		private float _003CtotalTime_003E5__3;

		private Vector3 _003CsourcePos_003E5__4;

		private Vector3 _003CtargetPos_003E5__5;

		private Vector3 _003CworldUseTargetPos_003E5__6;

		private Vector3 _003CworldSourcePos_003E5__7;

		private Vector3 _003CworldTargetPos_003E5__8;

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
		public _003CUsePlatform_003Ed__20(int _003C_003E1__state)
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

	public Vector3 LeftPosition;

	public Vector3 RightPosition;

	public Vector3 DisabledPosition;

	public Vector3 LeftUsePosition;

	public Vector3 RightUsePosition;

	public AudioClip MovingSound;

	private bool IsLeft;

	private PlayerControl Target;

	private byte useId;

	public bool InUse => false;

	public bool IsDirty { get; private set; }

	public void Use()
	{
	}

	public void Use(PlayerControl player)
	{
	}

	public void Start()
	{
	}

	private void SetSide(bool isLeft)
	{
	}

	private void SetTarget(uint playerNetId, bool isLeft)
	{
	}

	[IteratorStateMachine(typeof(_003CUsePlatform_003Ed__20))]
	private IEnumerator UsePlatform(PlayerControl target)
	{
		return null;
	}

	private void ResetPlatform()
	{
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	public void MeetingCalled()
	{
	}

	public void Deteriorate(float deltaTime)
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
}
