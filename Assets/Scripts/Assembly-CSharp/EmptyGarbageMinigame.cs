using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmptyGarbageMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CAnimateObjects_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmptyGarbageMinigame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CAnimateObjects_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CPopObjects_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmptyGarbageMinigame _003C_003E4__this;

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
		public _003CPopObjects_003Ed__28(int _003C_003E1__state)
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

	private const float GrinderVolume = 0.8f;

	public FloatRange HandleRange;

	public Vector2Range SpawnRange;

	public Collider2D Blocker;

	public AreaEffector2D Popper;

	public Collider2D Handle;

	public SpriteRenderer Bars;

	public Transform VibratePivot;

	private Controller controller;

	private bool finished;

	public int NumObjects;

	private SpriteRenderer[] Objects;

	public SpriteRenderer[] GarbagePrefabs;

	public SpriteRenderer[] LeafPrefabs;

	public SpriteRenderer[] SpecialObjectPrefabs;

	public AudioClip LeverDown;

	public AudioClip LeverUp;

	public AudioClip GrinderStart;

	public AudioClip GrinderLoop;

	public AudioClip GrinderEnd;

	private TouchpadBehavior touchpad;

	private bool hadInput;

	private float leverInput;

	private Coroutine popCoroutine;

	private Coroutine animateCoroutine;

	public override void Begin(PlayerTask task)
	{
	}

	private void StopCoroutines()
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CPopObjects_003Ed__28))]
	private IEnumerator PopObjects()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateObjects_003Ed__29))]
	private IEnumerator AnimateObjects()
	{
		return null;
	}

	public override void Close()
	{
	}
}
