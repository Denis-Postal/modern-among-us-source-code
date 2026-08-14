using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TransitionFade : DestroyableSingleton<TransitionFade>
{
	[CompilerGenerated]
	private sealed class _003CCoShow_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransitionFade _003C_003E4__this;

		public GameObject transitionFrom;

		public GameObject transitionTo;

		public Action callback;

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
		public _003CCoShow_003Ed__2(int _003C_003E1__state)
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

	public SpriteRenderer overlay;

	public void DoTransitionFade(GameObject transitionFrom, GameObject transitionTo, Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CCoShow_003Ed__2))]
	private IEnumerator CoShow(GameObject transitionFrom, GameObject transitionTo, Action callback)
	{
		return null;
	}
}
