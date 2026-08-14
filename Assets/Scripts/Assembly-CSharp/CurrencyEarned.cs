using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using TMPro;
using UnityEngine;

public class CurrencyEarned : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEnterWallet_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyEarned _003C_003E4__this;

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
		public _003CEnterWallet_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CShowAmount_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyEarned _003C_003E4__this;

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
		public _003CShowAmount_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CShowMultiplier_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrencyEarned _003C_003E4__this;

		private int _003CdesiredIndex_003E5__2;

		private float _003CtimeToSpin_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CShowMultiplier_003Ed__18(int _003C_003E1__state)
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

	private static readonly float[] PotentialMultipliers;

	public Sprite BeansIcon;

	public SpriteRenderer Icon;

	public TextMeshPro AmountEarnedNowText;

	public TextMeshPro WalletCountText;

	public TextMeshPro NameText;

	public GameObject MultiplierContainer;

	public TextMeshPro[] MultiplierTexts;

	public SpriteAnim Animator;

	public AnimationClip ShowAmountAnimation;

	public AnimationClip EnterWalletAnimation;

	public AudioClip ShowAmountSound;

	public AudioClip EnterWalletSound;

	public AudioClip MultiplierLoopSound;

	public AudioClip MultiplierEndSound;

	private ProgressionManager.CurrencyGrantResult grantResult;

	public void Initialize(ProgressionManager.CurrencyGrantResult grantResult)
	{
	}

	[IteratorStateMachine(typeof(_003CShowAmount_003Ed__17))]
	public IEnumerator ShowAmount()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowMultiplier_003Ed__18))]
	public IEnumerator ShowMultiplier()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnterWallet_003Ed__19))]
	public IEnumerator EnterWallet()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
