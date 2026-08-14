using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DoorCardSwipeGame : Minigame, IDoorMinigame
{
	private enum TaskStages
	{
		Before = 0,
		Animating = 1,
		Inserted = 2,
		After = 3
	}

	[CompilerGenerated]
	private sealed class _003CInsertCard_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DoorCardSwipeGame _003C_003E4__this;

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
		public _003CInsertCard_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CPutCardBack_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DoorCardSwipeGame _003C_003E4__this;

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
		public _003CPutCardBack_003Ed__22(int _003C_003E1__state)
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

	private Color gray;

	private Color green;

	private TaskStages State;

	private Controller myController;

	private FloatRange YRange;

	public float minAcceptedTime;

	public Collider2D col;

	public SpriteRenderer confirmSymbol;

	public Sprite AcceptSymbol;

	public Sprite RejectSymbol;

	public TextMeshPro StatusText;

	public AudioClip AcceptSound;

	public AudioClip DenySound;

	public AudioClip[] CardMove;

	public AudioClip WalletOut;

	public float dragTime;

	private bool moving;

	private Vector2 prevStickInput;

	private bool hadPrev;

	private OpenableDoor MyDoor;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CPutCardBack_003Ed__22))]
	private IEnumerator PutCardBack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInsertCard_003Ed__23))]
	private IEnumerator InsertCard()
	{
		return null;
	}

	public void SetDoor(OpenableDoor door)
	{
	}
}
