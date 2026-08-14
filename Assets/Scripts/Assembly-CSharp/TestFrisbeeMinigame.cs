using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using Rewired;
using UnityEngine;

public class TestFrisbeeMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoFinalAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TestFrisbeeMinigame _003C_003E4__this;

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
		public _003CCoFinalAnimation_003Ed__19(int _003C_003E1__state)
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

	[Header("Design Values")]
	[SerializeField]
	[Range(0.5f, 0.99f)]
	private float pickUpAnalogThresshold;

	[SerializeField]
	[Header("Components")]
	private PassiveButton stuckFrisbee;

	[SerializeField]
	private Collider2D throwableFrisbee;

	[SerializeField]
	private SpriteAnim sparkle;

	[SerializeField]
	private GameObject throwControllerGlyph;

	[SerializeField]
	[Tooltip("The number of seconds frisbee spends in the air after tossing, before it disappears")]
	private float totalSeconds;

	[SerializeField]
	private Transform finalFrisbeePosition;

	[SerializeField]
	[Header("Sounds")]
	private AudioClip grabSound;

	[SerializeField]
	private AudioClip throwSound;

	[SerializeField]
	private AudioClip twinkleSound;

	private readonly Controller controller;

	private Vector3 originalFrisbeePosition;

	private Vector3 throwStartPosition;

	private bool pickedUp;

	private bool thrown;

	private float time;

	private bool isCompleting;

	private Player player;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CCoFinalAnimation_003Ed__19))]
	private IEnumerator CoFinalAnimation()
	{
		return null;
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void PickUpFrisbee()
	{
	}

	private void ThrowFrisbee()
	{
	}

	[ContextMenu("Reset Frisbee Position")]
	private void ResetFrisbeePosition()
	{
	}
}
