using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HowToPlaySceneMovementPage : AbstractHowToPlayScenePage
{
	[CompilerGenerated]
	private sealed class _003CDoUse_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HowToPlaySceneMovementPage _003C_003E4__this;

		public int idx;

		public int consoleid;

		private HowToPlaySceneMovementPagePlayerAnimator _003CmyPlayer_003E5__2;

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
		public _003CDoUse_003Ed__8(int _003C_003E1__state)
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
	private sealed class _003CRunPlayer_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HowToPlaySceneMovementPage _003C_003E4__this;

		public int idx;

		private HowToPlaySceneMovementPagePlayerAnimator _003CmyPlayer_003E5__2;

		private int _003Ci_003E5__3;

		private bool _003CwillInterrupt_003E5__4;

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
		public _003CRunPlayer_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CWaitForSeconds_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

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
		public _003CWaitForSeconds_003Ed__9(int _003C_003E1__state)
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

	public HowToPlaySceneMovementPagePlayerAnimator[] players;

	public HowToPlaySceneMovementPageDummyConsole[] Consoles;

	public Vector2[] WayPoints;

	public Camera backupCam;

	public void OnDrawGizmos()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CRunPlayer_003Ed__7))]
	private IEnumerator RunPlayer(int idx)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoUse_003Ed__8))]
	private IEnumerator DoUse(int idx, int consoleid)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForSeconds_003Ed__9))]
	public static IEnumerator WaitForSeconds(float duration)
	{
		return null;
	}
}
