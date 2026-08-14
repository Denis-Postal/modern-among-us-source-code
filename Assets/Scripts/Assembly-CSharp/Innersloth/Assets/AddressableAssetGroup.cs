using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Innersloth.Assets
{
	public class AddressableAssetGroup : AddressableAsset
	{
		[CompilerGenerated]
		private sealed class _003CCoLoadAsync_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AddressableAssetGroup _003C_003E4__this;

			public Action onFinished;

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
			public _003CCoLoadAsync_003Ed__15(int _003C_003E1__state)
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
		private sealed class _003CCoWaitUntilFinished_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AddressableAssetGroup _003C_003E4__this;

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
			public _003CCoWaitUntilFinished_003Ed__16(int _003C_003E1__state)
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

		public readonly CallbackResultGroup OnLoaded;

		private List<AddressableAsset> Assets;

		public AddressableAssetGroup()
		{
		}

		public AddressableAssetGroup(IEnumerable<AddressableAsset> assetList)
		{
		}

		~AddressableAssetGroup()
		{
		}

		public void Add(AddressableAsset asset)
		{
		}

		public void Add(IEnumerable<AddressableAsset> list)
		{
		}

		public AddressableAsset<T> AddReference<T>(AssetReference assetRef) where T : UnityEngine.Object
		{
			return null;
		}

		public AddressableAsset<T> GetFromReference<T>(AssetReference assetRef) where T : UnityEngine.Object
		{
			return null;
		}

		public AddressableAsset<T> GetFromReferenceRecur<T>(AssetReference assetRef) where T : UnityEngine.Object
		{
			return null;
		}

		public bool Remove(AddressableAsset asset)
		{
			return false;
		}

		public void Clear()
		{
		}

		public override AssetLoadState GetState()
		{
			return default(AssetLoadState);
		}

		public override void LoadAsync(Action onSuccessCb = null, Action onErrorcb = null, Action onFinishedcb = null)
		{
		}

		private void OnAssetLoadedInternal()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLoadAsync_003Ed__15))]
		public override IEnumerator CoLoadAsync(Action onFinished = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoWaitUntilFinished_003Ed__16))]
		public IEnumerator CoWaitUntilFinished()
		{
			return null;
		}

		public bool AnyAssetsLoading()
		{
			return false;
		}

		public int NumAssetsLoading()
		{
			return 0;
		}

		public bool AllAssetsLoaded()
		{
			return false;
		}

		public override void Unload()
		{
		}

		public override void Destroy()
		{
		}

		public List<AddressableAsset> GetAssets()
		{
			return null;
		}

		public override bool ReferenceEquals(AddressableAsset asset)
		{
			return false;
		}

		public override bool ReferenceEquals(AssetReference asset)
		{
			return false;
		}
	}
}
