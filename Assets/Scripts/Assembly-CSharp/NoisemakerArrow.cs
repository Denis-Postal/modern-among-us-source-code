using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NoisemakerArrow : ArrowBehaviour
{
	public delegate void OnFadeTrigger();

	[CompilerGenerated]
	private sealed class _003CWaitDisappear_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NoisemakerArrow _003C_003E4__this;

		private bool _003CfadeTriggered_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CWaitDisappear_003Ed__10(int _003C_003E1__state)
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

	public const float FadeLength = 1f;

	[SerializeField]
	private Transform pivot;

	private float duration;

	public event OnFadeTrigger onFadeTrigger
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void UpdatePosition()
	{
	}

	protected override void DistancedBehaviour(Vector2 vpPoint, Vector2 del, float delLen, Camera cam)
	{
	}

	public void SetDuration(float _duration)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitDisappear_003Ed__10))]
	private IEnumerator WaitDisappear()
	{
		return null;
	}
}
