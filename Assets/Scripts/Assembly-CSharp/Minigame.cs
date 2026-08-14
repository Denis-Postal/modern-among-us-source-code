using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class Minigame : MonoBehaviour
{
	protected enum CloseState
	{
		None = 0,
		Waiting = 1,
		Closing = 2
	}

	[CompilerGenerated]
	private sealed class _003CCoAnimateOpen_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigame _003C_003E4__this;

		private float _003Cdepth_003E5__2;

		private SpriteRenderer[] _003Crends_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CCoAnimateOpen_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CCoDestroySelf_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigame _003C_003E4__this;

		private SpriteRenderer[] _003Crends_003E5__2;

		private float _003Ctimer_003E5__3;

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
		public _003CCoDestroySelf_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CCoStartClose_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigame _003C_003E4__this;

		public float duration;

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
		public _003CCoStartClose_003Ed__31(int _003C_003E1__state)
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

	public static Minigame Instance;

	public const float Depth = -50f;

	public TransitionType TransType;

	public Vector2 TargetPosition;

	protected PlayerTask MyTask;

	protected NormalPlayerTask MyNormTask;

	protected CloseState amClosing;

	protected bool amOpening;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	[NonSerialized]
	public SpecialInputHandler inputHandler;

	private bool multistageMinigameChecked;

	private MultistageMinigame multistageMinigameParent;

	private readonly Logger logger;

	private float timeOpened;

	public TaskTypes TaskType => default(TaskTypes);

	public Console Console { get; set; }

	protected int ConsoleId => 0;

	public bool HasMultistageMinigameParent => false;

	public MultistageMinigame MultistageMinigameParent => null;

	public virtual bool SkipMultistageOverlayMenuSetup => false;

	public virtual void Begin(PlayerTask task)
	{
	}

	[IteratorStateMachine(typeof(_003CCoStartClose_003Ed__31))]
	protected IEnumerator CoStartClose(float duration = 0.75f)
	{
		return null;
	}

	[Obsolete("Don't use, I just don't want to reselect the close button event handlers", true)]
	public void Close(bool allowMovement)
	{
	}

	public void ForceClose()
	{
	}

	public virtual void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimateOpen_003Ed__35))]
	protected virtual IEnumerator CoAnimateOpen()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoDestroySelf_003Ed__36))]
	protected virtual IEnumerator CoDestroySelf()
	{
		return null;
	}

	public void SetupInput(bool disableCursor, bool suppressInGamePlayerList = false)
	{
	}

	private MultistageMinigame GetMultistageMinigameParentOnce()
	{
		return null;
	}
}
