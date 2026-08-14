using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectSamplesMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoCollectSample_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectSamplesMinigame _003C_003E4__this;

		public CollectSamplesMinigameCollectableSample collectable;

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
		public _003CCoCollectSample_003Ed__16(int _003C_003E1__state)
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

	private const int SAMPLE_COUNT = 3;

	[SerializeField]
	private Transform[] spawnPoints;

	[SerializeField]
	private CollectSamplesMinigameCollectableSample[] collectableSamples;

	[SerializeField]
	private Transform hand;

	private Controller controller;

	private bool IsComplete => false;

	public override bool SkipMultistageOverlayMenuSetup => false;

	private int SamplesCollected
	{
		get
		{
			return 0;
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

	public override void Close()
	{
	}

	private void InitializeSaveState()
	{
	}

	[IteratorStateMachine(typeof(_003CCoCollectSample_003Ed__16))]
	private IEnumerator CoCollectSample(CollectSamplesMinigameCollectableSample collectable)
	{
		return null;
	}

	private void UpdateCursorVisibility()
	{
	}

	private void OnInputMethodChanged()
	{
	}
}
