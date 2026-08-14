using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TelescopeGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoBlinky_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TelescopeGame _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CCoBlinky_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CRunBlipSound_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TelescopeGame _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CRunBlipSound_003Ed__13(int _003C_003E1__state)
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

	private bool grabbed;

	public Transform Background;

	public SpriteRenderer ItemDisplay;

	public BoxCollider2D[] Items;

	private BoxCollider2D TargetItem;

	public BoxCollider2D Reticle;

	public SpriteRenderer ReticleImage;

	private Coroutine blinky;

	public AudioClip BlipSound;

	public FloatRange BlipDelay;

	private TouchpadBehavior touchpad;

	private Vector3 initialPos;

	public void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CRunBlipSound_003Ed__13))]
	private IEnumerator RunBlipSound()
	{
		return null;
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CCoBlinky_003Ed__15))]
	private IEnumerator CoBlinky()
	{
		return null;
	}

	public void Grab()
	{
	}
}
