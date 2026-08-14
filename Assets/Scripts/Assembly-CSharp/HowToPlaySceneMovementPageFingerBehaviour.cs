using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HowToPlaySceneMovementPageFingerBehaviour : MonoBehaviour
{
	public static class Quadratic
	{
		public static float InOut(float k)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDoClick_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public HowToPlaySceneMovementPageFingerBehaviour _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CDoClick_003Ed__3(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CMoveTo_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HowToPlaySceneMovementPageFingerBehaviour _003C_003E4__this;

		public Vector2 target;

		public float duration;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CtargetPos_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CMoveTo_003Ed__7(int _003C_003E1__state)
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

	public SpriteRenderer Finger;

	public SpriteRenderer Click;

	public float liftedAngle;

	[IteratorStateMachine(typeof(_003CDoClick_003Ed__3))]
	public IEnumerator DoClick(float duration)
	{
		return null;
	}

	private void SetFingerAngle(float angle)
	{
	}

	public void ClickOff()
	{
	}

	public void ClickOn()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveTo_003Ed__7))]
	public IEnumerator MoveTo(Vector2 target, float duration)
	{
		return null;
	}
}
