using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class CollectableVegetable : MonoBehaviour
{
	public delegate void CollectableVegetableHandler(CollectableVegetable vegetable);

	[CompilerGenerated]
	private sealed class _003CCoCollect_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectableVegetable _003C_003E4__this;

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
		public _003CCoCollect_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CCoStretchUp_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectableVegetable _003C_003E4__this;

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
		public _003CCoStretchUp_003Ed__53(int _003C_003E1__state)
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

	private const string PULL_SFX_NAME = "_PULL_SFX";

	private const string VIBRATION_NAME = "CollectVegetableStretch";

	[SerializeField]
	[Header("Design")]
	private float secondsToHoldBeforeCollecting;

	[SerializeField]
	[Header("Vegetables")]
	private GameObject carrot;

	[SerializeField]
	private GameObject cauliflower;

	[SerializeField]
	private GameObject chard;

	[SerializeField]
	private GameObject curls;

	[SerializeField]
	[Header("Navigation")]
	private CollectableVegetable neighborUp;

	[SerializeField]
	private CollectableVegetable neighborDown;

	[SerializeField]
	private CollectableVegetable neighborLeft;

	[SerializeField]
	private CollectableVegetable neighborRight;

	[Header("Visuals")]
	[SerializeField]
	private GameObject vegetableContainer;

	[SerializeField]
	private Collider2D collider;

	[SerializeField]
	private GameObject selectionGlyph;

	[SerializeField]
	private GameObject selectionCursor;

	[SerializeField]
	[Header("Audio")]
	private AudioClip pullSfx;

	[SerializeField]
	private AudioClip[] pickSfx;

	private CollectVegetablesMinigame.Vegetable vegetableType;

	private GameObject currentVegetable;

	private readonly Controller controller;

	private Player player;

	private bool selected;

	private float stretchStartTime;

	private int veggieIndex;

	private bool stretching;

	private bool collected;

	private Coroutine shrinkCoroutine;

	public int Index => 0;

	public string SfxName => null;

	public event CollectableVegetableHandler OnTouchedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event CollectableVegetableHandler OnCollectedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event CollectableVegetableHandler OnNavigationEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void Initialize(CollectVegetablesMinigame.Vegetable vegetable, int index)
	{
	}

	public void SetSelection(bool isSelected)
	{
	}

	private GameObject GetVegetable(CollectVegetablesMinigame.Vegetable vegetableType)
	{
		return null;
	}

	private void UpdateSelectionCursor()
	{
	}

	private void OnInputMethodChanged()
	{
	}

	private void TryNavigate(CollectableVegetable neighbor)
	{
	}

	private void StartStretch()
	{
	}

	private void StopStretch()
	{
	}

	private void TryResetStretch()
	{
	}

	[IteratorStateMachine(typeof(_003CCoStretchUp_003Ed__53))]
	private IEnumerator CoStretchUp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoCollect_003Ed__54))]
	private IEnumerator CoCollect()
	{
		return null;
	}
}
