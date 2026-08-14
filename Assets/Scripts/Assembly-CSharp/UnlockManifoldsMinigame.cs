using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UnlockManifoldsMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CResetAll_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockManifoldsMinigame _003C_003E4__this;

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
		public _003CResetAll_003Ed__12(int _003C_003E1__state)
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

	public SpriteRenderer[] Buttons;

	public byte SystemId;

	private int buttonCounter;

	private bool animating;

	public AudioClip PressButtonSound;

	public AudioClip FailSound;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void HitButton(int idx)
	{
	}

	[IteratorStateMachine(typeof(_003CResetAll_003Ed__12))]
	private IEnumerator ResetAll()
	{
		return null;
	}
}
