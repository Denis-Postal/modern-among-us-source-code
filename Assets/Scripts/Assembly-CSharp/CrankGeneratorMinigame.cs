using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class CrankGeneratorMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CWaitComplete_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrankGeneratorMinigame _003C_003E4__this;

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
		public _003CWaitComplete_003Ed__24(int _003C_003E1__state)
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

	private static readonly string SHADER_Y_PERCENT;

	private static readonly string CRANK_MOTOR_SFX;

	[SerializeField]
	[Tooltip("Indicates how much spinning its needed to complete task")]
	private float targetProgress;

	[SerializeField]
	[Tooltip("How fast does machine loses power when not spinning")]
	private float progressDecay;

	[Tooltip("CrankAudioPlays targetprogress/lightbulbRate")]
	[SerializeField]
	private int crankAudioRate;

	[SerializeField]
	private SpriteRenderer powerBarSpriteRenderer;

	[SerializeField]
	private Collider2D crank;

	[SerializeField]
	private Transform checkpoint;

	[SerializeField]
	private SpriteRenderer lightbulb;

	[SerializeField]
	private SpriteRenderer miniLights;

	[SerializeField]
	private AudioClip[] turnAudioClips;

	[SerializeField]
	private AudioClip motorAudioClip;

	[Tooltip("Multiplier to make cranking easier/harder on gamepad")]
	private float gamepadAngleProgressMul;

	private readonly Controller controller;

	private Player gamepad;

	private Vector2? prevGamepadAngle;

	private float progress;

	private float currentAngle;

	private bool lightbulbEffect;

	private int crankAudioDiv;

	private AudioSource motorAudioSource;

	private List<AudioClip> randomAudioClips;

	private bool finishCrank;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitComplete_003Ed__24))]
	private IEnumerator WaitComplete()
	{
		return null;
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	private void UpdateGamepadInput()
	{
	}

	private void TurnOnLights()
	{
	}

	private AudioClip GetRandomNonRepeatSound()
	{
		return null;
	}
}
