using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EdgeTransition : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoClose_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EdgeTransition _003C_003E4__this;

		private Vector3 _003CsourcePos_003E5__2;

		private Vector3 _003CtargetPos_003E5__3;

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
		public _003CCoClose_003Ed__9(int _003C_003E1__state)
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
	private sealed class _003CCoOpen_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EdgeTransition _003C_003E4__this;

		private Vector3 _003CsourcePos_003E5__2;

		private Vector3 _003CtargetPos_003E5__3;

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
		public _003CCoOpen_003Ed__7(int _003C_003E1__state)
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

	public float Duration;

	public Vector3 OpenPosition;

	public Vector3 ClosedPosition;

	public AspectPosition.EdgeAlignments Alignment;

	public Button.ButtonClickedEvent OnClose;

	public void Awake()
	{
	}

	public void Open()
	{
	}

	[IteratorStateMachine(typeof(_003CCoOpen_003Ed__7))]
	private IEnumerator CoOpen()
	{
		return null;
	}

	public void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CCoClose_003Ed__9))]
	private IEnumerator CoClose()
	{
		return null;
	}
}
