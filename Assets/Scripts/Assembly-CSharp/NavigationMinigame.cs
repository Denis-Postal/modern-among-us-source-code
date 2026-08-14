using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NavigationMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCompleteGame_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NavigationMinigame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private Color _003Cgreen_003E5__3;

		private Color32 _003Cyellow_003E5__4;

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
		public _003CCompleteGame_003Ed__11(int _003C_003E1__state)
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

	public MeshRenderer TwoAxisImage;

	public SpriteRenderer CrossHairImage;

	public Collider2D hitbox;

	private Controller myController;

	private Vector2 crossHair;

	private Vector2 half;

	private Vector2 initialPos;

	private TouchpadBehavior touchpad;

	private bool prevHadInput;

	public override void Begin(PlayerTask task)
	{
	}

	public void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CCompleteGame_003Ed__11))]
	private IEnumerator CompleteGame()
	{
		return null;
	}
}
