using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class CosmeticData : ScriptableObject, IBuyable
{
	[CompilerGenerated]
	private sealed class _003CCoLoadIcon_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Sprite, AddressableAsset> onLoaded;

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
		public _003CCoLoadIcon_003Ed__33(int _003C_003E1__state)
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

	public const string TranslationPrefix = "Cosmetic.";

	public List<Platforms> unlockOnSelectPlatforms;

	public bool freeRedeemableCosmetic;

	public int redeemPopUpColor;

	public string epicId;

	public string BundleId;

	public string ProductId;

	public Vector2 ChipOffset;

	public int beanCost;

	public int starCost;

	public bool paidOnMobile;

	public LimitedTimeStartEnd limitedTime;

	public int displayOrder;

	public bool NotInStore;

	public bool Free;

	public AssetReference PreviewData;

	public bool PreviewCrewmateColor;

	public string ProdId => !string.IsNullOrEmpty(ProductId) ? ProductId : name;

	public int BeanCost => beanCost;

	public int StarCost => starCost;

	public string EpicId => epicId;

	public bool PaidOnMobile => paidOnMobile;

	public LimitedTimeStartEnd LimitedTimeAvailable => default(LimitedTimeStartEnd);

	public virtual void PreviewOnPlayer(PoolablePlayer p, int colorId, string ignoreType = "")
	{
	}

	public string GetItemName()
	{
		return string.IsNullOrEmpty(name) ? ProdId : name;
	}

	public virtual string GetItemCategory()
	{
		return GetType().Name.Replace("Data", string.Empty);
	}

	public virtual void SetProdId()
	{
		if (string.IsNullOrEmpty(ProductId))
		{
			ProductId = name;
		}
	}

	[IteratorStateMachine(typeof(_003CCoLoadIcon_003Ed__33))]
	public virtual IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}

	public void CoLoadPreview(Action<Sprite, AddressableAsset> onLoaded)
	{
	}

	public void SetPreview(SpriteRenderer renderer, int color)
	{
		if (renderer != null)
		{
			PlayerMaterial.SetColors(color, renderer);
		}
	}

	private string StoreName()
	{
		return string.Empty;
	}
}
