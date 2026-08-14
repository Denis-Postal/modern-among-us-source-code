using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KillOverlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoShowOne_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverlayAnimation anim;

		public KillOverlay _003C_003E4__this;

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
		public _003CCoShowOne_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CShowAll_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay _003C_003E4__this;

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
		public _003CShowAll_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CWaitForFinish_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay _003C_003E4__this;

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
		public _003CWaitForFinish_003Ed__10(int _003C_003E1__state)
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

	public SpriteRenderer background;

	public GameObject flameParent;

	public OverlayKillAnimation[] KillAnims;

	public OverlayKillAnimation[] HorseWrangleAnims;

	public OverlayKillAnimation[] CustomKillAnimations;

	private Queue<Func<IEnumerator>> queue;

	private Coroutine showAll;

	private Coroutine showOne;

	public bool IsOpen => false;

	[IteratorStateMachine(typeof(_003CWaitForFinish_003Ed__10))]
	public IEnumerator WaitForFinish()
	{
		return null;
	}

	public void ShowKillAnimation(NetworkedPlayerInfo killer, NetworkedPlayerInfo victim)
	{
	}

	public void ShowKillAnimation(OverlayKillAnimation killAnimation, NetworkedPlayerInfo killer, NetworkedPlayerInfo victim)
	{
	}

	public void ShowKillAnimation(OverlayKillAnimation killAnimation, KillOverlayInitData initData)
	{
	}

	public void ShowMeeting(MeetingCalledAnimation prefab, NetworkedPlayerInfo.PlayerOutfit playerOutfit)
	{
	}

	[IteratorStateMachine(typeof(_003CShowAll_003Ed__15))]
	private IEnumerator ShowAll()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoShowOne_003Ed__16))]
	private IEnumerator CoShowOne(OverlayAnimation anim)
	{
		return null;
	}
}
