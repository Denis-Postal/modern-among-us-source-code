using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class HowToPlaySceneMovementPagePlayerAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWalkPlayerTo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector2 worldPos;

		public HowToPlaySceneMovementPagePlayerAnimator _003C_003E4__this;

		public float tolerance;

		public bool relax;

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
		public _003CWalkPlayerTo_003Ed__13(int _003C_003E1__state)
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

	public float Speed;

	public VirtualJoystick joystick;

	public SpriteRenderer UseButton;

	public HowToPlaySceneMovementPageFingerBehaviour finger;

	public AnimationClip RunAnim;

	public AnimationClip IdleAnim;

	private Vector2 velocity;

	[HideInInspector]
	private SpriteAnim Animator;

	[HideInInspector]
	private SpriteRenderer rend;

	public int NearbyConsoles;

	private void Start()
	{
	}

	public void FixedUpdate()
	{
	}

	public void LateUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CWalkPlayerTo_003Ed__13))]
	public IEnumerator WalkPlayerTo(Vector2 worldPos, bool relax, float tolerance = 0.01f)
	{
		return null;
	}
}
