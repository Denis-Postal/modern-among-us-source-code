using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class IncubateEggMinigame : Minigame
{
	private enum State
	{
		Empty = 0,
		EggPlaced = 1,
		EggHatched = 2,
		Complete = 3
	}

	[CompilerGenerated]
	private sealed class _003CCoAnimateCritter_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IncubateEggMinigame _003C_003E4__this;

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
		public _003CCoAnimateCritter_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CCoHatchEgg_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IncubateEggMinigame _003C_003E4__this;

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
		public _003CCoHatchEgg_003Ed__32(int _003C_003E1__state)
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

	private const int STATE_INDEX = 1;

	[SerializeField]
	private PassiveButton incubatorButton;

	[SerializeField]
	private SpriteRenderer egg;

	[SerializeField]
	private float secondsToHatchEgg;

	[SerializeField]
	private GameObject incubatorLight;

	[SerializeField]
	[Header("Critter")]
	private SpriteRenderer critter;

	[SerializeField]
	private IncubateEggMinigameEmote happyEmote;

	[SerializeField]
	private IncubateEggMinigameEmote thirstyEmote;

	[SerializeField]
	private IncubateEggMinigameEmote hungryEmote;

	[SerializeField]
	[Header("Food")]
	private PassiveButton foodBowl;

	[SerializeField]
	private GameObject food;

	[SerializeField]
	private PassiveButton waterBottle;

	[SerializeField]
	private GameObject waterFull;

	[Header("Timer")]
	[SerializeField]
	private FungleTimer timer;

	[SerializeField]
	[Header("Glyphs")]
	private GameObject emptyGlyphs;

	[SerializeField]
	private GameObject hatchedGlyphs;

	[Header("Audio")]
	[SerializeField]
	private AudioClip foodPlacedSfx;

	[SerializeField]
	private AudioClip waterPlacedSfx;

	[SerializeField]
	private AudioClip eggPlacedSfx;

	[SerializeField]
	private AudioClip eggHatchSfx;

	[SerializeField]
	private AudioClip timerEndSfx;

	private Player player;

	private float lastEmoteTime;

	private State CurrentState
	{
		get
		{
			return default(State);
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	private void UpdateEmotes()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void PutEgg()
	{
	}

	private void SetEggPlaced()
	{
	}

	[IteratorStateMachine(typeof(_003CCoHatchEgg_003Ed__32))]
	private IEnumerator CoHatchEgg()
	{
		return null;
	}

	private void ActivateCritterFoodAndAnimate()
	{
	}

	private void FillFoodBowl()
	{
	}

	private void FillWaterBottle()
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimateCritter_003Ed__36))]
	private IEnumerator CoAnimateCritter()
	{
		return null;
	}
}
