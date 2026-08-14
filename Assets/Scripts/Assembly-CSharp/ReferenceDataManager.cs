using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ReferenceDataManager : DestroyableSingleton<ReferenceDataManager>
{
	[CompilerGenerated]
	private sealed class _003CInitialize_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReferenceDataManager _003C_003E4__this;

		private AsyncOperationHandle<ReferenceData> _003CrefDataHandle_003E5__2;

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
		public _003CInitialize_003Ed__7(int _003C_003E1__state)
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
	private AssetReference referenceDataAsset;

	[NonSerialized]
	public bool showLoadingBar;

	public Dictionary<StoreTab, string> StoreTabVersions;

	public ReferenceData Refdata { get; private set; }

	[IteratorStateMachine(typeof(_003CInitialize_003Ed__7))]
	public IEnumerator Initialize()
	{
		return null;
	}

	private void SetStoreVersions()
	{
	}

	public FeaturedItemGroup[] GetAllFeaturedItems()
	{
		return null;
	}

	public void GetCurrentFeaturedItems(out List<FeaturedItemGroup> groups)
	{
		groups = null;
	}
}
