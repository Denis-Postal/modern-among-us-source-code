using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

internal class SteamPurchasingModule : IPurchasingModule, IStore
{
	[CompilerGenerated]
	private sealed class _003CWaitForPurchase_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamPurchasingModule _003C_003E4__this;

		public ProductDefinition product;

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
		public _003CWaitForPurchase_003Ed__14(int _003C_003E1__state)
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

	private const string Name = "Steam";

	private IStoreCallback storeCallback;

	private bool steamOverlayOpen;

	private uint steamAppId;

	private Callback<GameOverlayActivated_t> m_GameOverlayActivated;

	private CompletionToken<PurchaseStates> initializeQueryDone;

	private CompletionToken<PurchaseStates> finalizeQueryDone;

	public void Configure(IPurchasingBinder binder)
	{
	}

	public void FinishTransaction(ProductDefinition product, string transactionId)
	{
	}

	public void Initialize(IStoreCallback callback)
	{
	}

	public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
	{
	}

	private void HandleOverlayActivate(GameOverlayActivated_t param)
	{
	}

	public void Purchase(ProductDefinition product, string developerPayload)
	{
	}

	private void OnSteamMicroTxnAuth(MicroTxnAuthorizationResponse_t pCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForPurchase_003Ed__14))]
	private IEnumerator WaitForPurchase(ProductDefinition product)
	{
		return null;
	}
}
