using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class RoastMarshmallowFireMinigame : Minigame
{
	private enum State
	{
		Waiting = 0,
		Placing = 1,
		Toasting = 2,
		Taking = 3,
		Removing_Fail = 4,
		Removing_Success = 5
	}

	private enum MarshmallowState
	{
		New = 0,
		Toasted = 1,
		Burnt = 2
	}

	[CompilerGenerated]
	private sealed class _003CCoPlacing_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoastMarshmallowFireMinigame _003C_003E4__this;

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
		public _003CCoPlacing_003Ed__41(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoTake_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoastMarshmallowFireMinigame _003C_003E4__this;

		public bool success;

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
		public _003CCoTake_003Ed__42(int _003C_003E1__state)
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

	public const int FIRE_CONSOLE_ID = 0;

	private const string BAG_TRIGGER_OUT = "OnOut";

	private const string BAG_TRIGGER_RESET = "OnReset";

	private const string STICK_TRIGGER_GET = "OnGet";

	private const string STICK_TRIGGER_TAKE = "OnTake";

	private const string STICK_TRIGGER_RESET = "OnReset";

	private const string MARSHMALLOW_INT_STATE = "State";

	private const string FIRE_BOOL_VISIBLE = "Visible";

	private const string FIRE_AMBIENCE_SFX = "MarshmallowFireAmbience";

	private static readonly Color MARSHMALLOW_TOASTED_COLOR_START;

	private static readonly Color MARSHMALLOW_TOASTED_COLOR_END;

	[Range(0.1f, 10f)]
	[SerializeField]
	[Header("Parameters")]
	private float timeToToasted;

	[SerializeField]
	[Range(0.1f, 10f)]
	private float timeToBurnt;

	[SerializeField]
	[Header("Animators")]
	private Animator fireAnimator;

	[SerializeField]
	private Animator bagAnimator;

	[SerializeField]
	private Animator stickAnimator;

	[SerializeField]
	private Animator marshmallowAnimator;

	[SerializeField]
	[Space(10f)]
	private SpriteRenderer toastedMarshmallow;

	[Header("Buttons")]
	[SerializeField]
	private PassiveButton bagMarshmallowButton;

	[SerializeField]
	private PassiveButton stickMarshmallowButton;

	[SerializeField]
	[Header("Audio")]
	private AudioClip sfxMarshmallowOnStick;

	[SerializeField]
	private AudioClip sfxMarshmallowDone;

	[SerializeField]
	private AudioClip sfxTooSoon;

	[SerializeField]
	private AudioClip sfxBurnt;

	[SerializeField]
	private AudioClip sfxFireAmbience;

	private Player player;

	private State state;

	private MarshmallowState marshmallowState;

	private float roastingStartTime;

	private float timeOfLastStateTransition;

	private void Awake()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void FireDynamics(AudioSource source, float dt)
	{
	}

	private void Update()
	{
	}

	private void SetState(State newState)
	{
	}

	private void SetMarshmallowState(MarshmallowState newMarshmallowState)
	{
	}

	private void SetToastedValue(float value)
	{
	}

	private void OnBagMarshmallowPressed()
	{
	}

	private void OnStickMarshmallowPressed()
	{
	}

	[IteratorStateMachine(typeof(_003CCoPlacing_003Ed__41))]
	private IEnumerator CoPlacing()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoTake_003Ed__42))]
	private IEnumerator CoTake(bool success)
	{
		return null;
	}

	public override void Close()
	{
	}
}
