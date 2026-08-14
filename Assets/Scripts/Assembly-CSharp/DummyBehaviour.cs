using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DummyBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoVote_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DummyBehaviour _003C_003E4__this;

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
		public _003CDoVote_003Ed__8(int _003C_003E1__state)
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

	public int PlayerIdToVoteFor;

	private PlayerControl myPlayer;

	private FloatRange voteTime;

	private bool voted;

	public PlayerControl Player => null;

	public void Start()
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CDoVote_003Ed__8))]
	private IEnumerator DoVote()
	{
		return null;
	}
}
