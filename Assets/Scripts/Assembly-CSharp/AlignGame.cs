using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AlignGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public AlignGame _003C_003E4__this;

		public Color green;

		internal void _003CLockEngine_003Eb__0(float t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLockEngine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlignGame _003C_003E4__this;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

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
		public _003CLockEngine_003Ed__13(int _003C_003E1__state)
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

	private Controller myController;

	public FloatRange YRange;

	public AnimationCurve curve;

	public LineRenderer centerline;

	public LineRenderer[] guidelines;

	public SpriteRenderer engine;

	public Collider2D col;

	private float pulseTimer;

	private bool wasPushingJoystick;

	private float initialY;

	private TouchpadBehavior touchpad;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CLockEngine_003Ed__13))]
	private IEnumerator LockEngine()
	{
		return null;
	}

	public static float FromByte(byte b)
	{
		return 0f;
	}

	public static byte ToByte(float y)
	{
		return 0;
	}

	public static bool IsSuccess(byte b)
	{
		return false;
	}

	public static bool ShouldComplete(byte b)
	{
		return false;
	}
}
