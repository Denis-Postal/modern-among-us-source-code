using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FindCritterEggMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoGetEgg_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindCritterEggMinigame _003C_003E4__this;

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
		public _003CCoGetEgg_003Ed__18(int _003C_003E1__state)
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

	[Header("Egg")]
	[SerializeField]
	private Transform[] spawnPoints;

	[SerializeField]
	private Transform egg;

	[SerializeField]
	private PassiveButton eggButton;

	[SerializeField]
	[Header("Leaves")]
	private EggCoveringLeaf[] leaves;

	[Header("Cursor")]
	[SerializeField]
	private Transform hand;

	[SerializeField]
	[Header("Audio")]
	private AudioClip eggGetSfx;

	[SerializeField]
	[Range(0f, 1f)]
	[Space(10f)]
	private float leafSfxPitchRange;

	[SerializeField]
	private AudioClip[] leafSfx;

	private Controller controller;

	private bool completed;

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

	private void OnInputMethodChanged()
	{
	}

	private void UpdateCursorVisibility()
	{
	}

	private void GetEgg()
	{
	}

	[IteratorStateMachine(typeof(_003CCoGetEgg_003Ed__18))]
	private IEnumerator CoGetEgg()
	{
		return null;
	}

	private void OnLeafCollected()
	{
	}
}
