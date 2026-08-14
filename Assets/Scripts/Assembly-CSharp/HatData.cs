using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class HatData : CosmeticData, IAddressableAssetProvider<HatViewData>
{
    [CompilerGenerated]
    private sealed class _003CCoLoadIcon_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
    {
        private int _003C_003E1__state;
        private object _003C_003E2__current;
        public HatData _003C_003E4__this;
        public Action<Sprite, AddressableAsset> onLoaded;

        object IEnumerator<object>.Current
        {
            [DebuggerHidden]
            get => _003C_003E2__current;
        }

        object IEnumerator.Current
        {
            [DebuggerHidden]
            get => _003C_003E2__current;
        }

        [DebuggerHidden]
        public _003CCoLoadIcon_003Ed__13(int _003C_003E1__state)
        {
            this._003C_003E1__state = _003C_003E1__state;
        }

        [DebuggerHidden]
        void IDisposable.Dispose() { }

        private bool MoveNext()
        {
            if (_003C_003E1__state == 0)
            {
                _003C_003E1__state = -1;
                
                if (onLoaded != null)
                {
                    HatViewData viewData = CosmeticAssetLoader.LoadReference<HatViewData>(_003C_003E4__this.ViewDataRef, _003C_003E4__this.name);
                    if (viewData != null && viewData.MainImage != null)
                    {
                        onLoaded(viewData.MainImage, null);
                    }
                }
                return false;
            }
            return false;
        }

        bool IEnumerator.MoveNext() => this.MoveNext();

        [DebuggerHidden]
        void IEnumerator.Reset() { }
    }

    public const string EmptyId = "hat_NoHat";

    public AssetReference ViewDataRef;
    public bool InFront;
    public bool NoBounce;
    public bool BlocksVisors;
    public string StoreName;
    public SkinData RelatedSkin;

    public bool IsEmpty => ProductId == EmptyId || name == EmptyId || (string.IsNullOrEmpty(ProductId) && string.IsNullOrEmpty(name));

    public AddressableAsset<HatViewData> CreateAddressableAsset() => null;

    public AssetReference GetAssetReference() => ViewDataRef;

    public override void PreviewOnPlayer(PoolablePlayer p, int colorId, string resetIgnoreType = "")
    {
        if (p != null)
        {
            p.SetHat(this, colorId);
        }
    }

    public override string GetItemCategory() => "Hat";

    public override IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
    {
        _003CCoLoadIcon_003Ed__13 _coLoad = new _003CCoLoadIcon_003Ed__13(0);
        _coLoad._003C_003E4__this = this;
        _coLoad.onLoaded = onLoaded;
        return _coLoad;
    }
}