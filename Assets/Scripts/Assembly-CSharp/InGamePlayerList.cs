using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InGamePlayerList : MonoBehaviour
{
	private enum ListState
	{
		Closed = 0,
		Open = 1,
		Opening = 2,
		Closing = 3
	}

	[CompilerGenerated]
	private sealed class _003CTransitionCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGamePlayerList _003C_003E4__this;

		public float targetValue;

		private float _003Cdir_003E5__2;

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
		public _003CTransitionCoroutine_003Ed__24(int _003C_003E1__state)
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

	public Vector3 offsetFromEdge;

	private float windowWidth;

	private Vector3 openPosition;

	private Vector3 closedPosition;

	public float openTime;

	public float buttonHeight;

	public ObjectPoolBehavior buttonPool;

	public ControllerNavMenu controllerNavMenu;

	public SpriteRenderer backgroundSprite;

	public SpriteRenderer backgroundSpriteMask;

	public GameObject ChatScreen;

	public ControllerButtonBehavior OpenChatButton;

	private ListState currentState;

	private float openLevel;

	public static InGamePlayerList instance;

	public bool IsActive => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshMenu()
	{
	}

	public void ToggleActive()
	{
	}

	public void SetActive(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CTransitionCoroutine_003Ed__24))]
	private IEnumerator TransitionCoroutine(float targetValue)
	{
		return null;
	}

	private void SetBackgroundMaskLayer(int maskLayer)
	{
	}

	private void PopulateButtons()
	{
	}
}
