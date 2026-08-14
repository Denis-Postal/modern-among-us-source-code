using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class VisorData : CosmeticData, IAddressableAssetProvider<VisorViewData>
{
	[CompilerGenerated]
	private sealed class _003CCoLoadIcon_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VisorData _003C_003E4__this;

		public Action<Sprite, AddressableAsset> onLoaded;

		private AddressableAsset<VisorViewData> _003Casset_003E5__2;

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
		public _003CCoLoadIcon_003Ed__11(int _003C_003E1__state)
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
	private bool behindHats;

	public const string EmptyId = "visor_EmptyVisor";

	public AssetReference ViewDataRef;

	public bool BehindHats => behindHats;

	public bool IsEmpty => ProductId == EmptyId || name == EmptyId || string.IsNullOrEmpty(ProductId) && string.IsNullOrEmpty(name);

	public override string GetItemCategory()
	{
		return "Visor";
	}

	public AddressableAsset<VisorViewData> CreateAddressableAsset()
	{
		return null;
	}

	public AssetReference GetAssetReference()
	{
		return ViewDataRef;
	}

	public override void PreviewOnPlayer(PoolablePlayer p, int colorId, string resetIgnoreType = "")
	{
		if (p != null)
		{
			p.SetVisor(this, colorId);
		}
	}

	[IteratorStateMachine(typeof(_003CCoLoadIcon_003Ed__11))]
	public override IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}
}
