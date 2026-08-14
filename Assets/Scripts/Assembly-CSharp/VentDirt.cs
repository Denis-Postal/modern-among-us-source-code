using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VentDirt : PoolableBehavior
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public SpriteRenderer rend;

		internal void _003CCoDisappear_003Eb__0(float t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoDisappear_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VentDirt _003C_003E4__this;

		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

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
		public _003CCoDisappear_003Ed__4(int _003C_003E1__state)
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

	public Sprite[] DirtImages;

	public ParticleSystem CleanedEffect;

	private int imgIdx;

	public override void Reset()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDisappear_003Ed__4))]
	public IEnumerator CoDisappear()
	{
		return null;
	}
}
