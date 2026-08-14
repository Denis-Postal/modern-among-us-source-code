using UnityEngine;
using Innersloth.Assets; 
using PowerTools;        

public class HatParent : MonoBehaviour
{
    public SpriteRenderer BackLayer;
    public SpriteRenderer FrontLayer;
    public SpriteRenderer Parent;

    public SpriteAnimNodeSync SpriteSyncNode;

    private AddressableAsset<HatViewData> viewAsset;
    private PlayerMaterial.Properties matProperties;
    private HatOptions options;
    private bool shouldFaceLeft;
    private const float ClimbZOffset = -0.02f;

    public bool IsLoaded => Hat != null;
    
    public HatData Hat { get; set; }

    public bool Visible
    {
        set
        {
            if (BackLayer != null) BackLayer.enabled = value;
            if (FrontLayer != null) FrontLayer.enabled = value;
            if (Parent != null) Parent.enabled = value;
        }
    }

    public Color SpriteColor
    {
        set
        {
            if (BackLayer != null) BackLayer.color = value;
            if (FrontLayer != null) FrontLayer.color = value;
            if (Parent != null) Parent.color = value;
        }
    }

    public bool FlipX
    {
        set
        {
            if (BackLayer != null) BackLayer.flipX = value;
            if (FrontLayer != null) FrontLayer.flipX = value;
            if (Parent != null) Parent.flipX = value;
        }
    }

    private void OnDestroy() { }

    public bool HasHat()
    {
        return Hat != null && !Hat.IsEmpty; 
    }

    public void SetHat(string hatId, int color)
    {
        if (DestroyableSingleton<HatManager>.Instance != null)
        {
            SetHat(DestroyableSingleton<HatManager>.Instance.GetHatById(hatId), color);
        }
    }

    public void SetHat(HatData hat, int color)
    {
        Hat = hat;
        SetHat(color);
    }

    private void SetHat(int color)
    {
        PopulateFromViewData();
        SetMaterialColor(color);
        Visible = Hat != null && !Hat.IsEmpty;
    }

    public void SetIdleAnim(int colorId) { }
    
    public void SetShouldFaceLeft(bool leftFacingVictim) 
    { 
        shouldFaceLeft = leftFacingVictim; 
        PopulateFromViewData(); 
    }
    
    public void SetFloorAnim() { }
    public void SetClimbAnim() { }
    public void SetLocalPlayer(bool localPlayer) { }

    public void SetMaterialColor(int color)
    {
        if (BackLayer != null) PlayerMaterial.SetColors(color, BackLayer);
        if (FrontLayer != null) PlayerMaterial.SetColors(color, FrontLayer);
        if (Parent != null) PlayerMaterial.SetColors(color, Parent);
    }

    public void SetMaskType(PlayerMaterial.MaskType maskType) { }
    
    public void SetMaskLayer(int layer)
    {
        if (BackLayer != null) PlayerMaterial.SetMaskLayer(BackLayer.material, layer);
        if (FrontLayer != null) PlayerMaterial.SetMaskLayer(FrontLayer.material, layer);
        if (Parent != null) PlayerMaterial.SetMaskLayer(Parent.material, layer);
    }

    private void UnloadAsset() { }
    public void SetOptions(HatOptions b) { }
    private void UpdateMaterial() { }
    public void UpdateBounceHatZipline() { }
    public bool HideHat() => false;
    private void LateUpdate() { }

    private void PopulateFromViewData()
    {
        if (Hat == null || Hat.IsEmpty)
        {
            if (BackLayer != null) BackLayer.sprite = null;
            if (FrontLayer != null) FrontLayer.sprite = null;
            if (Parent != null) Parent.sprite = null;
            return;
        }

        // Загружаем данные через встроенный загрузчик игры
        HatViewData viewData = CosmeticAssetLoader.LoadReference<HatViewData>(Hat.ViewDataRef, Hat.name);
        
        if (viewData == null)
        {
            return;
        }

        // Распределяем спрайты по слоям в зависимости от разворота персонажа
        if (FrontLayer != null)
        {
            FrontLayer.sprite = (shouldFaceLeft && viewData.LeftMainImage != null) ? viewData.LeftMainImage : viewData.MainImage;
        }
        if (BackLayer != null)
        {
            BackLayer.sprite = (shouldFaceLeft && viewData.LeftBackImage != null) ? viewData.LeftBackImage : viewData.BackImage;
        }
        if (Parent != null)
        {
            Parent.sprite = (FrontLayer != null) ? FrontLayer.sprite : viewData.MainImage;
        }
    }
}