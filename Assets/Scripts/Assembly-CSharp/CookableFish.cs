using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CookableFish : MonoBehaviour
{
	public enum State
	{
		FishNotPlaced = 0,
		FishPlaced = 1,
		OtherSideCooking = 2,
		Finished = 3
	}

	[CompilerGenerated]
	private sealed class _003COnFlipFishSfx_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CookableFish _003C_003E4__this;

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
		public _003COnFlipFishSfx_003Ed__19(int _003C_003E1__state)
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
	private PassiveButton button;

	[SerializeField]
	private SpriteRenderer outline;

	[SerializeField]
	private SpriteRenderer cookingFish;

	[SerializeField]
	private Sprite rawFish;

	[SerializeField]
	private Sprite cookedFish;

	[SerializeField]
	private GameObject glyphActionGO;

	[Header("Audio")]
	[SerializeField]
	private AudioClip onGrillSfx;

	[SerializeField]
	private AudioClip onFlipSfx;

	[SerializeField]
	private AudioClip onFinishCookingSfx;

	private Action additionalOnClick;

	public State CurrentState { get; private set; }

	private void Awake()
	{
	}

	public void SetState(State newState)
	{
	}

	public void SetAdditionalOnClick(Action onClick)
	{
	}

	public void ClickFish()
	{
	}

	[IteratorStateMachine(typeof(_003COnFlipFishSfx_003Ed__19))]
	private IEnumerator OnFlipFishSfx()
	{
		return null;
	}

	public void SetControllerSelectedVisual(bool selected)
	{
	}

	public void BlockClick()
	{
	}
}
