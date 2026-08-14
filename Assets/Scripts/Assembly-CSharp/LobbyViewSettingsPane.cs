using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyViewSettingsPane : MonoBehaviour
{
	[SerializeField]
	private PassiveButton rolesTabButton;

	[SerializeField]
	private PassiveButton taskTabButton;

	[SerializeField]
	private ViewSettingsInfoPanel infoPanelOrigin;

	[SerializeField]
	private Scroller scrollBar;

	[SerializeField]
	private CategoryHeaderMasked categoryHeaderOrigin;

	[SerializeField]
	private CategoryHeaderRoleVariant categoryHeaderRoleOrigin;

	[SerializeField]
	private ViewSettingsInfoPanelRoleVariant infoPanelRoleOrigin;

	[SerializeField]
	private AdvancedRoleViewPanel advancedRolePanelOrigin;

	[SerializeField]
	private PassiveButton backButton;

	[SerializeField]
	private Transform settingsContainer;

	[SerializeField]
	private SpriteRenderer backgroundMask;

	[SerializeField]
	private SpriteRenderer areaMask;

	[SerializeField]
	private TextMeshPro gameModeText;

	private const float START_POS_Y = 1.44f;

	private const float START_POS_X = -8.95f;

	private const float START_POS_X_ROLES = -6.53f;

	private const float START_POS_Y_ROLES = 0.95f;

	private const float START_POS_X_ROLES_ADVANCED = -5.8f;

	private const float SPACING_X = 5.95f;

	private const float SPACING_Y = 0.85f;

	private const float SPACING_Y_ROLES = 0.664f;

	private const float HEADER_SPACING_Y = 1.05f;

	private const float HEADER_START_X = -9.77f;

	private const float HEADER_SPACING_Y_ROLES = 0.696f;

	private const int MASK_LAYER = 61;

	private List<GameObject> settingsInfo;

	private StringNames currentTab;

	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement BackButton;

	[SerializeField]
	private UiElement DefaultButtonSelected;

	[SerializeField]
	private List<UiElement> ControllerSelectable;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void ChangeTab(StringNames category)
	{
	}

	public void SetTab()
	{
	}

	public void RefreshTab()
	{
	}

	private void DrawRolesTab()
	{
	}

	private void DrawNormalTab()
	{
	}
}
