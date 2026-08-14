using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class PlayerPettingHand : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForPetAnimStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerPettingHand _003C_003E4__this;

		public PetBehaviour pet;

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
		public _003CWaitForPetAnimStart_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CWaitUntilFinishedPetting_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerPettingHand _003C_003E4__this;

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
		public _003CWaitUntilFinishedPetting_003Ed__8(int _003C_003E1__state)
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

	public SpriteRenderer HandSprite;

	public SpriteRenderer hearts;

	public SpriteAnim HandSpriteAnim;

	public AnimationClip PetClip;

	private const int PET_ANIMATION_START_FRAME = 6;

	private const float ZPOS_PETTING = 1E-05f;

	public void StartPet(PetBehaviour pet)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForPetAnimStart_003Ed__7))]
	public IEnumerator WaitForPetAnimStart(PetBehaviour pet)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitUntilFinishedPetting_003Ed__8))]
	public IEnumerator WaitUntilFinishedPetting()
	{
		return null;
	}

	public void StopPetting()
	{
	}

	public void SetAlpha(float alphaValue)
	{
	}
}
