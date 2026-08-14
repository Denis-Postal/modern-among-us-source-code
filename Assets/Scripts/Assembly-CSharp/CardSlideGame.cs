using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CardSlideGame : Minigame
{
	private enum TaskStages
	{
		Before = 0,
		Animating = 1,
		Inserted = 2,
		After = 3
	}

	[CompilerGenerated]
	private sealed class _003CInsertCard_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardSlideGame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CInsertCard_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CPutCardBack_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardSlideGame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CPutCardBack_003Ed__23(int _003C_003E1__state)
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

	private FloatRange XRange;

	public FloatRange AcceptedTime;

	public Collider2D col;

	public SpriteRenderer redLight;

	public SpriteRenderer greenLight;

	public TextMeshPro StatusText;

	public AudioClip AcceptSound;

	public AudioClip DenySound;

	public AudioClip[] CardMove;

	public AudioClip WalletOut;

	public float dragTime;

	private bool moving;

	private TouchpadBehavior touchpad;

	private Vector2 prevStickInput;

	private float xPos;

	private bool hadPrev;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CPutCardBack_003Ed__23))]
	private IEnumerator PutCardBack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInsertCard_003Ed__24))]
	private IEnumerator InsertCard()
	{
		return null;
	}
}
