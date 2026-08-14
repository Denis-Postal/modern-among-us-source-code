using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NoisemakerFade : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoFade_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NoisemakerFade _003C_003E4__this;

		private float _003CtimeElapsed_003E5__2;

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
		public _003CCoFade_003Ed__5(int _003C_003E1__state)
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

	[SerializeField]
	private NoisemakerArrow noisemakerArrow;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Fade()
	{
	}

	[IteratorStateMachine(typeof(_003CCoFade_003Ed__5))]
	private IEnumerator CoFade()
	{
		return null;
	}
}
