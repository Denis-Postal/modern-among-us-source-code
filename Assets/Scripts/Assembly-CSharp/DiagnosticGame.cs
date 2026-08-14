using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DiagnosticGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CBlinkButton_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiagnosticGame _003C_003E4__this;

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
		public _003CBlinkButton_003Ed__15(int _003C_003E1__state)
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

	public VerticalGauge Gauge;

	public SpriteRenderer StartButton;

	public float TimePerStep;

	public TextMeshPro Text;

	private int TargetNum;

	public SpriteRenderer[] Targets;

	private Color goodBarColor;

	public AudioClip StartSound;

	public AudioClip CorrectSound;

	public AudioClip TickSound;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private int lastPercent;

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	[IteratorStateMachine(typeof(_003CBlinkButton_003Ed__15))]
	private IEnumerator BlinkButton()
	{
		return null;
	}

	public void PickAnomaly(int num)
	{
	}

	public void StartDiagnostic()
	{
	}

	public void Update()
	{
	}
}
