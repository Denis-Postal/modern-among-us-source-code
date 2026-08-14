using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class HideAndSeekTimerBar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChunkCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HideAndSeekTimerBar _003C_003E4__this;

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
		public _003CChunkCoroutine_003Ed__13(int _003C_003E1__state)
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
	private TextMeshPro timeText;

	[SerializeField]
	private Transform timerBar;

	[SerializeField]
	private MeshRenderer timerBarRenderer;

	[SerializeField]
	private Transform chunkBar;

	private float targetBarSize;

	private bool freezeChunk;

	private Coroutine chunkCoroutine;

	private void Update()
	{
	}

	public void UpdateTimer(float time, float maxTime)
	{
	}

	public void StartFinalHide()
	{
	}

	public void TaskComplete()
	{
	}

	private void StartChunkCoroutine()
	{
	}

	private void StopChunkCoroutine()
	{
	}

	[IteratorStateMachine(typeof(_003CChunkCoroutine_003Ed__13))]
	private IEnumerator ChunkCoroutine()
	{
		return null;
	}
}
