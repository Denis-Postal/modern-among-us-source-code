using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ProgressionScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimatePodsAndBeans_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressionScreen _003C_003E4__this;

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
		public _003CAnimatePodsAndBeans_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CAnimateXpAndLevelUp_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressionManager.XpGrantResult xpGainedResult;

		public ProgressionScreen _003C_003E4__this;

		private ulong _003CnewXpAmount_003E5__2;

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
		public _003CAnimateXpAndLevelUp_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CAnimateXpBarFill_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressionScreen _003C_003E4__this;

		public uint oldXpAmount;

		public ulong newXpAmount;

		private float _003CstartTime_003E5__2;

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
		public _003CAnimateXpBarFill_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CDoAnimations_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressionManager.XpGrantResult xpGainedResult;

		public ProgressionScreen _003C_003E4__this;

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
		public _003CDoAnimations_003Ed__14(int _003C_003E1__state)
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

	private const float TimeToFillSeconds = 0.5f;

	private const float TimeToGlowSeconds = 0.75f;

	public PoolablePlayer Player;

	[Header("Xp")]
	public AudioClip XpSound;

	public AudioClip LevelUpSound;

	public ProgressBar XpBar;

	public TextMeshPro XpEarnedNowText;

	public AnimationCurve XpEarnedNowCurve;

	public TextMeshPro LevelText;

	public Transform LevelCircle;

	public TextMeshPro FutureLevelText;

	[Header("Pods")]
	public CurrencyEarned PodsEarned;

	[Header("Beans")]
	public CurrencyEarned BeansEarned;

	public void Activate()
	{
	}

	[IteratorStateMachine(typeof(_003CDoAnimations_003Ed__14))]
	private IEnumerator DoAnimations(ProgressionManager.XpGrantResult xpGainedResult)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateXpAndLevelUp_003Ed__15))]
	private IEnumerator AnimateXpAndLevelUp(ProgressionManager.XpGrantResult xpGainedResult)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateXpBarFill_003Ed__16))]
	private IEnumerator AnimateXpBarFill(uint oldXpAmount, ulong newXpAmount)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimatePodsAndBeans_003Ed__17))]
	private IEnumerator AnimatePodsAndBeans()
	{
		return null;
	}
}
