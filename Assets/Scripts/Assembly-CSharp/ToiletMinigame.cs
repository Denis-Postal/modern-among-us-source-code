using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ToiletMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CFinish_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ToiletMinigame _003C_003E4__this;

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
		public _003CFinish_003Ed__19(int _003C_003E1__state)
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

	public SpriteRenderer Needle;

	public SpriteRenderer Pipes;

	public const float StickDown = -0.75f;

	public FloatRange StickRange;

	public Collider2D Stick;

	public SpriteRenderer Plunger;

	public Sprite PlungerUp;

	public Sprite PlungerDown;

	private float pressure;

	public Controller controller;

	public float lastY;

	public float plungeScale;

	public AudioClip flushSound;

	public AudioClip[] plungeSounds;

	private AudioSource plungerSource;

	private float controllerStickPos;

	private const float controllerPlungeSpeed = 30f;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CFinish_003Ed__19))]
	private IEnumerator Finish()
	{
		return null;
	}

	public override void Close()
	{
	}
}
