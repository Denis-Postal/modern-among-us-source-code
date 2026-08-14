using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoastMarshmallowStickMinigame : Minigame
{
	private enum State
	{
		Ready = 0,
		Ending = 1,
		Ended = 2
	}

	[CompilerGenerated]
	private sealed class _003CCoComplete_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoastMarshmallowStickMinigame _003C_003E4__this;

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
		public _003CCoComplete_003Ed__14(int _003C_003E1__state)
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
	[Header("Stick Minigame")]
	private BoxCollider2D[] spawnRegions;

	[SerializeField]
	private Transform stickTransform;

	[SerializeField]
	private GameObject stickSprite;

	[SerializeField]
	private ParticleSystem stickParticles;

	[SerializeField]
	private Transform[] otherRandomObjects;

	[SerializeField]
	private PassiveButton stickButton;

	[SerializeField]
	private Transform hand;

	private State state;

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

	[IteratorStateMachine(typeof(_003CCoComplete_003Ed__14))]
	private IEnumerator CoComplete()
	{
		return null;
	}

	private void OnStickPressed()
	{
	}

	private void OnInputMethodChanged()
	{
	}

	private void UpdateCursorVisibility()
	{
	}
}
