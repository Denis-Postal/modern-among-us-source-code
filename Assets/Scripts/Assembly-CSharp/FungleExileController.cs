using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FungleExileController : ExileController
{
	[CompilerGenerated]
	private sealed class _003CAnimate_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FungleExileController _003C_003E4__this;

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
		public _003CAnimate_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CFadeBlackRaftAndPlayer_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FungleExileController _003C_003E4__this;

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
		public _003CFadeBlackRaftAndPlayer_003Ed__15(int _003C_003E1__state)
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

	private const float FADE_BLACK_PLAYER_DURATION = 1.5f;

	private const float WAIT_TIME_FADE_BLACK_RAFT = 1f;

	private const float WAIT_TIME_TEXT_START = 0.2f;

	private const float TEXT_ANIM_DURATION = 2f;

	private const float WAIT_TIME_FINISH_CUTSCENE = 2f;

	private const float WAIT_TIME_START_CUTSCENE = 0.5f;

	private const string BEACH_AMB = "ejection_beach_sfx";

	private const string FIRE_SFX = "ejection_fire_sfx";

	private const float VIBRATION_INTENSITY = 0.2f;

	[SerializeField]
	private SpriteRenderer raftSprite;

	[SerializeField]
	private GameObject raftAnimation;

	[SerializeField]
	private GameObject fire;

	[SerializeField]
	private AudioClip ambience;

	[SerializeField]
	private AudioClip fireSound;

	[IteratorStateMachine(typeof(_003CAnimate_003Ed__14))]
	protected override IEnumerator Animate()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeBlackRaftAndPlayer_003Ed__15))]
	private IEnumerator FadeBlackRaftAndPlayer()
	{
		return null;
	}
}
