using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using UnityEngine;

public class LogicPingsHnS : GameLogicComponent
{
	[CompilerGenerated]
	private sealed class _003CSeekerPing_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LogicPingsHnS _003C_003E4__this;

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
		public _003CSeekerPing_003Ed__10(int _003C_003E1__state)
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

	private LogicOptionsHnS options;

	private LogicGameFlowHnS flow;

	private ObjectPoolBehavior pingPool;

	private Coroutine seekerPingCoroutine;

	public LogicPingsHnS(GameManager manager, ObjectPoolBehavior pool)
		: base(null)
	{
	}

	public override void OnGameStart()
	{
	}

	public override void OnGameEnd()
	{
	}

	private void DestroyPingCoroutine()
	{
	}

	private void SetPingsInactive()
	{
	}

	public override void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CSeekerPing_003Ed__10))]
	private IEnumerator SeekerPing()
	{
		return null;
	}

	public override void OnDestroy()
	{
	}

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}
}
