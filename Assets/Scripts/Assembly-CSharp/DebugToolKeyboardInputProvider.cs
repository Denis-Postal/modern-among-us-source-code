using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.DebugTool;

public class DebugToolKeyboardInputProvider : IDebugToolInputProvider
{
	[CompilerGenerated]
	private sealed class _003CCoInitialize_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CCoInitialize_003Ed__3(int _003C_003E1__state)
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

	private const float VERTICAL_REPEAT_RATE = 0.25f;

	private float keyDownStartTime;

	private float keyUpStartTime;

	[IteratorStateMachine(typeof(_003CCoInitialize_003Ed__3))]
	public IEnumerator CoInitialize()
	{
		return null;
	}

	public bool GetToggle()
	{
		return false;
	}

	public bool GetCopy()
	{
		return false;
	}

	public bool GetClear()
	{
		return false;
	}

	public bool GetConfirm()
	{
		return false;
	}

	public bool GetCancel()
	{
		return false;
	}

	public bool GetPagePrevious()
	{
		return false;
	}

	public bool GetPageNext()
	{
		return false;
	}

	public bool GetSubPagePrevious()
	{
		return false;
	}

	public bool GetSubPageNext()
	{
		return false;
	}

	public bool GetNavLeft()
	{
		return false;
	}

	public bool GetNavRight()
	{
		return false;
	}

	public bool GetNavUp()
	{
		return false;
	}

	public bool GetNavDown()
	{
		return false;
	}
}
