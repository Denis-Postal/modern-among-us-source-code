using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SortSamplesMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoWaitBeforeClose_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SortSamplesMinigame _003C_003E4__this;

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
		public _003CCoWaitBeforeClose_003Ed__18(int _003C_003E1__state)
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
	private SortableSample[] sortableSamples;

	[SerializeField]
	private Collider2D mushroomJar;

	[SerializeField]
	private Transform mushroomJarDropSpot;

	[SerializeField]
	private Collider2D crystalJar;

	[SerializeField]
	private Transform crystalJarDropSpot;

	[SerializeField]
	private Transform hand;

	[SerializeField]
	private SpriteRenderer handOpenSprite;

	[SerializeField]
	private SpriteRenderer handClosedSprite;

	private readonly Controller controller;

	private SortableSample currentSample;

	private int samplesSorted;

	private bool IsComplete => false;

	public override bool SkipMultistageOverlayMenuSetup => false;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CCoWaitBeforeClose_003Ed__18))]
	private IEnumerator CoWaitBeforeClose()
	{
		return null;
	}

	private void OnInputMethodChanged()
	{
	}

	private void UpdateCursorVisibility()
	{
	}
}
