using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectVegetablesMinigame : Minigame
{
	public enum Vegetable
	{
		Carrot = 0,
		Cauliflower = 1,
		Chard = 2,
		Curls = 3
	}

	[CompilerGenerated]
	private sealed class _003CCoCheckAllVeggiesCollected_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectVegetablesMinigame _003C_003E4__this;

		public int veggieIndex;

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
		public _003CCoCheckAllVeggiesCollected_003Ed__12(int _003C_003E1__state)
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

	[SerializeField]
	[Header("Design")]
	private float navigationDelay;

	[SerializeField]
	[Header("Components")]
	private CollectableVegetable[] collectables;

	[SerializeField]
	private AudioClip selectionChangedSfx;

	private int selection;

	private int collected;

	private float lastNavigationTime;

	public override void Begin(PlayerTask task)
	{
	}

	private void OnVeggieTouched(CollectableVegetable vegetable)
	{
	}

	private void OnVeggieNavigation(CollectableVegetable vegetable)
	{
	}

	private void OnVeggieCollected(CollectableVegetable vegetable)
	{
	}

	private void SetSelection(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CCoCheckAllVeggiesCollected_003Ed__12))]
	private IEnumerator CoCheckAllVeggiesCollected(int veggieIndex)
	{
		return null;
	}
}
