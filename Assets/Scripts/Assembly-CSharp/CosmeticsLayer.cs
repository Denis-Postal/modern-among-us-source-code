using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using PowerTools;
using TMPro;
using UnityEngine;

public class CosmeticsLayer : MonoBehaviour
{
	public enum CosmeticKind
	{
		SKIN = 0,
		HAT = 1,
		VISOR = 2,
		PET = 3
	}

	[CompilerGenerated]
	private sealed class _003CCoLoadAndSetPetIdle_003Ed__142 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmeticsLayer _003C_003E4__this;

		public int colorId;

		public Action onComplete;

		public PetData petData;

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
		public _003CCoLoadAndSetPetIdle_003Ed__142(int _003C_003E1__state)
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
	private sealed class _003CWalkPetBehindPlayer_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmeticsLayer _003C_003E4__this;

		public float speed;

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
		public _003CWalkPetBehindPlayer_003Ed__125(int _003C_003E1__state)
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
	[Header("Options")]
	private bool alwaysDrawNormalPlayer;

	[SerializeField]
	private bool uiPet;

	[SerializeField]
	private float zIndexSpacing;

	[SerializeField]
	private bool showColorBlindText;

	[SerializeField]
	[Header("Cosmetics")]
	private List<PlayerBodySprite> bodySprites;

	[SerializeField]
	private TextMeshPro colorBlindText;

	[SerializeField]
	private HatParent hat;

	[SerializeField]
	private TextMeshPro nameText;

	[SerializeField]
	private GameObject nameTextContainer;

	[SerializeField]
	private Transform petParent;

	[SerializeField]
	private SkinLayer skin;

	[SerializeField]
	private VisorLayer visor;

	[SerializeField]
	private Vector3 defaultHatVisorPosition;

	private PlayerBodyTypes bodyType;

	private PlayerMaterial.Properties bodyMatProperties;

	private PlayerBodySprite currentBodySprite;

	private PetBehaviour currentPet;

	private PlayerBodySprite normalBodySprite;

	private bool initialized;

	private AddressableAsset<PetBehaviour> petAsset;

	private LongBoiPlayerBody longboi;

	public bool petHiddenByViper;

	public const string EMPTY_SKIN_ID = "skin_None";

	public const string EMPTY_VISOR_ID = "visor_EmptyVisor";

	public const string EMPTY_HAT_ID = "hat_NoHat";

	public const string EMPTY_PET_ID = "pet_EmptyPet";

	private bool visible = true;

	private bool isNameVisible;

	private bool lockVisible;

	private bool localPlayer;

	public PetBehaviour CurrentPet => currentPet;

	public SkinLayer CurrentSkin => skin;

	public VisorLayer CurrentVisor => visor;

	public PlayerPettingHand PettingHand => currentBodySprite != null ? currentBodySprite.PettingHand : null;

	public SpriteRenderer HatHand => currentBodySprite != null ? currentBodySprite.HandHat : null;

	public PlayerBodyTypes CurrentBodyType => bodyType;

	public Vector3 FlippedCosmeticOffset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 NormalCosmeticOffset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool AlwaysDrawNormalPlayer => false;

	public bool FlipX { get; private set; }

	public int ColorId => bodyMatProperties.ColorId;

	public bool Visible
	{
		get
		{
			return visible;
		}
		set
		{
			visible = value;
			UpdateVisibility();
		}
	}

	public event Action<int> OnColorChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnSetBodyAsGhost
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string, int, CosmeticKind> OnCosmeticSet
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetBodyCosmeticsVisible(bool b)
	{
		if (hat != null)
		{
			hat.Visible = b;
		}
		if (skin != null)
		{
			skin.Visible = b;
		}
		if (visor != null)
		{
			visor.Visible = b;
		}
	}

	public void UpdateVisibility()
	{
		for (int i = 0; bodySprites != null && i < bodySprites.Count; i++)
		{
			if (bodySprites[i] != null)
			{
				bodySprites[i].Visible = visible && bodySprites[i].Type == bodyType;
			}
		}
		ApplyBodyFormVisibility();
		if (nameTextContainer != null)
		{
			nameTextContainer.SetActive(visible && isNameVisible);
		}
	}

	public void SetPhantomRoleAlpha(float alphaValue)
	{
	}

	public float GetPhantomRoleAlpha()
	{
		return 0f;
	}

	public void SetPetVisible(bool v)
	{
		if (currentPet != null)
		{
			currentPet.gameObject.SetActive(v && !petHiddenByViper);
		}
	}

	public bool HasPetEquipped()
	{
		return currentPet != null;
	}

	public void ToggleHat(bool b)
	{
		if (hat != null)
		{
			hat.Visible = b;
		}
	}

	public void SetForcedVisible(bool isVisible)
	{
	}

	public static Material GetBodyMaterial(PlayerMaterial.MaskType type)
	{
		return null;
	}

	public void EnsureInitialized(PlayerBodyTypes bt)
	{
		if (initialized && bodyType == bt)
		{
			return;
		}
		initialized = true;
		bodyType = bt;
		currentBodySprite = null;
		for (int i = 0; bodySprites != null && i < bodySprites.Count; i++)
		{
			if (bodySprites[i] != null && bodySprites[i].Type == bt)
			{
				currentBodySprite = bodySprites[i];
				break;
			}
		}
		if (currentBodySprite == null && bodySprites != null && bodySprites.Count > 0)
		{
			currentBodySprite = bodySprites[0];
		}
		UpdateVisibility();
	}

	public void SetBodyType(PlayerBodyTypes bodyType)
	{
		EnsureInitialized(bodyType);
		ApplyBodyFormVisibility();
	}

	private void ApplyBodyFormVisibility()
	{
		Transform bodyForms = FindBodyFormsRoot();
		if (bodyForms == null)
		{
			return;
		}
		SetBodyForm(bodyForms, "Normal", bodyType == PlayerBodyTypes.Normal && visible);
		SetBodyForm(bodyForms, "Horse", bodyType == PlayerBodyTypes.Horse && visible);
		SetBodyForm(bodyForms, "Seeker", bodyType == PlayerBodyTypes.Seeker && visible);
		SetBodyForm(bodyForms, "LongBoiBody", bodyType == PlayerBodyTypes.Long && visible);
		SetBodyForm(bodyForms, "LongSeekerBody", bodyType == PlayerBodyTypes.LongSeeker && visible);
	}

	private static void SetBodyForm(Transform bodyForms, string childName, bool enabled)
	{
		Transform child = bodyForms.Find(childName);
		if (child == null)
		{
			return;
		}
		child.gameObject.SetActive(enabled);
		Renderer[] renderers = child.GetComponentsInChildren<Renderer>(true);
		for (int i = 0; i < renderers.Length; i++)
		{
			renderers[i].enabled = enabled;
		}
	}

	private Transform FindBodyFormsRoot()
	{
		Transform cursor = transform;
		while (cursor != null)
		{
			Transform bodyForms = cursor.Find("BodyForms");
			if (bodyForms != null)
			{
				return bodyForms;
			}
			cursor = cursor.parent;
		}
		return null;
	}

	public void SetCustomHatPosition(Vector3 pos)
	{
	}

	public void SetCustomVisorPosition(Vector3 pos)
	{
	}

	public SkinViewData GetSkinView()
	{
		return skin != null ? skin.skin : null;
	}

	public void FixSkinSprite(Sprite skinSprite)
	{
	}

	public PetBehaviour GetPet()
	{
		return currentPet;
	}

	public SpriteAnim GetSkinSpriteAnim()
	{
		return skin != null ? skin.animator : null;
	}

	public void ReplacePetParent(Transform newParent, Vector3 newPosition)
	{
		if (currentPet != null && newParent != null)
		{
			currentPet.transform.SetParent(newParent);
			currentPet.transform.localPosition = newPosition;
		}
	}

	public void ResetCosmetics(string ignoreType = "")
	{
		if (ignoreType != "hat")
		{
			SetHat(EMPTY_HAT_ID, ColorId);
		}
		if (ignoreType != "skin")
		{
			SetSkin(EMPTY_SKIN_ID, ColorId);
		}
		if (ignoreType != "visor")
		{
			SetVisor(EMPTY_VISOR_ID, ColorId);
		}
	}

	public void SetBodyAsGhost()
	{
		for (int i = 0; bodySprites != null && i < bodySprites.Count; i++)
		{
			PlayerBodySprite sprite = bodySprites[i];
			if (sprite?.BodySprite != null && sprite.GhostSprite != null)
			{
				sprite.BodySprite.sprite = sprite.GhostSprite;
			}
		}
	}

	public void SetBodyColor(int bodyColor)
	{
		bodyMatProperties.ColorId = bodyColor;
		SetColor(bodyColor);
	}

	public void SetColor(int color)
	{
		EnsureInitialized(initialized ? bodyType : PlayerBodyTypes.Normal);
		visible = true;
		bodyMatProperties.ColorId = color;
		for (int i = 0; bodySprites != null && i < bodySprites.Count; i++)
		{
			PlayerBodySprite bodySprite = bodySprites[i];
			if (bodySprite?.BodySprite != null)
			{
				PlayerMaterial.SetColors(color, bodySprite.BodySprite);
			}
			if (bodySprite?.LongModeParts != null)
			{
				for (int j = 0; j < bodySprite.LongModeParts.Length; j++)
				{
					if (bodySprite.LongModeParts[j] != null)
					{
						PlayerMaterial.SetColors(color, bodySprite.LongModeParts[j]);
					}
				}
			}
		}
		skin?.SetColor(color);
		hat?.SetMaterialColor(color);
		visor?.SetMaterialColor(color);
		UpdateVisibility();
	}

	public void SetDeadFlipX(bool flipped)
	{
	}

	public void SetEnabledColorblind(bool isEnabled)
	{
	}

	public void SetFlipX(bool flipped)
	{
		FlipX = flipped;
		for (int i = 0; bodySprites != null && i < bodySprites.Count; i++)
		{
			bodySprites[i]?.SetFlipX(flipped);
		}
		if (hat != null)
		{
			hat.FlipX = flipped;
		}
		visor?.SetFlipX(flipped);
	}

	public void SetFlipXWithoutPet(bool flipped)
	{
	}

	public void SetGhost()
	{
	}

	public bool HasHat()
	{
		return hat != null && hat.HasHat();
	}

	public void SetHat(string hatId, int color)
	{
		hat?.SetHat(hatId, color);
	}

	public void SetHat(HatData hatData, int color)
	{
		hat?.SetHat(hatData, color);
	}

	public void SetHatColor(Color color)
	{
		if (hat != null)
		{
			hat.SpriteColor = color;
		}
	}

	public void SetHatColor(int color)
	{
		hat?.SetMaterialColor(color);
	}

	public void SetHatWithoutChangingColor(HatData hatData)
	{
		SetHat(hatData, ColorId);
	}

	public void SetVisor(string visorId, int color)
	{
		visor?.SetVisor(visorId, color);
	}

	public void SetVisor(VisorData visorData, int color)
	{
		visor?.SetVisor(visorData, color);
	}

	public void ValidateCosmetics()
	{
	}

	public void SetVisorAlpha(float alpha)
	{
		if (visor != null)
		{
			visor.Alpha = alpha;
		}
	}

	public void SetVisorColor(int color)
	{
		visor?.SetMaterialColor(color);
	}

	public void ToggleVisor(bool active)
	{
		if (visor != null)
		{
			visor.Visible = active;
		}
	}

	public void SetHatAndVisorIdle(int colorId)
	{
	}

	public void SetHatLeftFacingVictim(bool leftFacingVictim)
	{
		hat?.SetShouldFaceLeft(leftFacingVictim);
	}

	public void SetHatOnFloor()
	{
		hat?.SetFloorAnim();
	}

	public void SetVisorOnFloor()
	{
		visor?.SetFloorAnim();
	}

	public void SetHatAndVisorMaskType(PlayerMaterial.MaskType type)
	{
		hat?.SetMaskType(type);
		visor?.SetMaskType(type);
	}

	public void SetMaskLayer(int layer)
	{
		bodyMatProperties.MaskLayer = layer;
		for (int i = 0; bodySprites != null && i < bodySprites.Count; i++)
		{
			PlayerBodySprite bodySprite = bodySprites[i];
			if (bodySprite?.BodySprite != null)
			{
				PlayerMaterial.SetMaskLayer(bodySprite.BodySprite.material, layer);
			}
		}
		hat?.SetMaskLayer(layer);
		visor?.SetMaskLayer(layer);
		skin?.SetMaskLayer(layer);
	}

	public void SetMaskType(PlayerMaterial.MaskType type)
	{
	}

	public void SetName(string nameStr, Vector3 scale, Color color, float zPosition)
	{
		SetName(nameStr);
		SetNameScale(scale);
		SetNameColor(color);
		SetNamePositionZ(zPosition);
	}

	public void SetName(string nameStr)
	{
		if (nameText != null)
		{
			nameText.text = nameStr ?? string.Empty;
		}
	}

	public void SetNameColor(Color color)
	{
		if (nameText != null)
		{
			nameText.color = color;
		}
	}

	public void SetNameMask(bool alive)
	{
	}

	public void SetNamePosition(Vector3 newPosition)
	{
		if (nameTextContainer != null)
		{
			nameTextContainer.transform.localPosition = newPosition;
		}
	}

	public void SetNamePositionZ(float zPos)
	{
		if (nameTextContainer != null)
		{
			Vector3 localPosition = nameTextContainer.transform.localPosition;
			localPosition.z = zPos;
			nameTextContainer.transform.localPosition = localPosition;
		}
	}

	public void SetNameScale(Vector3 scale)
	{
		if (nameTextContainer != null)
		{
			nameTextContainer.transform.localScale = scale;
		}
	}

	public void SetOutline(bool active, Color? color = null)
	{
	}

	public void SetPetFlipX(bool flipped)
	{
	}

	public void SetPetIdle(string petId, int colorId, Action onComplete = null)
	{
		SetPetIdle(DestroyableSingleton<HatManager>.Instance.GetPetById(petId), colorId, onComplete);
	}

	public void SetPetIdle(PetData petData, int colorId, Action onComplete = null)
	{
		if (petData == null || petData.IsEmpty)
		{
			if (currentPet != null)
			{
				UnityEngine.Object.Destroy(currentPet.gameObject);
				currentPet = null;
			}
			onComplete?.Invoke();
			return;
		}
		PetBehaviour prefab = CosmeticAssetLoader.LoadReference<PetBehaviour>(petData.PetPrefabRef);
		if (prefab != null)
		{
			SetPetIdle(UnityEngine.Object.Instantiate(prefab), colorId, onComplete);
			return;
		}
		onComplete?.Invoke();
	}

	public void SetPetIdle(PetBehaviour petBehaviour, int colorId, Action onComplete = null)
	{
		if (currentPet != null && currentPet != petBehaviour)
		{
			UnityEngine.Object.Destroy(currentPet.gameObject);
		}
		currentPet = petBehaviour;
		if (currentPet != null)
		{
			if (petParent != null)
			{
				currentPet.transform.SetParent(petParent);
			}
			currentPet.gameObject.SetActive(visible && !petHiddenByViper);
		}
		onComplete?.Invoke();
	}

	public void SetPetPosition(Vector3 newPosition)
	{
	}

	[IteratorStateMachine(typeof(_003CWalkPetBehindPlayer_003Ed__125))]
	public IEnumerator WalkPetBehindPlayer(float speed)
	{
		return null;
	}

	public void SetPetScared(PetBehaviour petBehaviour, int colorId)
	{
	}

	public void SetPetSource(PlayerControl playerControl)
	{
	}

	public void SetScale(Vector3 playerScale, Vector3 cosmeticsScale)
	{
	}

	public void SetSkin(string skinId, int color, Action onLoaded = null)
	{
		skin?.SetSkin(skinId, color, FlipX, this, onLoaded);
	}

	public void SetSkin(SkinData skin, int color, Action onLoaded = null)
	{
		this.skin?.SetSkin(skin, color, FlipX, this, onLoaded);
	}

	public void ValidateSkin(string prodId, int color)
	{
	}

	public void SetSkin(SkinViewData skin, int color)
	{
	}

	public void SetSkinColor(int color)
	{
	}

	public void ToggleName(bool active)
	{
		isNameVisible = active;
		UpdateVisibility();
	}

	public void TogglePet(bool active)
	{
		SetPetVisible(active);
	}

	public void HidePetViper()
	{
	}

	public void TogglePetVisible(bool visible)
	{
		SetPetVisible(visible);
	}

	public void ToggleNameVisible(bool visible)
	{
		ToggleName(visible);
	}

	public bool IsSkinPlayingRunAnim()
	{
		return false;
	}

	private void UpdateNameVisibility()
	{
	}

	private static SpriteMaskInteraction GetBodySpriteMaskInteraction(PlayerMaterial.MaskType type)
	{
		return default(SpriteMaskInteraction);
	}

	[IteratorStateMachine(typeof(_003CCoLoadAndSetPetIdle_003Ed__142))]
	private IEnumerator CoLoadAndSetPetIdle(PetData petData, int colorId, Action onComplete = null)
	{
		return null;
	}

	private void InstantiatePetCopy(PetBehaviour petBehaviour, int colorId)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetColorBlindColor(int color)
	{
	}

	public string GetColorBlindText()
	{
		return null;
	}

	private void SetCosmeticZIndices()
	{
	}

	private void SetPetColor(int color)
	{
	}

	private void UpdateBodyMaterial()
	{
	}

	public void ShowLongModeParts(bool show)
	{
	}

	public void SetHatVisorVisible(bool isVisible)
	{
	}

	public void FadeBlackCosmetics(float duration)
	{
	}

	public LongBoiPlayerBody GetLongBoi()
	{
		return null;
	}

	public void UpdateCosmeticOffset(float headPosZ, bool isExiled)
	{
	}

	public void AdjustCosmeticRotations(float rotOffset)
	{
	}

	public List<AddressableAsset> GetAllLoadedAssets()
	{
		return null;
	}

	public void UnloadPet(AddressableAsset asset)
	{
	}

	public void UnloadVisor(AddressableAsset asset)
	{
	}

	public void UnloadSkin(AddressableAsset asset)
	{
	}

	public void AnimateClimb(bool down)
	{
	}

	public void AnimatePetMourning()
	{
	}

	public void AnimateSkinJump()
	{
	}

	public void AnimateSkinEnterVent()
	{
	}

	public void AnimateSkinExitVent()
	{
	}

	public void AnimateSkinIdle()
	{
	}

	public void AnimateSkinRun()
	{
	}

	public void AnimateSkinSpawn(float time = 0f)
	{
	}

	public bool HasSkinLoaded()
	{
		return skin != null && skin.IsLoaded;
	}

	public bool HasVisorLoaded()
	{
		return visor != null && visor.IsLoaded;
	}

	public bool HaveAllCosmeticsLoaded()
	{
		return HasSkinLoaded() && HasVisorLoaded() && (hat == null || hat.IsLoaded);
	}

	public void SetAsLocalPlayer()
	{
	}

	public void UpdateBounceHatZipline()
	{
	}
}
