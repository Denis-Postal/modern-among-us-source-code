using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class CutVegetablesMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoCutVeggie_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CutVegetablesMinigame _003C_003E4__this;

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
		public _003CCoCutVeggie_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CCoMoveNextVegetableToCuttingBoard_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CutVegetablesMinigame _003C_003E4__this;

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
		public _003CCoMoveNextVegetableToCuttingBoard_003Ed__30(int _003C_003E1__state)
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

	private const float KNIFE_CUT_SPEED = 0.1f;

	[SerializeField]
	private CuttableVegetable[] cuttableVeggies;

	[SerializeField]
	private Transform startArea;

	[SerializeField]
	private PassiveButton startAreaButton;

	[SerializeField]
	private PassiveButton cuttingBoardButton;

	[SerializeField]
	private Transform cuttingBoard;

	[SerializeField]
	private Transform endArea;

	[SerializeField]
	private GameObject arrow;

	[SerializeField]
	[Header("Knife")]
	private SpriteRenderer knife;

	[SerializeField]
	private Sprite cuttingKnifeSprite;

	[SerializeField]
	private float knifeCutYOffset;

	[Header("Audio")]
	[SerializeField]
	private AudioClip getSfx;

	[SerializeField]
	private AudioClip finishSfx;

	[SerializeField]
	private AudioClip[] cutSfx;

	[SerializeField]
	[Header("Glyphs")]
	private GameObject selectGlyph;

	[SerializeField]
	private GameObject chopGlyph;

	private Player player;

	private bool selecting;

	private bool chopping;

	private readonly List<CuttableVegetable> veggies;

	private int numVeggiesCut;

	private CuttableVegetable CurrentVeggie => null;

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}

	private void SelectVegetable()
	{
	}

	private void ChopVegetable()
	{
	}

	private void SetSelectState()
	{
	}

	private void SetChopState()
	{
	}

	private void SetCompletedState()
	{
	}

	[IteratorStateMachine(typeof(_003CCoMoveNextVegetableToCuttingBoard_003Ed__30))]
	private IEnumerator CoMoveNextVegetableToCuttingBoard()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoCutVeggie_003Ed__31))]
	private IEnumerator CoCutVeggie()
	{
		return null;
	}
}
