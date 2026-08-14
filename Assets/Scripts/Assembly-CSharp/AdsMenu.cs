using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class AdsMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRewardedAdCo_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdsMenu _003C_003E4__this;

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
		public _003CRewardedAdCo_003Ed__14(int _003C_003E1__state)
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
	private GameObject loadingObject;

	[SerializeField]
	private TransitionOpen adsPopUp;

	[SerializeField]
	private GameObject adButton;

	[SerializeField]
	private GameObject popUpContentPrompt;

	[SerializeField]
	private GameObject popUpContentSuccess;

	[SerializeField]
	private GameObject popUpContentError;

	[SerializeField]
	private TextMeshPro watchAdText;

	[SerializeField]
	private TextMeshPro rewardText;

	private readonly Logger logger;

	private bool waitingAdResponse;

	public void ClickAdButton()
	{
	}

	public void ClickAcceptButton()
	{
	}

	private void AdReadyCallback(bool isReady)
	{
	}

	private void RewardedAdCallback(bool gotReward)
	{
	}

	[IteratorStateMachine(typeof(_003CRewardedAdCo_003Ed__14))]
	private IEnumerator RewardedAdCo()
	{
		return null;
	}

	private void CloseAdPopUp()
	{
	}

	private void SetPopUpContent(int index)
	{
	}
}
