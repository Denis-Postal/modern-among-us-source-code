using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class SkinData : CosmeticData, IAddressableAssetProvider<SkinViewData>
{
	[CompilerGenerated]
	private sealed class _003CCoLoadIcon_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkinData _003C_003E4__this;

		public Action<Sprite, AddressableAsset> onLoaded;

		private AddressableAsset<SkinViewData> _003Casset_003E5__2;

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
		public _003CCoLoadIcon_003Ed__8(int _003C_003E1__state)
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

	public const string EmptyId = "skin_None";

	public const string RHMId = "skin_rhm";

	public AssetReference ViewDataRef;

	public string StoreName;

	public bool IsEmpty => ProductId == EmptyId || name == EmptyId || string.IsNullOrEmpty(ProductId) && string.IsNullOrEmpty(name);

	public AddressableAsset<SkinViewData> CreateAddressableAsset()
	{
		return null;
	}

	public AssetReference GetAssetReference()
	{
		return ViewDataRef;
	}

	[IteratorStateMachine(typeof(_003CCoLoadIcon_003Ed__8))]
	public override IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}

	public override void PreviewOnPlayer(PoolablePlayer p, int colorId, string resetIgnoreType = "")
	{
		if (p != null)
		{
			p.SetSkin(this, colorId);
		}
	}

	public override string GetItemCategory()
	{
		return "Skin";
	}
}
