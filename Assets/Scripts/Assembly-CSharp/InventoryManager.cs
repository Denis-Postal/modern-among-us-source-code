using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.InnerNet;
using Epic.OnlineServices.Inventory;
using Epic.OnlineServices.Platform;
using UnityEngine.Networking;

public class InventoryManager : DestroyableSingleton<InventoryManager>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public CompletionToken<ResponseState> validateSpecialItems;

		internal void _003CCheckForNewUnlockables_003Eb__8(ResponseState state, Response<ResponsePurchase> response)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckForNewUnlockables_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private List<CosmeticData>.Enumerator _003C_003E7__wrap1;

		private CosmeticData _003Cunlockable_003E5__3;

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
		public _003CCheckForNewUnlockables_003Ed__27(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoPurchaseItem_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryManager _003C_003E4__this;

		public string productId;

		public CurrencyTypes currency;

		public Action<ResponseState, Response<ResponsePurchase>> resultCallback;

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
		public _003CCoPurchaseItem_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CCoSteamPurchaseStars_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryManager _003C_003E4__this;

		public string requestEndpoint;

		public string requestJson;

		public CompletionToken<PurchaseStates> queryDone;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CCoSteamPurchaseStars_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CCoValidateReceipt_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string requestEndpoint;

		public string requestJson;

		public InventoryManager _003C_003E4__this;

		public CompletionToken<PurchaseStates> queryDone;

		public Action starPurchaseCallback;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CCoValidateReceipt_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CCoValidateTrustedReceipt_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] productIds;

		public InventoryManager _003C_003E4__this;

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
		public _003CCoValidateTrustedReceipt_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CCoWaitForRedemptionCompletion_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryManager _003C_003E4__this;

		public CompletionToken<PurchaseStates> completionToken;

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
		public _003CCoWaitForRedemptionCompletion_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CRequestPurchaseCo_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Request<RedeemCurrency> requestData;

		public InventoryManager _003C_003E4__this;

		public Action<ResponseState, Response<ResponsePurchase>> resultCallback;

		public string productId;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CRequestPurchaseCo_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CWaitForInventoryLoad_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryManager _003C_003E4__this;

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
		public _003CWaitForInventoryLoad_003Ed__36(int _003C_003E1__state)
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

	private InventoryInterface inventoryInterface;

	private const string InventoryName = "profile";

	private const string PlayerXpPath = "player/xp";

	private const string PlayerRequiredXpPath = "player/xp_required_for_next_level";

	private const string PlayerLevelPath = "player/level";

	private const string PodsFolder = "pods";

	private const string StarsPath = "stars/normal";

	private const string StarsSwitchPath = "stars/switch";

	private const string BeansPath = "beans/normal";

	public RedeemCosmeticPopup redeemPopup;

	private static readonly string[] AllItemContainers;

	private Dictionary<string, int> podCounts;

	private readonly Logger logger;

	private List<string> outsideStarPurchases;

	public UpdateState InventoryLoadState { get; private set; }

	public int UnusedBeans { get; set; }

	public int UnusedStars { get; private set; }

	public void RefreshAll(PlatformInterface platformInterface)
	{
	}

	private void OnInventoryOpenCallback(ref OnOpenCompleteCallbackInfo data)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckForNewUnlockables_003Ed__27))]
	private IEnumerator CheckForNewUnlockables()
	{
		return null;
	}

	private void CheckBeans(InventoryItem rootItem)
	{
	}

	private void CheckStars(InventoryItem rootItem)
	{
	}

	private void CheckExpAndLevel(InventoryItem rootItem)
	{
	}

	private void CheckPods(InventoryItem rootItem)
	{
	}

	private void CheckUnlockedItems(InventoryItem rootItem, string path)
	{
	}

	private bool TryFollowPath(InventoryItem rootHandle, string path, out InventoryItem targetHandle)
	{
		targetHandle = null;
		return false;
	}

	public int GetPodCount(string podType)
	{
		return 0;
	}

	public int ChangePodCount(string podType, int podDelta)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CWaitForInventoryLoad_003Ed__36))]
	public IEnumerator WaitForInventoryLoad()
	{
		return null;
	}

	private void ResetInventory()
	{
	}

	private void CheckEquipped()
	{
	}

	public void UpdateStarCount(int starsToAdd)
	{
	}

	public void AddOutsideStarPurchase(string starPurchase)
	{
	}

	[IteratorStateMachine(typeof(_003CCoPurchaseItem_003Ed__42))]
	public IEnumerator CoPurchaseItem(string productId, CurrencyTypes currency, Action<ResponseState, Response<ResponsePurchase>> resultCallback)
	{
		return null;
	}

	public void UnlockCubeItem(string productId, string cubeName, Action<ResponseState, Response<ResponsePurchase>> resultCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CRequestPurchaseCo_003Ed__44))]
	private IEnumerator RequestPurchaseCo(Request<RedeemCurrency> requestData, Action<ResponseState, Response<ResponsePurchase>> resultCallback, string productId)
	{
		return null;
	}

	public void ValidatePreviousReceipts()
	{
	}

	public void WaitForRedemptionCompletion(CompletionToken<PurchaseStates> completionToken)
	{
	}

	[IteratorStateMachine(typeof(_003CCoWaitForRedemptionCompletion_003Ed__47))]
	public IEnumerator CoWaitForRedemptionCompletion(CompletionToken<PurchaseStates> completionToken)
	{
		return null;
	}

	public void ValidateIapReceipt(string receiptData, CompletionToken<PurchaseStates> queryDone, Action starPurchaseCallback = null)
	{
	}

	public void ValidateIapReceipt(List<string> receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	public void ValidateDlcReceipt(string receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	public void ValidateDlcReceipt(List<string> receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	public void ValidateInnerslothReceipt(string receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	[IteratorStateMachine(typeof(_003CCoValidateTrustedReceipt_003Ed__53))]
	public IEnumerator CoValidateTrustedReceipt(string[] productIds, CompletionToken<PurchaseStates> queryDone)
	{
		return null;
	}

	private void ValidateReceiptCall(Request<ValidateReceiptBatch> requestData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	private void ValidateReceiptCall(Request<ValidateReceipt> requestData, CompletionToken<PurchaseStates> queryDone, Action starPurchaseCallback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CCoValidateReceipt_003Ed__56))]
	private IEnumerator CoValidateReceipt(string requestJson, string requestEndpoint, CompletionToken<PurchaseStates> queryDone, Action starPurchaseCallback = null)
	{
		return null;
	}

	public void InitSteamMicroTxn(Request<SteamTxnInit> initTxn, CompletionToken<PurchaseStates> queryDone)
	{
	}

	public void FinalizeSteamMicroTxn(Request<SteamTxnFin> finTxn, CompletionToken<PurchaseStates> queryDone)
	{
	}

	[IteratorStateMachine(typeof(_003CCoSteamPurchaseStars_003Ed__59))]
	private IEnumerator CoSteamPurchaseStars(string requestJson, string requestEndpoint, CompletionToken<PurchaseStates> queryDone)
	{
		return null;
	}
}
