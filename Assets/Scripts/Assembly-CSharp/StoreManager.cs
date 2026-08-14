using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing;

public class StoreManager : DestroyableSingleton<StoreManager>, IStoreListener
{
	[CompilerGenerated]
	private sealed class _003CCoWaitForHeadlessStarPurchaseValidation_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CompletionToken<PurchaseStates> queryDone;

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
		public _003CCoWaitForHeadlessStarPurchaseValidation_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CCoWaitForStarPurchaseValidation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CompletionToken<PurchaseStates> queryDone;

		public PurchaseButton button;

		public StoreManager _003C_003E4__this;

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
		public _003CCoWaitForStarPurchaseValidation_003Ed__16(int _003C_003E1__state)
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

	public CompletionToken<PurchaseStates> starPurchaseStateQuery;

	private Product[] allProducts;

	public bool FinishedInitializationFlow;

	private readonly Logger logger;

	private IStoreController controller;

	private IExtensionProvider extensions;

	private bool initialized;

	public void Initialize()
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	public void ProcessOldReceiptsRestore()
	{
	}

	public void ProcessOldReceipts()
	{
	}

	public void InitiateStorePurchaseStar(PurchaseButton button)
	{
	}

	private void InitiateStoreHeadlessStarPurchase(PurchaseEventArgs purchaseEventArgs)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		return default(PurchaseProcessingResult);
	}

	[IteratorStateMachine(typeof(_003CCoWaitForStarPurchaseValidation_003Ed__16))]
	private IEnumerator CoWaitForStarPurchaseValidation(CompletionToken<PurchaseStates> queryDone, PurchaseButton button)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoWaitForHeadlessStarPurchaseValidation_003Ed__17))]
	private IEnumerator CoWaitForHeadlessStarPurchaseValidation(CompletionToken<PurchaseStates> queryDone)
	{
		return null;
	}

	public void OnPurchaseFailed(Product i, PurchaseFailureReason error)
	{
	}
}
