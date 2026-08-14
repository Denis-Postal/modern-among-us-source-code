using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Asteroid : PoolableBehavior
{
	[CompilerGenerated]
	private sealed class _003CCoBreakApart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Asteroid _003C_003E4__this;

		private SpriteRenderer _003Crend_003E5__2;

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
		public _003CCoBreakApart_003Ed__12(int _003C_003E1__state)
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

	public Sprite[] AsteroidImages;

	public Sprite[] BrokenImages;

	private int imgIdx;

	public FloatRange MoveSpeed;

	public FloatRange RotateSpeed;

	public SpriteRenderer Explosion;

	public Vector3 TargetPosition { get; internal set; }

	public void FixedUpdate()
	{
	}

	public override void Reset()
	{
	}

	[IteratorStateMachine(typeof(_003CCoBreakApart_003Ed__12))]
	public IEnumerator CoBreakApart()
	{
		return null;
	}
}
