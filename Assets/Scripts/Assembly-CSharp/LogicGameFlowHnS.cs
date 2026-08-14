using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using UnityEngine;

public class LogicGameFlowHnS : LogicGameFlow
{
	[CompilerGenerated]
	private sealed class _003CBeepAlmostEverySecond_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LogicGameFlowHnS _003C_003E4__this;

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
		public _003CBeepAlmostEverySecond_003Ed__33(int _003C_003E1__state)
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

	private const int SECONDS_TO_BEEP = 10;

	private const float SECONDS_TO_SET_DIRTY = 1f;

	private readonly HideAndSeekManager hideAndSeekManager;

	private readonly HideAndSeekTimerBar timerBarPrefab;

	private HideAndSeekTimerBar timerBar;

	private float totalHideTime;

	private float currentHideTime;

	private float totalFinalHideTime;

	private float currentFinalHideTime;

	private float secondsSinceLastSetDirty;

	private Coroutine beepCoroutine;

	public float CurrentFinalHideTime => 0f;

	public float TotalFinalHideTime => 0f;

	public bool IsFinalCountdown => false;

	public LogicGameFlowHnS(HideAndSeekManager manager, HideAndSeekTimerBar timerBarPrefab)
		: base(null)
	{
	}

	public bool SeekerAdminMapEnabled(PlayerControl player)
	{
		return false;
	}

	public void OnTaskComplete(float timeDeduction)
	{
	}

	public override void OnGameStart()
	{
	}

	public float GetTotalRoundTime()
	{
		return 0f;
	}

	public float GetTotalTimeRemaining()
	{
		return 0f;
	}

	public float GetRoundTimeElapsed()
	{
		return 0f;
	}

	public override void OnGameEnd()
	{
	}

	public override void FixedUpdate()
	{
	}

	public override void OnDestroy()
	{
	}

	public override bool IsGameOverDueToDeath()
	{
		return false;
	}

	public override void CheckEndCriteria()
	{
	}

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}

	private void OnFinalCountdownTriggered()
	{
	}

	private void AdjustEscapeTimer(float timeDeduction, bool forceDirty)
	{
	}

	[IteratorStateMachine(typeof(_003CBeepAlmostEverySecond_003Ed__33))]
	private IEnumerator BeepAlmostEverySecond()
	{
		return null;
	}

	private void AdjustFinalEscapeTimer(float timeDeduction)
	{
	}

	private bool AllTimersExpired()
	{
		return false;
	}
}
