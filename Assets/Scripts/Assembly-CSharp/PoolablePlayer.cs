using System;
using PowerTools;
using UnityEngine;

public class PoolablePlayer : MonoBehaviour
{
	public SpriteRenderer[] Hands;

	public SpriteRenderer[] OtherBodySprites;

	[SerializeField]
	private CosmeticsLayer cosmetics;

	private PlayerBodyTypes bodyType;

	[SerializeField]
	private bool ignoreLongMode;

	public CosmeticsLayer Cosmetics
	{
		get
		{
			if (cosmetics == null)
			{
				cosmetics = GetComponentInChildren<CosmeticsLayer>(true);
			}
			return cosmetics;
		}
	}

	public string ColorBlindName => string.Empty;

	public PlayerBodyTypes CurrentBodyType => bodyType;

	public int ColorId => Cosmetics != null ? Cosmetics.ColorId : PlayerCustomization.ColorId;

	public bool GetIgnoreLongMode()
	{
		return ignoreLongMode;
	}

	public void SetBodyCosmeticsVisible(bool b)
	{
		if (Cosmetics != null)
		{
			Cosmetics.Visible = b;
		}
	}

	public void ToggleHat(bool b)
	{
		if (Cosmetics != null)
		{
			Cosmetics.SetHatColor(b ? Color.white : Color.clear);
		}
	}

	public void SetCustomHatPosition(Vector3 pos)
	{
	}

	public void SetCustomVisorPosition(Vector3 pos)
	{
	}

	public bool HasHat()
	{
		return Cosmetics != null && Cosmetics.HasHat();
	}

	public SpriteRenderer GetHandHat()
	{
		return Cosmetics != null ? Cosmetics.HatHand : null;
	}

	private void OnEnable()
	{
		SetBodyType(bodyType);
		SetBodyCosmeticsVisible(true);
	}

	private void OnDisable()
	{
	}

	private void SetColorBlindTag()
	{
	}

	public void ResetCosmetics(string ignoreType = "")
	{
		if (Cosmetics != null)
		{
			Cosmetics.ResetCosmetics(ignoreType);
		}
	}

	public SpriteAnim GetSkinSpriteAnim()
	{
		return Cosmetics != null && Cosmetics.CurrentSkin != null ? Cosmetics.CurrentSkin.animator : null;
	}

	public void SetMaskLayer(int layer)
	{
		if (Cosmetics != null)
		{
			Cosmetics.SetMaskLayer(layer);
		}
	}

	public void SetHatLeftFacingVictim(bool leftFacingVictim)
	{
		Cosmetics?.SetHatLeftFacingVictim(leftFacingVictim);
	}

	public void SetHatOnFloor()
	{
		Cosmetics?.SetHatOnFloor();
	}

	public void SetVisorOnFloor()
	{
		Cosmetics?.SetVisorOnFloor();
	}

	public void FlipHatAndVisor()
	{
	}

	public void SetHatAndVisorMaskType(PlayerMaterial.MaskType type)
	{
		Cosmetics?.SetHatAndVisorMaskType(type);
	}

	public void SetVisor(string visorId, int color)
	{
		Cosmetics?.SetVisor(visorId, color);
	}

	public void SetVisor(VisorData visorData, int color)
	{
		Cosmetics?.SetVisor(visorData, color);
	}

	public void SetHatWithoutChangingColor(HatData hatData)
	{
		Cosmetics?.SetHatWithoutChangingColor(hatData);
	}

	public void SetHat(string hatId, int color)
	{
		Cosmetics?.SetHat(hatId, color);
	}

	public void SetHat(HatData hatData, int color)
	{
		Cosmetics?.SetHat(hatData, color);
	}

	public void SetNameScale(Vector3 scale)
	{
		Cosmetics?.SetNameScale(scale);
	}

	public void SetName(string nameStr, Vector3 scale, Color color, float zPosition)
	{
		Cosmetics?.SetName(nameStr, scale, color, zPosition);
	}

	public void SetName(string nameStr)
	{
		Cosmetics?.SetName(nameStr);
	}

	public void SetNameColor(Color color)
	{
		Cosmetics?.SetNameColor(color);
	}

	public void SetNamePosition(Vector3 newPos)
	{
		Cosmetics?.SetNamePosition(newPos);
	}

	public void SetBodyAsGhost()
	{
		Cosmetics?.SetBodyAsGhost();
	}

	public void SetBodyColor(int color)
	{
		Cosmetics?.SetBodyColor(color);
	}

	public void FixSkinSprite(Sprite skinSprite)
	{
	}

	public void SetSkin(string skinId, int color)
	{
		Cosmetics?.SetSkin(skinId, color);
	}

	public void SetSkin(SkinData skin, int color)
	{
		Cosmetics?.SetSkin(skin, color);
	}

	public void ReplacePetParent(Transform newParent, Vector3 newPosition)
	{
		Cosmetics?.ReplacePetParent(newParent, newPosition);
	}

	public void ToggleName(bool active)
	{
		Cosmetics?.ToggleName(active);
	}

	public void TogglePet(bool active)
	{
		Cosmetics?.TogglePet(active);
	}

	public void SetPetColor(int color)
	{
		Cosmetics?.SetPetIdle(PlayerCustomization.PetId, color);
	}

	public void SetPetIdle(string petId, int colorId)
	{
		Cosmetics?.SetPetIdle(petId, colorId);
	}

	public void SetPetIdle(PetData petData, int colorId)
	{
		Cosmetics?.SetPetIdle(petData, colorId);
	}

	public void SetPetIdle(PetBehaviour petBehaviour, int colorId)
	{
		Cosmetics?.SetPetIdle(petBehaviour, colorId);
	}

	public void SetPetScared(PetBehaviour petBehaviour, int colorId)
	{
		Cosmetics?.SetPetScared(petBehaviour, colorId);
	}

	public void SetFlipX(bool flipped)
	{
		Cosmetics?.SetFlipX(flipped);
	}

	public void SetDeadFlipX(bool flipped)
	{
		Cosmetics?.SetDeadFlipX(flipped);
	}

	public void SetPetFlipX(bool flipped)
	{
		Cosmetics?.SetPetFlipX(flipped);
	}

	public void SetBodyType(PlayerBodyTypes bodyType)
	{
		this.bodyType = bodyType;
		Cosmetics?.SetBodyType(bodyType);
	}

	public void UpdateFromLocalPlayer(PlayerMaterial.MaskType maskType)
	{
	}

	public void UpdateFromDataManager(PlayerMaterial.MaskType maskType)
	{
	}

	public void UpdateFromDataManager(PlayerMaterial.MaskType maskType, int colorId)
	{
	}

	public void UpdateFromEitherPlayerDataOrCache(NetworkedPlayerInfo pData, PlayerOutfitType outfitType, PlayerMaterial.MaskType maskType, bool includePet, Action OnSkinLoaded = null)
	{
	}

	public void UpdateFromPlayerData(NetworkedPlayerInfo pData, PlayerOutfitType outfitType, PlayerMaterial.MaskType maskType, bool includePet, Action OnSkinLoaded = null, bool forceAlive = false)
	{
	}

	public void UpdateFromPlayerOutfit(NetworkedPlayerInfo.PlayerOutfit outfit, PlayerMaterial.MaskType maskType, bool isDead, bool includePet, Action OnSkinLoaded = null, bool forceAlive = false)
	{
	}

	private void Awake()
	{
		if (bodyType == 0)
		{
			bodyType = PlayerBodyTypes.Normal;
		}
		InitBody();
	}

	private void InitBody()
	{
		Cosmetics?.EnsureInitialized(bodyType);
	}

	public void HideHatAndVisor_AnimEvent()
	{
	}

	public void FadeBlackAll(float duration)
	{
	}

	public SkinViewData GetSkinView()
	{
		return Cosmetics != null && Cosmetics.CurrentSkin != null ? Cosmetics.CurrentSkin.skin : null;
	}
}
