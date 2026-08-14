using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class CookFishMinigame : Minigame
{
	private enum State
	{
		NotCooking = 0,
		CookingSide1 = 1,
		CookingSide2 = 2
	}

	[CompilerGenerated]
	private sealed class _003CCoWaitBeforeClosing_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CookFishMinigame _003C_003E4__this;

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
		public _003CCoWaitBeforeClosing_003Ed__22(int _003C_003E1__state)
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
	private float cookingTimeSeconds;

	[SerializeField]
	private CookableFish[] cookableFishes;

	[SerializeField]
	private FungleTimer timer;

	[SerializeField]
	private GameObject taskArrow;

	private Player gamepad;

	private bool checkForTimerDone;

	private int controllerFishIndex;

	[Header("Audio")]
	[SerializeField]
	private AudioClip onTimerDoneSfx;

	private State CurrentState
	{
		get
		{
			return default(State);
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void ControllerSelectFish()
	{
	}

	private void CheckControllerInput()
	{
	}

	private void SetupInitialFishStates()
	{
	}

	private void CheckIfCookingTimerComplete()
	{
	}

	private void CheckIfAllFishPlaced()
	{
	}

	private void CheckIfAllFishCookedOnSide1()
	{
	}

	private void CheckIfAllFishCookedOnSide2()
	{
	}

	private void BlockClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCoWaitBeforeClosing_003Ed__22))]
	private IEnumerator CoWaitBeforeClosing()
	{
		return null;
	}
}
