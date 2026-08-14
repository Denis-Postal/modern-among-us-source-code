using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SlideOpen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateClose_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideOpen _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CAnimateClose_003Ed__13(int _003C_003E1__state)
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
	private sealed class _003CAnimateOpen_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlideOpen _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CAnimateOpen_003Ed__14(int _003C_003E1__state)
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

	public float duration;

	public Button.ButtonClickedEvent OnClose;

	public Camera parentCam;

	public Vector3 openPosition;

	public Vector3 closedPosition;

	public bool isOpen;

	[SerializeField]
	private GameObject subMenu;

	private Vector3 computedClosedPosition;

	public void Awake()
	{
	}

	public void Toggle()
	{
	}

	public void Close()
	{
	}

	public void Open()
	{
	}

	private void AdjustPosition(float aspect)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateClose_003Ed__13))]
	private IEnumerator AnimateClose()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateOpen_003Ed__14))]
	private IEnumerator AnimateOpen()
	{
		return null;
	}

	private void SetPositionVector(Vector3 pos)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen)
	{
	}
}
