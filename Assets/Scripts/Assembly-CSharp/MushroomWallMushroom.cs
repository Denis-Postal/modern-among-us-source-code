using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class MushroomWallMushroom : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoHideAndThenDisableSprite_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MushroomWallMushroom _003C_003E4__this;

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
		public _003CCoHideAndThenDisableSprite_003Ed__7(int _003C_003E1__state)
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
	private SpriteAnim animator;

	[SerializeField]
	private SpriteRenderer sprite;

	[SerializeField]
	private AnimationClip showClip;

	[SerializeField]
	private AnimationClip hideClip;

	private Coroutine hideCoroutine;

	public void Show()
	{
	}

	public void Hide()
	{
	}

	[IteratorStateMachine(typeof(_003CCoHideAndThenDisableSprite_003Ed__7))]
	private IEnumerator CoHideAndThenDisableSprite()
	{
		return null;
	}
}
