using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EndGameNavigation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoJoinGame_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCoJoinGame_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CWaitWithTimeout_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> success;

		private float _003Ctimer_003E5__2;

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
		public _003CWaitWithTimeout_003Ed__11(int _003C_003E1__state)
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

	public ProgressionScreen ProgressionScreen;

	public EndGameManager EndGameManager;

	[Header("Buttons")]
	public GameObject ContinueButton;

	public SpriteRenderer PlayAgainButton;

	public SpriteRenderer ExitButton;

	public void ShowProgression()
	{
	}

	public void ShowDefaultNavigation()
	{
	}

	public void ShowNavigationToProgressionScreen()
	{
	}

	public void HideButtons()
	{
	}

	public void NextGame()
	{
	}

	public void Exit()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitWithTimeout_003Ed__11))]
	private static IEnumerator WaitWithTimeout(Func<bool> success)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoJoinGame_003Ed__12))]
	private IEnumerator CoJoinGame()
	{
		return null;
	}
}
