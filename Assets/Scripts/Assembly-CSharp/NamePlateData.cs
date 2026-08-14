using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class NamePlateData : CosmeticData, IAddressableAssetProvider<NamePlateViewData>
{
	[CompilerGenerated]
	private sealed class _003CCoLoadIcon_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NamePlateData _003C_003E4__this;

		public Action<Sprite, AddressableAsset> onLoaded;

		private AddressableAsset<NamePlateViewData> _003Casset_003E5__2;

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
		public _003CCoLoadIcon_003Ed__7(int _003C_003E1__state)
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

	public const string EmptyId = "nameplate_NoPlate";

	public AssetReference ViewDataRef;

	public bool IsEmpty => ProductId == EmptyId || name == EmptyId || string.IsNullOrEmpty(ProductId) && string.IsNullOrEmpty(name);

	public override string GetItemCategory()
	{
		return "Nameplate";
	}

	public AddressableAsset<NamePlateViewData> CreateAddressableAsset()
	{
		return null;
	}

	public AssetReference GetAssetReference()
	{
		return ViewDataRef;
	}

	[IteratorStateMachine(typeof(_003CCoLoadIcon_003Ed__7))]
	public override IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}
}
