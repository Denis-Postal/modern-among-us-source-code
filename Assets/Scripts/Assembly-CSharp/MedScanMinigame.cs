using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class MedScanMinigame : Minigame
{
	private enum PositionState
	{
		None = 0,
		WalkingToPad = 1,
		WalkingToOffset = 2
	}

	[CompilerGenerated]
	private sealed class _003CWalkToOffset_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MedScanMinigame _003C_003E4__this;

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
		public _003CWalkToOffset_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CWalkToPad_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MedScanMinigame _003C_003E4__this;

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
		public _003CWalkToPad_003Ed__16(int _003C_003E1__state)
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

	private const int SomeKindOfPrimeNumber = 7;

	private static readonly string[] BloodTypes;

	public TextMeshPro text;

	public TextMeshPro charStats;

	public HorizontalGauge gauge;

	private MedScanSystem medscan;

	public float ScanDuration;

	public float ScanTimer;

	private string completeString;

	public AudioClip ScanSound;

	public AudioClip TextSound;

	private Coroutine walking;

	private PositionState state;

	public override void Begin(PlayerTask task)
	{
	}

	[IteratorStateMachine(typeof(_003CWalkToOffset_003Ed__15))]
	private IEnumerator WalkToOffset()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWalkToPad_003Ed__16))]
	private IEnumerator WalkToPad()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	public override void Close()
	{
	}
}
