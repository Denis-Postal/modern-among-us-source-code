using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScaleDownY_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public ProgressBar _003C_003E4__this;

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
		public _003CScaleDownY_003Ed__15(int _003C_003E1__state)
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

	private const float CurrentCapScale = 1f;

	public float Value;

	public float CapValue;

	public float MaxValue;

	public float maskScale;

	public SpriteRenderer Mask;

	[Header("Cap")]
	public SpriteRenderer cap;

	public SpriteRenderer capGlow;

	public float capScale;

	public float capGlowSizePadding;

	private float lastValue;

	private float lastCapDiff;

	public float GlowAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[IteratorStateMachine(typeof(_003CScaleDownY_003Ed__15))]
	public IEnumerator ScaleDownY(float duration)
	{
		return null;
	}

	public void ResetScale()
	{
	}

	private void Update()
	{
	}

	private void SetFillWidth(float xScale)
	{
	}

	private void SetCapWidth(float xScale)
	{
	}
}
