using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpinAnimator : MonoBehaviour
{
	private enum States
	{
		Visible = 0,
		Invisible = 1,
		Spinning = 2,
		Pulsing = 3
	}

	[CompilerGenerated]
	private sealed class _003CCoDisappear_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinAnimator _003C_003E4__this;

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
		public _003CCoDisappear_003Ed__7(int _003C_003E1__state)
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

	public float Speed;

	public GameObject inputGlyph;

	private States curState;

	private void Update()
	{
	}

	public void Appear()
	{
	}

	public void Disappear()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDisappear_003Ed__7))]
	private IEnumerator CoDisappear()
	{
		return null;
	}

	public void StartPulse()
	{
	}

	internal void Play()
	{
	}
}
