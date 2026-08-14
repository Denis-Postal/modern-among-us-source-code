using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MushroomDoorSabotageMinigameMushroom : MonoBehaviour
{
	public enum State
	{
		None = 0,
		Visible = 1,
		Invisible = 2,
		Appearing = 3,
		Disappearing = 4,
		Whacked = 5
	}

	[CompilerGenerated]
	private sealed class _003CCoAnimateWhackMushroom_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MushroomDoorSabotageMinigameMushroom _003C_003E4__this;

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
		public _003CCoAnimateWhackMushroom_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CCoHideMushroom_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MushroomDoorSabotageMinigameMushroom _003C_003E4__this;

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
		public _003CCoHideMushroom_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CCoShowMushroom_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MushroomDoorSabotageMinigameMushroom _003C_003E4__this;

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
		public _003CCoShowMushroom_003Ed__20(int _003C_003E1__state)
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
	private SpriteRenderer sprite;

	[SerializeField]
	private ParticleSystem whackedEffect;

	[SerializeField]
	[Header("Audio")]
	private AudioClip mushroomAppearSFX;

	[SerializeField]
	private AudioClip mushroomDisappearSFX;

	[SerializeField]
	private AudioClip mushroomHitSFX;

	private float timeInState;

	public State CurrentState { get; private set; }

	public bool IsTimeInStateComplete => false;

	public event Action<MushroomDoorSabotageMinigameMushroom> OnClick
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

	private void Start()
	{
	}

	public void SetState(State state, float maxTimeInState)
	{
	}

	public void DeductTimeInState(float deltaTime)
	{
	}

	[IteratorStateMachine(typeof(_003CCoShowMushroom_003Ed__20))]
	private IEnumerator CoShowMushroom()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoHideMushroom_003Ed__21))]
	private IEnumerator CoHideMushroom()
	{
		return null;
	}

	private void OnMushroomClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimateWhackMushroom_003Ed__23))]
	private IEnumerator CoAnimateWhackMushroom()
	{
		return null;
	}
}
