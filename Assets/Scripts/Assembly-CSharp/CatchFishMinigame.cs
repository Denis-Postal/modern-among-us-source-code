using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CatchFishMinigame : Minigame
{
	private enum State
	{
		WaitingForFish = 0,
		FishOnHook = 1,
		FishEscaped = 2
	}

	[CompilerGenerated]
	private sealed class _003CCoAnimateCaughtFish_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoAnimateCaughtFish_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CCoBeginFishing_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoBeginFishing_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CCoBounceBauble_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

		public float bounciness;

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
		public _003CCoBounceBauble_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CCoFishEscapes_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoFishEscapes_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CCoMoveFishToBauble_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoMoveFishToBauble_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CCoMoveFishToLocation_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

		public float fishEndPosX;

		private float _003CfishStartPosX_003E5__2;

		private float _003CfishStartPosY_003E5__3;

		private AnimationCurve _003CmovementCurve_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003CCoMoveFishToLocation_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CCoPrepareToFish_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoPrepareToFish_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CCoPutAwayFishingRod_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoPutAwayFishingRod_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CCoUpdateProgress_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatchFishMinigame _003C_003E4__this;

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
		public _003CCoUpdateProgress_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CCoWaitForFishToBeReeledIn_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCoWaitForFishToBeReeledIn_003Ed__37(int _003C_003E1__state)
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

	public const int NUM_FISH_TO_CATCH = 3;

	public const int NUM_STEPS_IN_CATCHING_FISH = 2;

	private const float VIBRATION_INTENSITY = 0.7f;

	private const float SECONDS_TO_WAIT_FOR_FISH_TO_BE_CAUGHT = 5f;

	private const float LIGHTLY_BOBBING = 0.02f;

	private const float STRONGLY_BOBBING = 0.1f;

	[SerializeField]
	[Header("Fishing Rod")]
	private Transform fishingRod;

	[SerializeField]
	private SpriteRenderer fishingLine;

	[SerializeField]
	private Vector3 rodPutAwayPosition;

	[SerializeField]
	private FloatRange fishingRodXPositionRange;

	[SerializeField]
	private SpriteRenderer bauble;

	[SerializeField]
	[Header("Fish Swimming")]
	private SpriteRenderer currentFish;

	[SerializeField]
	private float[] startXPositions;

	[SerializeField]
	private FloatRange startYPositionRange;

	[SerializeField]
	private AnimationCurve[] fishMovementCurves;

	[SerializeField]
	private float totalSwimTime;

	[Header("Fish Caught")]
	[SerializeField]
	private SpriteRenderer[] fishCounters;

	[SerializeField]
	private Sprite[] fishCounterSprites;

	[SerializeField]
	private SpriteRenderer caughtFish;

	[SerializeField]
	private Transform alert;

	[SerializeField]
	private float caughtFishScale;

	[SerializeField]
	[Header("Audio")]
	private AudioClip onHookSfx;

	[SerializeField]
	private AudioClip onMissSfx;

	[SerializeField]
	private AudioClip onCatchSfx;

	private readonly Controller controller;

	private State currentState;

	private int numCaughtFish;

	private Coroutine bounceCoroutine;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private bool IsInputCatchFish()
	{
		return false;
	}

	private void SetCaughtFish(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CCoBeginFishing_003Ed__33))]
	private IEnumerator CoBeginFishing()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoPrepareToFish_003Ed__34))]
	private IEnumerator CoPrepareToFish()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoBounceBauble_003Ed__35))]
	private IEnumerator CoBounceBauble(float bounciness)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoMoveFishToBauble_003Ed__36))]
	private IEnumerator CoMoveFishToBauble()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoWaitForFishToBeReeledIn_003Ed__37))]
	private IEnumerator CoWaitForFishToBeReeledIn()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoFishEscapes_003Ed__38))]
	private IEnumerator CoFishEscapes()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoMoveFishToLocation_003Ed__39))]
	private IEnumerator CoMoveFishToLocation(float fishEndPosX)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoPutAwayFishingRod_003Ed__40))]
	private IEnumerator CoPutAwayFishingRod()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoAnimateCaughtFish_003Ed__41))]
	private IEnumerator CoAnimateCaughtFish()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoUpdateProgress_003Ed__42))]
	private IEnumerator CoUpdateProgress()
	{
		return null;
	}
}
