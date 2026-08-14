using System.Collections.Generic;
using AmongUs.GameOptions;
using InnerNet;
using TMPro;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameOptionsMenu : MonoBehaviour
{
	private IGameOptions cachedData;

	private List<OptionBehaviour> Children;

	[SerializeField]
	private GameOptionsMapPicker MapPicker;

	[SerializeField]
	private CategoryHeaderMasked categoryHeaderOrigin;

	[SerializeField]
	private ToggleOption checkboxOrigin;

	[SerializeField]
	private NumberOption numberOptionOrigin;

	[SerializeField]
	private PlayerOption playerOptionOrigin;

	[SerializeField]
	private StringOption stringOptionOrigin;

	[SerializeField]
	private Transform settingsContainer;

	[SerializeField]
	private Scroller scrollBar;

	[SerializeField]
	private Transform[] HideForOnline;

	[SerializeField]
	private RolesSettingsMenu RolesMenu;

	[SerializeField]
	private Collider2D ButtonClickMask;

	[SerializeField]
	private SpriteRenderer MaskBg;

	[SerializeField]
	private SpriteRenderer MaskArea;

	private const float START_POS_Y = 0.713f;

	private const float START_POS_X = 0.952f;

	private const float HEADER_HEIGHT = 0.63f;

	private const float MAP_PICKER_HEIGHT = 1.65f;

	private const float SPACING_Y = 0.45f;

	private const float HEADER_X = -0.903f;

	private const int MASK_LAYER = 20;

	private const float HEADER_SCALE = 0.63f;

	private static readonly int STENCIL_COMP = Shader.PropertyToID("_StencilComp");

	private static readonly int STENCIL = Shader.PropertyToID("_Stencil");

	private static readonly int MASK_LAYER_PROP = Shader.PropertyToID("_MaskLayer");

	private static readonly int MAIN_TEX = Shader.PropertyToID("_MainTex");

	private static readonly int FACE_COLOR = Shader.PropertyToID("_FaceColor");

	private static readonly int COLOR = Shader.PropertyToID("_Color");

	private static readonly int CUTOFF = Shader.PropertyToID("_Cutoff");

	private static readonly int SOFTNESS = Shader.PropertyToID("_Softness");

	private readonly Dictionary<TMP_FontAsset, Material> tmpWhiteMaterials = new Dictionary<TMP_FontAsset, Material>();

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void Awake()
	{
		if (Children == null)
		{
			Children = new List<OptionBehaviour>();
		}
	}

	private void CreateSettings()
	{
		if (Children == null)
		{
			Children = new List<OptionBehaviour>();
		}
		for (int i = 0; i < Children.Count; i++)
		{
			if ((bool)Children[i] && Children[i] != MapPicker)
			{
				Destroy(Children[i].gameObject);
			}
		}
		Children.Clear();
		GameSettingsCategoryList settingsList = GetSettingsList();
		if (settingsList == null)
		{
			return;
		}
		if (settingsContainer == null)
		{
			return;
		}
		float y = START_POS_Y;
		if (settingsList.MapNameSetting != null && MapPicker != null)
		{
			MapPicker.ClearMapButtons();
			MapPicker.gameObject.SetActive(true);
			MapPicker.SetClickMask(ButtonClickMask);
			MapPicker.SetUpFromData(settingsList.MapNameSetting, MASK_LAYER);
			MapPicker.OnValueChanged = ValueChanged;
			ApplyMaskLayer(MapPicker.gameObject);
			ForceTmpWhiteMaterial(MapPicker.gameObject);
			Children.Add(MapPicker);
			y -= MAP_PICKER_HEIGHT;
		}
		if (settingsList.OverviewSettings != null)
		{
			CreateHeader(StringNames.GameSettingsLabel, ref y);
			for (int j = 0; j < settingsList.OverviewSettings.Count; j++)
			{
				CreateOption(settingsList.OverviewSettings[j], ref y);
			}
		}
		if (settingsList.AllCategories != null)
		{
			for (int k = 0; k < settingsList.AllCategories.Count; k++)
			{
				RulesCategory rulesCategory = settingsList.AllCategories[k];
				CreateHeader(rulesCategory.CategoryName, ref y);
				if (rulesCategory.AllGameSettings == null)
				{
					continue;
				}
				for (int l = 0; l < rulesCategory.AllGameSettings.Count; l++)
				{
					CreateOption(rulesCategory.AllGameSettings[l], ref y);
				}
			}
		}
		if ((bool)scrollBar)
		{
			scrollBar.Inner = settingsContainer;
			scrollBar.SetYBoundsMax(Mathf.Max(0f, START_POS_Y - y - 3f));
		}
	}

	private GameSettingsCategoryList GetSettingsList()
	{
		GameSettingsCategoryList settingsList = GameManager.Instance != null ? GameManager.Instance.GameSettingsList : null;
		if (settingsList == null)
		{
			GameManagerCreator.CreateGameManager(GameModes.Normal);
			settingsList = GameManager.Instance != null ? GameManager.Instance.GameSettingsList : null;
		}
#if UNITY_EDITOR
		if (settingsList == null)
		{
			settingsList = AssetDatabase.LoadAssetAtPath<GameSettingsCategoryList>("Assets/MonoBehaviour/ClassicModeSettingsList.asset");
		}
#endif
		return settingsList;
	}

	private void Initialize()
	{
		if (GameOptionsManager.Instance == null)
		{
			new GameOptionsManager(new UnityLogger());
		}
		ConfigureMaskArea();
		cachedData = GameOptionsManager.Instance.GameHostOptions;
		CreateSettings();
		RefreshChildren();
	}

	private void Update()
	{
		if (settingsContainer != null)
		{
			ForceTmpWhiteMaterial(settingsContainer.gameObject);
		}
		ClipSettingsRenderers();
	}

	private void OnEnable()
	{
		OpenMenu();
	}

	private void OnDisable()
	{
		CleanupGeneratedSettings();
	}

	public void OpenMenu()
	{
		base.gameObject.SetActive(true);
		Initialize();
	}

	public void CloseMenu()
	{
		CleanupGeneratedSettings();
		base.gameObject.SetActive(false);
	}

	public void CleanupGeneratedSettings()
	{
		if (Children != null)
		{
			for (int i = 0; i < Children.Count; i++)
			{
				if ((bool)Children[i] && Children[i] != MapPicker)
				{
					Children[i].gameObject.SetActive(false);
					Destroy(Children[i].gameObject);
				}
			}
			Children.Clear();
		}
		CleanupGeneratedContainerChildren();
		if ((bool)MapPicker)
		{
			MapPicker.ClearMapButtons();
			MapPicker.gameObject.SetActive(false);
		}
	}

	private void CleanupGeneratedContainerChildren()
	{
		if (settingsContainer == null)
		{
			return;
		}
		for (int i = settingsContainer.childCount - 1; i >= 0; i--)
		{
			Transform child = settingsContainer.GetChild(i);
			if (child != null && child.name.Contains("(Clone)"))
			{
				child.gameObject.SetActive(false);
				Destroy(child.gameObject);
			}
		}
	}

	private void RefreshChildren()
	{
		for (int i = 0; Children != null && i < Children.Count; i++)
		{
			if ((bool)Children[i])
			{
				Children[i].Initialize();
			}
		}
	}

	private void ValueChanged(OptionBehaviour option)
	{
		if (option == null || option.Data == null || GameOptionsManager.Instance == null)
		{
			return;
		}
		IGameOptions options = GameOptionsManager.Instance.GameHostOptions;
		ApplyOptionValue(options, option);
		GameOptionsManager.Instance.GameHostOptions = options;
		GameOptionsManager.Instance.CurrentGameOptions = options;
		cachedData = options;
	}

	private void InitializeControllerNavigation()
	{
	}

	public void ClickPresetButton(RulesPresets preset)
	{
		if (GameOptionsManager.Instance == null)
		{
			return;
		}
		IGameOptions options = GameOptionsManager.Instance.GameHostOptions;
		if (options != null)
		{
			options.SetRecommendations(options.MaxPlayers, AmongUsClient.Instance != null && AmongUsClient.Instance.NetworkMode == NetworkModes.OnlineGame, preset);
			GameOptionsManager.Instance.GameHostOptions = options;
			GameOptionsManager.Instance.CurrentGameOptions = options;
			RefreshChildren();
		}
	}

	private void CreateHeader(StringNames header, ref float y)
	{
		if (categoryHeaderOrigin == null)
		{
			return;
		}
		CategoryHeaderMasked categoryHeaderMasked = Instantiate(categoryHeaderOrigin, settingsContainer);
		categoryHeaderMasked.gameObject.SetActive(true);
		categoryHeaderMasked.transform.localPosition = new Vector3(HEADER_X, y, 0f);
		categoryHeaderMasked.transform.localScale = Vector3.one * HEADER_SCALE;
		categoryHeaderMasked.SetHeader(header, MASK_LAYER);
		ApplyMaskLayer(categoryHeaderMasked.gameObject);
		ForceTmpWhiteMaterial(categoryHeaderMasked.gameObject);
		y -= HEADER_HEIGHT;
	}

	private void CreateOption(BaseGameSetting setting, ref float y)
	{
		if (setting == null)
		{
			return;
		}
		OptionBehaviour optionBehaviour = null;
		if (setting is CheckboxGameSetting && checkboxOrigin != null)
		{
			optionBehaviour = Instantiate(checkboxOrigin, settingsContainer);
		}
		else if ((setting is FloatGameSetting || setting is IntGameSetting) && numberOptionOrigin != null)
		{
			optionBehaviour = Instantiate(numberOptionOrigin, settingsContainer);
		}
		else if (setting is StringGameSetting && stringOptionOrigin != null)
		{
			optionBehaviour = Instantiate(stringOptionOrigin, settingsContainer);
		}
		if (optionBehaviour == null)
		{
			return;
		}
		optionBehaviour.gameObject.SetActive(true);
		optionBehaviour.transform.localPosition = new Vector3(START_POS_X, y, 0f);
		optionBehaviour.SetClickMask(ButtonClickMask);
		optionBehaviour.OnValueChanged = ValueChanged;
		optionBehaviour.SetUpFromData(setting, MASK_LAYER);
		ApplyMaskLayer(optionBehaviour.gameObject);
		ForceTmpWhiteMaterial(optionBehaviour.gameObject);
		Children.Add(optionBehaviour);
		y -= SPACING_Y;
	}

	private void ApplyOptionValue(IGameOptions options, OptionBehaviour option)
	{
		FloatGameSetting floatSetting = option.Data as FloatGameSetting;
		if (floatSetting != null)
		{
			options.SetFloat(floatSetting.OptionName, option.GetFloat());
			return;
		}
		IntGameSetting intSetting = option.Data as IntGameSetting;
		if (intSetting != null)
		{
			options.SetInt(intSetting.OptionName, option.GetInt());
			return;
		}
		CheckboxGameSetting checkboxSetting = option.Data as CheckboxGameSetting;
		if (checkboxSetting != null)
		{
			options.SetBool(checkboxSetting.OptionName, option.GetBool());
			return;
		}
		StringGameSetting stringSetting = option.Data as StringGameSetting;
		if (stringSetting != null)
		{
			options.SetInt(stringSetting.OptionName, option.GetInt());
			return;
		}
		MapSelectionGameSetting mapSetting = option.Data as MapSelectionGameSetting;
		if (mapSetting != null)
		{
			options.SetByte(mapSetting.OptionName, (byte)option.GetInt());
		}
	}

	private void ConfigureMaskArea()
	{
		if (MaskArea == null)
		{
			return;
		}
#if UNITY_EDITOR
		if (UnityEditor.EditorUtility.IsPersistent(MaskArea))
		{
			return;
		}
#endif
		Material material = MaskArea.gameObject.scene.IsValid() ? MaskArea.material : MaskArea.sharedMaterial;
		if (material == null)
		{
			return;
		}
		if (material.HasProperty(MASK_LAYER_PROP))
		{
			material.SetFloat(MASK_LAYER_PROP, MASK_LAYER);
		}
		if (material.HasProperty(STENCIL))
		{
			material.SetFloat(STENCIL, MASK_LAYER);
		}
	}

	private void ApplyMaskLayer(GameObject root)
	{
		if (root == null)
		{
			return;
		}
		Renderer[] renderers = root.GetComponentsInChildren<Renderer>(true);
		for (int i = 0; i < renderers.Length; i++)
		{
			Renderer renderer = renderers[i];
			if (renderer == null)
			{
				continue;
			}
#if UNITY_EDITOR
			if (UnityEditor.EditorUtility.IsPersistent(renderer))
			{
				continue;
			}
#endif
			TextRenderer textRenderer = renderer.GetComponent<TextRenderer>();
			if (textRenderer != null)
			{
				textRenderer.SetMaskLayer(MASK_LAYER);
				continue;
			}
			Material material = renderer.gameObject.scene.IsValid() ? renderer.material : renderer.sharedMaterial;
			if (material == null)
			{
				continue;
			}
			if (material.HasProperty(STENCIL_COMP))
			{
				material.SetFloat(STENCIL_COMP, 3f);
			}
			if (material.HasProperty(STENCIL))
			{
				material.SetFloat(STENCIL, MASK_LAYER);
			}
			if (material.HasProperty(MASK_LAYER_PROP))
			{
				material.SetFloat(MASK_LAYER_PROP, MASK_LAYER);
			}
		}
	}

	private void ForceTmpWhiteMaterial(GameObject root)
	{
		if (root == null)
		{
			return;
		}
		TMP_Text[] texts = root.GetComponentsInChildren<TMP_Text>(true);
		for (int i = 0; i < texts.Length; i++)
		{
			TMP_Text text = texts[i];
			if (text == null)
			{
				continue;
			}
			CleanupTextRendererComponents(text.gameObject);
			text.enabled = true;
			text.color = Color.white;
			text.alpha = 1f;
			text.faceColor = Color.white;
			Material material = GetTmpWhiteMaterial(text.font);
			if (material == null)
			{
				continue;
			}
			text.fontSharedMaterial = material;
			text.fontMaterial = material;
			Renderer renderer = text.GetComponent<Renderer>();
			if (renderer != null)
			{
				renderer.sharedMaterial = material;
				renderer.enabled = true;
			}
			text.SetVerticesDirty();
			text.SetMaterialDirty();
			text.ForceMeshUpdate(ignoreActiveState: true, forceTextReparsing: true);
		}
	}

	private Material GetTmpWhiteMaterial(TMP_FontAsset font)
	{
		if (font == null)
		{
			return null;
		}
		Material material;
		if (!tmpWhiteMaterials.TryGetValue(font, out material) || material == null)
		{
			Shader shader = Shader.Find("TextMeshPro/WhiteTextSimple");
			if (shader == null)
			{
				return null;
			}
			material = new Material(shader);
			material.name = font.name + " WhiteTextSimple Runtime";
			tmpWhiteMaterials[font] = material;
		}
		if (font.atlasTexture != null && material.HasProperty(MAIN_TEX))
		{
			material.SetTexture(MAIN_TEX, font.atlasTexture);
		}
		if (material.HasProperty(FACE_COLOR))
		{
			material.SetColor(FACE_COLOR, Color.white);
		}
		if (material.HasProperty(COLOR))
		{
			material.SetColor(COLOR, Color.white);
		}
		if (material.HasProperty(CUTOFF))
		{
			material.SetFloat(CUTOFF, 0.5f);
		}
		if (material.HasProperty(SOFTNESS))
		{
			material.SetFloat(SOFTNESS, 0.04f);
		}
		if (material.HasProperty(STENCIL_COMP))
		{
			material.SetFloat(STENCIL_COMP, 8f);
		}
		if (material.HasProperty(STENCIL))
		{
			material.SetFloat(STENCIL, 0f);
		}
		return material;
	}

	private void CleanupTextRendererComponents(GameObject target)
	{
		if (target == null)
		{
			return;
		}
		TMPTextRendererBridge bridge = target.GetComponent<TMPTextRendererBridge>();
		if (bridge != null)
		{
			bridge.enabled = false;
			Destroy(bridge);
		}
		TextRenderer textRenderer = target.GetComponent<TextRenderer>();
		if (textRenderer != null)
		{
			textRenderer.enabled = false;
			Destroy(textRenderer);
		}
	}

	private void ClipSettingsRenderers()
	{
		if (settingsContainer == null || MaskArea == null || !MaskArea.gameObject.activeInHierarchy)
		{
			return;
		}
		Bounds maskBounds = MaskArea.bounds;
		Renderer[] renderers = settingsContainer.GetComponentsInChildren<Renderer>(true);
		for (int i = 0; i < renderers.Length; i++)
		{
			Renderer renderer = renderers[i];
			if (renderer == null || renderer == MaskArea)
			{
				continue;
			}
			Vector3 position = renderer.transform.position;
			float padding = 0.35f;
			bool shouldShow = position.x >= maskBounds.min.x - padding && position.x <= maskBounds.max.x + padding && position.y >= maskBounds.min.y - padding && position.y <= maskBounds.max.y + padding;
			if (renderer.enabled != shouldShow)
			{
				renderer.enabled = shouldShow;
			}
		}
	}
}
