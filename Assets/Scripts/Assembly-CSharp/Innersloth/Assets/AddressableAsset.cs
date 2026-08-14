using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Innersloth.Assets
{
	public abstract class AddressableAsset : IDisposable, ISerializationCallbackReceiver
	{
		public enum AssetLoadState
		{
			Null = 0,
			Unloaded = 1,
			Loading = 2,
			Success = 3,
			Error = 4
		}

		protected static readonly Logger logger;

		void IDisposable.Dispose()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public bool IsLoading()
		{
			return false;
		}

		public bool IsCompleted()
		{
			return false;
		}

		public bool IsLoaded()
		{
			return false;
		}

		protected virtual void OnSerialize()
		{
		}

		protected virtual void OnDeserialize()
		{
		}

		public abstract AssetLoadState GetState();

		public abstract void LoadAsync(Action onSuccessCb = null, Action onErrorcb = null, Action onFinishedcb = null);

		public abstract IEnumerator CoLoadAsync(Action onFinished = null);

		public abstract void Unload();

		public abstract void Destroy();

		public abstract bool ReferenceEquals(AddressableAsset asset);

		public abstract bool ReferenceEquals(AssetReference asset);
	}
	[Serializable]
	public class AddressableAsset<T> : AddressableAsset where T : UnityEngine.Object
	{
		[CompilerGenerated]
		private sealed class _003CCoLoadAsync_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AddressableAsset<T> _003C_003E4__this;

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
			public _003CCoLoadAsync_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CCoWaitUntilFinished_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AddressableAsset<T> _003C_003E4__this;

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
			public _003CCoWaitUntilFinished_003Ed__13(int _003C_003E1__state)
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
		protected AssetReference assetRef;

		private CallbackResultGroup onLoadedCallbackGroup;

		private AsyncOperationHandle handle;

		public CallbackResultGroup OnLoaded => null;

		public AddressableAsset()
		{
		}

		public AddressableAsset(AssetReference assetRef)
		{
		}

		~AddressableAsset()
		{
		}

		protected override void OnDeserialize()
		{
		}

		public AddressableAsset<T> Clone()
		{
			return null;
		}

		public virtual T GetAsset()
		{
			return null;
		}

		[IteratorStateMachine(typeof(AddressableAsset<>._003CCoLoadAsync_003Ed__11))]
		public override IEnumerator CoLoadAsync(Action onFinished = null)
		{
			return null;
		}

		public override void LoadAsync(Action onSuccessCb = null, Action onErrorcb = null, Action onFinishedcb = null)
		{
		}

		[IteratorStateMachine(typeof(AddressableAsset<>._003CCoWaitUntilFinished_003Ed__13))]
		public IEnumerator CoWaitUntilFinished()
		{
			return null;
		}

		public override void Unload()
		{
		}

		public override void Destroy()
		{
		}

		public override bool ReferenceEquals(AddressableAsset asset)
		{
			return false;
		}

		public override bool ReferenceEquals(AssetReference asset)
		{
			return false;
		}

		public override AssetLoadState GetState()
		{
			return default(AssetLoadState);
		}

		private void AttachOnCompleteCallback()
		{
		}

		private void HandleOnCompleted(AsyncOperationHandle obj)
		{
		}
	}
}
