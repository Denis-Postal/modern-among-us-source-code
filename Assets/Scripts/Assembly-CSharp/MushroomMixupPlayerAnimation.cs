using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class MushroomMixupPlayerAnimation : MonoBehaviour, IPlayerVisibleItem
{
	[CompilerGenerated]
	private sealed class _003CCoAnimateCloud_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MushroomMixupPlayerAnimation _003C_003E4__this;

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
		public _003CCoAnimateCloud_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CCoPlay_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MushroomMixupPlayerAnimation _003C_003E4__this;

		public IEnumerator doWhileAnimating;

		public Action doInsideCloud;

		private float _003CstartTime_003E5__2;

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
		public _003CCoPlay_003Ed__11(int _003C_003E1__state)
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

	private const float MIN_ANIMATION_DURATION_SECONDS = 1f;

	[SerializeField]
	private SpriteAnim spriteAnim;

	[SerializeField]
	private SpriteRenderer sprite;

	[SerializeField]
	private AnimationClip spawnAnimation;

	[SerializeField]
	private AnimationClip idleAnimation;

	[SerializeField]
	private AnimationClip despawnAnimation;

	private PlayerControl player;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void StartAnimation(IEnumerator doWhileAnimating, Action doInsideCloud)
	{
	}

	[IteratorStateMachine(typeof(_003CCoPlay_003Ed__11))]
	private IEnumerator CoPlay(IEnumerator doWhileAnimating, Action doInsideCloud)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoAnimateCloud_003Ed__12))]
	private IEnumerator CoAnimateCloud()
	{
		return null;
	}

	public void SetPlayer(PlayerControl player)
	{
	}
}
