using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class RolesSettingsMenu : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer MaskBg;

	[SerializeField]
	private SpriteRenderer MaskArea;

	[SerializeField]
	private CategoryHeaderMasked quotaHeader;

	[SerializeField]
	private CategoryHeaderMasked advHeader;

	[SerializeField]
	private RoleSettingsTabButton roleSettingsTabButtonOrigin;

	[SerializeField]
	private RoleSettingsTabButton roleSettingsTabButtonOriginImpostor;

	[SerializeField]
	private Transform roleSettingsTabParent;

	[SerializeField]
	private Scroller roleSettingsTabScroller;

	[SerializeField]
	private RoleOptionSetting roleOptionSettingOrigin;

	[SerializeField]
	private GameObject RoleChancesSettings;

	[SerializeField]
	private CategoryHeaderEditRole categoryHeaderEditRoleOrigin;

	[SerializeField]
	private ToggleOption checkboxOrigin;

	[SerializeField]
	private NumberOption numberOptionOrigin;

	[SerializeField]
	private StringOption stringOptionOrigin;

	[SerializeField]
	private TextMeshPro roleTitleText;

	[SerializeField]
	private TextMeshPro roleDescriptionText;

	[SerializeField]
	private GameObject AdvancedRolesSettings;

	[SerializeField]
	private SpriteRenderer roleScreenshot;

	[SerializeField]
	private SpriteRenderer roleHeaderSprite;

	[SerializeField]
	private TextMeshPro roleHeaderText;

	[SerializeField]
	private Scroller scrollBar;

	[SerializeField]
	private Collider2D ButtonClickMask;

	[SerializeField]
	private Scroller roleTabsScroller;

	[SerializeField]
	private GameObject roleTabsGradient;

	[SerializeField]
	private Transform roleTabsMinPos;

	[SerializeField]
	private Transform roleTabsMaxPos;

	private List<OptionBehaviour> advancedSettingChildren;

	private List<RoleOptionSetting> roleChances;

	private List<PassiveButton> roleTabs;

	private int selectedRoleTab;

	private readonly Color glyphUnavailableColor;

	private const float ROLE_HEADER_OFFSET = 0.522f;

	private const float X_START_ROLE_HEADER = 4.986f;

	private const float X_START_CHANCE = -0.15f;

	private const float Y_START = 0.662f;

	private const float Y_OFFSET = -0.43f;

	private const float X_START = -1.928f;

	private const float X_OFFSET = 0.762f;

	private const float TAB_Y_START = 2.275f;

	private const float Y_ADVANCED_START = -0.872f;

	private const float Y_ADVANCED_OFFSET = -0.45f;

	private const float X_ADVANCED_START = 2.17f;

	private const int MASK_LAYER = 20;

	private IRoleOptionsCollection cachedData;

	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement BackButton;

	[SerializeField]
	private UiElement DefaultButtonSelected;

	[SerializeField]
	private PassiveButton AllButton;

	[SerializeField]
	private List<UiElement> ControllerSelectable;

	[SerializeField]
	private SpriteRenderer glyphL;

	[SerializeField]
	private SpriteRenderer glyphR;

	private List<UiElement> QuotaTabSelectables;

	private PassiveButton currentTabButton;

	private void Awake()
	{
	}

	private void InitialSetup()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OpenMenu(bool controllerSelected = true)
	{
	}

	public void CloseMenu()
	{
	}

	private void Update()
	{
	}

	private void AddRoleTab(RoleBehaviour role, ref float tabXPos)
	{
	}

	public void SetQuotaTab()
	{
	}

	private void CreateQuotaOption(RoleBehaviour role, ref float yPos, int index)
	{
	}

	private void ChangeTab(RoleBehaviour role, PassiveButton button)
	{
	}

	public void OpenChancesTab(bool controllerSelected = true)
	{
	}

	public void RefreshChildren()
	{
	}

	private void ValueChanged(OptionBehaviour obj)
	{
	}

	private void CreateAdvancedSettings(RoleBehaviour role)
	{
	}

	private void InitializeControllerNavigation()
	{
	}

	private void EnableTabControllerGlyphs(bool _enabled)
	{
	}
}
