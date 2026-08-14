using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(-1)]
public class MainMenuManager : MonoBehaviour
{
	public AdDataCollectScreen AdsPolicy;

	public PassiveButton PlayOnlineButton;

	public HatManager HatManagerRef;

	public CosmicubeManager CosmicubeManagerRef;

	public PlayerCustomizationMenu playerCustomizationPrefab;

	[SerializeField]
	private AnnouncementPopUp announcementPopUp;

	[SerializeField]
	private GameObject gameModeButtons;

	[SerializeField]
	private GameObject accountButtons;

	[SerializeField]
	private PassiveButton accountStatsButton;

	[SerializeField]
	private GameObject onlineButtons;

	[SerializeField]
	private PassiveButton backButtonOnline;

	[SerializeField]
	private GameObject enterCodeButtons;

	[SerializeField]
	private SpriteMask screenMask;

	[SerializeField]
	private GameObject mainMenuUI;

	[SerializeField]
	private GameObject rightPanelMask;

	[SerializeField]
	private SpriteRenderer screenTint;

	[SerializeField]
	private PassiveButton freePlayButton;

	[SerializeField]
	private PassiveButton entercodeField;

	[Header("Left panel buttons")]
	[SerializeField]
	private PassiveButton playButton;

	[SerializeField]
	private PassiveButton inventoryButton;

	[SerializeField]
	private PassiveButton shopButton;

	[SerializeField]
	private PassiveButton myAccountButton;

	[SerializeField]
	private PassiveButton newsButton;

	[SerializeField]
	private PassiveButton settingsButton;

	[SerializeField]
	private PassiveButton creditsButton;

	[SerializeField]
	private PassiveButton quitButton;

	[SerializeField]
	private FindGameButton findGameButton;

	[Header("Default right panel buttons")]
	[SerializeField]
	private PassiveButton playLocalButton;

	[SerializeField]
	private PassiveButton howToPlayButton;

	[SerializeField]
	private PassiveButton accountCTAButton;

	[SerializeField]
	private PassiveButton createGameButton;

	private List<PassiveButton> mainButtons;

	[SerializeField]
	private GameObject creditsScreen;

	[SerializeField]
	private CreateGameOptions createGameScreen;

	[SerializeField]
	private GameObject adsMenu;

	[SerializeField]
	private SpriteRenderer fullScreenSprite;

	[Header("Animations")]
	[SerializeField]
	private Transform enterCodeContainer;

	[SerializeField]
	private GameObject enterCodeHeader;

	[SerializeField]
	private Transform onlineButtonsContainer;

	[SerializeField]
	private GameObject onlineHeader;

	private const float TIME_SLIDE = 0.3f;

	private const float X_OFFSCREEN_LEFT = -8f;

	private const float X_OFFSCREEN_RIGHT = 7f;

	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public List<PassiveButton> disableOnStartup;

	[SerializeField]
	private GameObject NewStoreItemsIcon;

	private CosmicubeManager cosmicubeManager;

	private bool animating;

	private bool finishStartup;

	private bool inventoryButtonPressed;

	private void Awake()
	{
		mainButtons = new List<PassiveButton>();
		AddIfNotNull(mainButtons, playButton);
		AddIfNotNull(mainButtons, inventoryButton);
		AddIfNotNull(mainButtons, shopButton);
		AddIfNotNull(mainButtons, myAccountButton);
		AddIfNotNull(mainButtons, newsButton);
		AddIfNotNull(mainButtons, settingsButton);
		AddIfNotNull(mainButtons, creditsButton);
		AddIfNotNull(mainButtons, quitButton);
		AddIfNotNull(mainButtons, PlayOnlineButton);
		AddIfNotNull(mainButtons, playLocalButton);
		AddIfNotNull(mainButtons, howToPlayButton);
		AddIfNotNull(mainButtons, accountCTAButton);
		AddIfNotNull(mainButtons, createGameButton);
		AddIfNotNull(mainButtons, freePlayButton);
		AddIfNotNull(mainButtons, entercodeField);
		AddIfNotNull(mainButtons, backButtonOnline);
		ConnectMainMenuScreenButtonEvents();
		SetUpControllerNav();
		if (announcementPopUp != null)
		{
			announcementPopUp.SetMainMenuManager(this);
		}
		cosmicubeManager = CosmicubeManagerRef;
		if (cosmicubeManager == null && CosmicubeManager.InstanceExists)
		{
			cosmicubeManager = CosmicubeManager.Instance;
		}
	}

	public void Start()
	{
		CheckAddOns();
		ResetScreen();
		CheckNewItems();
		StartCoroutine(RunStartUp());
	}

	public void ResetScreen()
	{
		animating = false;
		ActivateMainMenuUI();
		SetActive(gameModeButtons, false);
		SetActive(accountButtons, false);
		SetActive(onlineButtons, false);
		SetActive(enterCodeButtons, false);
		SetActive(creditsScreen, false);
		SetActive(adsMenu, false);
		SetActive(onlineHeader, false);
		SetActive(enterCodeHeader, false);
		if (createGameScreen != null)
		{
			createGameScreen.gameObject.SetActive(false);
		}
		SetPanelX(onlineButtonsContainer, 0f);
		SetPanelX(enterCodeContainer, X_OFFSCREEN_RIGHT);
		SetActive(fullScreenSprite == null ? null : fullScreenSprite.gameObject, false);
	}

	public void OpenGameModeMenu()
	{
		if (animating)
		{
			return;
		}
		ActivateMainMenuUI();
		SetActive(gameModeButtons, true);
		SetActive(accountButtons, false);
		SetActive(onlineButtons, false);
		SetActive(enterCodeButtons, false);
		SetActive(creditsScreen, false);
		SetActive(onlineHeader, false);
		SetActive(enterCodeHeader, false);
		if (createGameScreen != null)
		{
			createGameScreen.gameObject.SetActive(false);
		}
		SetPanelX(onlineButtonsContainer, 0f);
		SetPanelX(enterCodeContainer, X_OFFSCREEN_RIGHT);
		SetUpControllerNav();
	}

	public void OpenCreateGame()
	{
		if (!animating)
		{
			StartCoroutine(ShowCreateGameCo());
		}
	}

	private IEnumerator ShowCreateGameCo()
	{
		animating = true;
		DeactivateMainMenuUI();
		if (createGameScreen != null)
		{
			createGameScreen.gameObject.SetActive(true);
			createGameScreen.Show();
		}
		yield return null;
		animating = false;
	}

	public void GoBackCreateGame()
	{
		if (!animating)
		{
			StartCoroutine(GoBackCreateGameCo());
		}
	}

	private IEnumerator GoBackCreateGameCo()
	{
		animating = true;
		if (createGameScreen != null)
		{
			createGameScreen.Close();
			createGameScreen.gameObject.SetActive(false);
		}
		OpenGameModeMenu();
		yield return null;
		animating = false;
	}

	public void OpenOnlineMenu()
	{
		if (animating)
		{
			return;
		}
		ActivateMainMenuUI();
		SetActive(gameModeButtons, false);
		SetActive(accountButtons, false);
		SetActive(onlineButtons, true);
		SetActive(onlineHeader, true);
		SetActive(enterCodeButtons, false);
		SetActive(enterCodeHeader, false);
		SetPanelX(onlineButtonsContainer, 0f);
		SetPanelX(enterCodeContainer, X_OFFSCREEN_RIGHT);
		SetControllerDefault(backButtonOnline);
	}

	public void OpenEnterCodeMenu(bool animate)
	{
		if (animating)
		{
			return;
		}
		SetActive(enterCodeButtons, true);
		SetActive(enterCodeHeader, true);
		SetActive(onlineHeader, false);
		if (animate)
		{
			StartCoroutine(AnimateEnterCodeSlideCo());
		}
		else
		{
			SetPanelX(onlineButtonsContainer, X_OFFSCREEN_LEFT);
			SetPanelX(enterCodeContainer, 0f);
		}
		SetControllerDefault(entercodeField);
	}

	private IEnumerator AnimateEnterCodeSlideCo()
	{
		animating = true;
		Vector3 startPosEnterCode = GetLocalPosition(enterCodeContainer);
		Vector3 endPosEnterCode = startPosEnterCode;
		endPosEnterCode.x = 0f;
		Vector3 startPosOnline = GetLocalPosition(onlineButtonsContainer);
		Vector3 endPosOnline = startPosOnline;
		endPosOnline.x = X_OFFSCREEN_LEFT;
		float timer = 0f;
		while (timer < TIME_SLIDE)
		{
			timer += Time.deltaTime;
			float t = Mathf.Clamp01(timer / TIME_SLIDE);
			SetLocalPosition(enterCodeContainer, Vector3.Lerp(startPosEnterCode, endPosEnterCode, t));
			SetLocalPosition(onlineButtonsContainer, Vector3.Lerp(startPosOnline, endPosOnline, t));
			yield return null;
		}
		SetLocalPosition(enterCodeContainer, endPosEnterCode);
		SetLocalPosition(onlineButtonsContainer, endPosOnline);
		animating = false;
	}

	public void ClickBackEnterCode()
	{
		if (!animating)
		{
			StartCoroutine(AnimateEnterCodeExitSlideCo());
		}
	}

	private IEnumerator AnimateEnterCodeExitSlideCo()
	{
		animating = true;
		SetActive(onlineButtons, true);
		SetActive(onlineHeader, true);
		SetActive(enterCodeHeader, false);
		Vector3 startPosEnterCode = GetLocalPosition(enterCodeContainer);
		Vector3 endPosEnterCode = startPosEnterCode;
		endPosEnterCode.x = X_OFFSCREEN_RIGHT;
		Vector3 startPosOnline = GetLocalPosition(onlineButtonsContainer);
		Vector3 endPosOnline = startPosOnline;
		endPosOnline.x = 0f;
		float timer = 0f;
		while (timer < TIME_SLIDE)
		{
			timer += Time.deltaTime;
			float t = Mathf.Clamp01(timer / TIME_SLIDE);
			SetLocalPosition(enterCodeContainer, Vector3.Lerp(startPosEnterCode, endPosEnterCode, t));
			SetLocalPosition(onlineButtonsContainer, Vector3.Lerp(startPosOnline, endPosOnline, t));
			yield return null;
		}
		SetLocalPosition(enterCodeContainer, endPosEnterCode);
		SetLocalPosition(onlineButtonsContainer, endPosOnline);
		SetActive(enterCodeButtons, false);
		animating = false;
		SetControllerDefault(backButtonOnline);
	}

	public void ClickBackOnline()
	{
		OpenGameModeMenu();
	}

	public void OpenFindGame()
	{
		if (findGameButton != null)
		{
			findGameButton.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
		}
	}

	public void OpenAccountMenu()
	{
		if (AccountManager.InstanceExists)
		{
			AccountManager.Instance.OpenAccountWindow();
		}
	}

	public void OpenCredits()
	{
		DeactivateMainMenuUI();
		SetActive(creditsScreen, true);
	}

	public void CheckNewItems()
	{
		SetActive(NewStoreItemsIcon, false);
	}

	private IEnumerator RunStartUp()
	{
		if (AdsPolicy != null)
		{
			yield return AdsPolicy.Show();
		}
		if (announcementPopUp != null)
		{
			yield return announcementPopUp.ShowIfNew();
		}
		finishStartup = true;
	}

	private void CheckAddOns()
	{
		if (HatManagerRef != null)
		{
			HatManagerRef.Initialize();
		}
		if (CosmicubeManagerRef != null)
		{
			CosmicubeManagerRef.Initialize();
			cosmicubeManager = CosmicubeManagerRef;
		}
	}

	private void LateUpdate()
	{
		if (finishStartup)
		{
			finishStartup = false;
			SetUpControllerNav();
		}
	}

	private void Update()
	{
		PollInventoryButtonFallback();
	}

	public void TransitionToInventory()
	{
		PlayerCustomizationMenu menu = GetOrCreatePlayerCustomizationMenu();
		if (menu != null)
		{
			menu.gameObject.name = "PlayerCustomizationMenu";
			menu.OnClose -= ResetScreen;
			menu.OnClose += ResetScreen;
			DeactivateMainMenuUI();
			menu.Open();
		}
		else
		{
			Debug.LogWarning("PlayerCustomizationMenu prefab was not found.");
		}
	}

	private PlayerCustomizationMenu GetOrCreatePlayerCustomizationMenu()
	{
		PlayerCustomizationMenu menu = PlayerCustomizationMenu.Instance;
		if (menu != null)
		{
			return menu;
		}
		menu = FindObjectOfType<PlayerCustomizationMenu>(true);
		if (menu != null)
		{
			return menu;
		}
		if (playerCustomizationPrefab != null)
		{
			return Instantiate(playerCustomizationPrefab);
		}
#if UNITY_EDITOR
		GameObject prefabObject = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/PlayerCustomizationMenu.prefab");
		if (prefabObject != null)
		{
			PlayerCustomizationMenu prefab = prefabObject.GetComponent<PlayerCustomizationMenu>();
			if (prefab != null)
			{
				return Instantiate(prefab);
			}
		}
#endif
		return null;
	}

	private void PollInventoryButtonFallback()
	{
		if (inventoryButton == null || !IsMainMenuActive())
		{
			inventoryButtonPressed = false;
			return;
		}
		if (Input.GetMouseButtonDown(0))
		{
			inventoryButtonPressed = IsPointerOverButton(inventoryButton);
		}
		if (Input.GetMouseButtonUp(0))
		{
			bool shouldOpen = inventoryButtonPressed && IsPointerOverButton(inventoryButton);
			inventoryButtonPressed = false;
			if (shouldOpen)
			{
				TransitionToInventory();
			}
		}
	}

	private bool IsPointerOverButton(PassiveButton button)
	{
		if (button == null || Camera.main == null)
		{
			return false;
		}
		Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 point = new Vector2(worldPoint.x, worldPoint.y);
		if (button.ClickMask != null && !button.ClickMask.OverlapPoint(point))
		{
			return false;
		}
		Collider2D[] colliders = button.Colliders;
		if (colliders == null || colliders.Length == 0)
		{
			colliders = button.GetComponents<Collider2D>();
		}
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i] != null && colliders[i].isActiveAndEnabled && colliders[i].OverlapPoint(point))
			{
				return true;
			}
		}
		return false;
	}

	public void TransitionToShop()
	{
		DeactivateMainMenuUI();
		StoreMenu storeMenu = FindObjectOfType<StoreMenu>();
		if (storeMenu != null)
		{
			storeMenu.OpenGeneralShop();
		}
	}

	public bool IsMainMenuActive()
	{
		return mainMenuUI == null || mainMenuUI.activeInHierarchy;
	}

	private void ActivateMainMenuUI()
	{
		SetActive(mainMenuUI, true);
		SetActive(rightPanelMask, true);
		SetActive(screenMask == null ? null : screenMask.gameObject, true);
		SetActive(screenTint == null ? null : screenTint.gameObject, true);
	}

	private void DeactivateMainMenuUI()
	{
		SetActive(mainMenuUI, false);
		SetActive(gameModeButtons, false);
		SetActive(accountButtons, false);
		SetActive(onlineButtons, false);
		SetActive(enterCodeButtons, false);
		SetActive(onlineHeader, false);
		SetActive(enterCodeHeader, false);
	}

	private void SetUpControllerNav()
	{
		if (ControllerSelectable == null)
		{
			ControllerSelectable = new List<UiElement>();
		}
		ControllerSelectable.Clear();
		AddSelectable(playButton);
		AddSelectable(inventoryButton);
		AddSelectable(shopButton);
		AddSelectable(myAccountButton);
		AddSelectable(newsButton);
		AddSelectable(settingsButton);
		AddSelectable(creditsButton);
		AddSelectable(quitButton);
		AddSelectable(playLocalButton);
		AddSelectable(PlayOnlineButton);
		AddSelectable(createGameButton);
		AddSelectable(freePlayButton);
		AddSelectable(howToPlayButton);
		AddSelectable(accountCTAButton);
		AddSelectable(backButtonOnline);
		AddSelectable(entercodeField);
		if (DefaultButtonSelected == null)
		{
			DefaultButtonSelected = playButton;
		}
		SetControllerDefault(DefaultButtonSelected);
	}

	private void ConnectMainMenuScreenButtonEvents()
	{
		AddListener(playButton, OpenGameModeMenu);
		AddListener(PlayOnlineButton, OpenOnlineMenu);
		AddListener(createGameButton, OpenCreateGame);
		AddListener(backButtonOnline, ClickBackOnline);
		AddListener(entercodeField, delegate
		{
			OpenEnterCodeMenu(true);
		});
		AddListener(inventoryButton, TransitionToInventory);
		AddListener(shopButton, TransitionToShop);
		AddListener(myAccountButton, OpenAccountMenu);
		AddListener(accountCTAButton, OpenAccountMenu);
		AddListener(newsButton, OpenNews);
		AddListener(settingsButton, OpenSettings);
		AddListener(howToPlayButton, OpenHowToPlay);
		AddListener(creditsButton, OpenCredits);
		AddListener(quitButton, Application.Quit);
	}

	private void AddListener(PassiveButton button, UnityEngine.Events.UnityAction action)
	{
		if (button == null || action == null)
		{
			return;
		}
		if (button.OnClick == null)
		{
			button.OnClick = new UnityEngine.UI.Button.ButtonClickedEvent();
		}
		button.OnClick.AddListener(action);
	}

	private void OpenNews()
	{
		if (announcementPopUp != null)
		{
			announcementPopUp.Show();
		}
	}

	private void OpenSettings()
	{
		OptionsMenuBehaviour optionsMenu = FindObjectOfType<OptionsMenuBehaviour>(true);
		if (optionsMenu != null)
		{
			optionsMenu.Open();
		}
	}

	private void OpenHowToPlay()
	{
		SceneChanger.ChangeScene("HowToPlay");
	}

	private void AddSelectable(UiElement element)
	{
		if (element != null && !ControllerSelectable.Contains(element))
		{
			ControllerSelectable.Add(element);
		}
	}

	private void SetControllerDefault(UiElement element)
	{
		if (element != null)
		{
			DefaultButtonSelected = element;
		}
		if (ControllerManager.Instance != null)
		{
			ControllerManager.Instance.SetDefaultSelection(DefaultButtonSelected, ControllerSelectable);
		}
	}

	private void EnableMainButtons(bool enabled)
	{
		if (mainButtons == null)
		{
			return;
		}
		for (int i = 0; i < mainButtons.Count; i++)
		{
			if (mainButtons[i] != null)
			{
				mainButtons[i].SetButtonEnableState(enabled);
			}
		}
		if (disableOnStartup == null)
		{
			return;
		}
		for (int j = 0; j < disableOnStartup.Count; j++)
		{
			if (disableOnStartup[j] != null)
			{
				disableOnStartup[j].SetButtonEnableState(!enabled);
			}
		}
	}

	private void AddIfNotNull(List<PassiveButton> buttons, PassiveButton button)
	{
		if (button != null && !buttons.Contains(button))
		{
			buttons.Add(button);
		}
	}

	private void SetActive(GameObject obj, bool active)
	{
		if (obj != null && obj.activeSelf != active)
		{
			obj.SetActive(active);
		}
	}

	private void SetPanelX(Transform target, float x)
	{
		if (target == null)
		{
			return;
		}
		Vector3 localPosition = target.localPosition;
		localPosition.x = x;
		target.localPosition = localPosition;
	}

	private Vector3 GetLocalPosition(Transform target)
	{
		if (target == null)
		{
			return Vector3.zero;
		}
		return target.localPosition;
	}

	private void SetLocalPosition(Transform target, Vector3 position)
	{
		if (target != null)
		{
			target.localPosition = position;
		}
	}
}
