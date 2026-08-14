using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class WeatherMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoDoAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherMinigame _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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
		public _003CCoDoAnimation_003Ed__12(int _003C_003E1__state)
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

	public float Duration;

	public HorizontalGauge destGauge1;

	public HorizontalGauge destGauge2;

	public HorizontalGauge destGauge3;

	public PassiveButton StartButton;

	public TextMeshPro EtaText;

	public AudioClip StartSound;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public override void Begin(PlayerTask task)
	{
	}

	private void OnDisable()
	{
	}

	public void StartStopFill()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDoAnimation_003Ed__12))]
	private IEnumerator CoDoAnimation()
	{
		return null;
	}

	public override void Close()
	{
	}
}
