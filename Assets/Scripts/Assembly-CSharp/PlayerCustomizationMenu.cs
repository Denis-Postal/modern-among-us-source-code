using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCustomizationMenu : MonoBehaviour
{
	public static PlayerCustomizationMenu Instance;

	public GameObject cosmicubeMenuTab;

	public CubesTab cubesTab;

	public TabButton[] Tabs;

	private int selectedTab;

	private bool cubeTabSelected;

	[SerializeField]
	private AudioClip swapTabSound;

	public PoolablePlayer PreviewArea;

	public GameObject equipButton;

	public GameObject equippedText;

	public GameObject nameplateMaskArea;

	public GameObject cubeArea;

	public GameObject cosmicubeMenu;

	public TextMeshPro itemName;

	public Action OnClose;

	public Action OnOpen;

	public GameObject AprilFoolText;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public GameObject glyphL;

	public GameObject glyphR;

	private void OnDisable()
	{
		if (Instance == this)
		{
			Instance = null;
		}
	}

	public void Start()
	{
		DestroyDuplicateMenus();
		Instance = this;
		EnsureRuntimeReferences();
		InstallTextRenderers();
		if (Tabs != null && Tabs.Length > 0)
		{
			OpenTab(Tabs[Mathf.Clamp(selectedTab, 0, Tabs.Length - 1)].Tab);
		}
		UpdateEquipState();
	}

	public void OpenTab(InventoryTab tab)
	{
		if (tab == null || Tabs == null)
		{
			return;
		}
		CloseAllTabs();
		for (int i = 0; i < Tabs.Length; i++)
		{
			TabButton tabButton = Tabs[i];
			bool selected = tabButton != null && tabButton.Tab == tab;
			if (selected)
			{
				selectedTab = i;
			}
			if (tabButton?.Button != null)
			{
				tabButton.Button.color = selected ? Color.green : Color.white;
			}
			if (tabButton?.tabText != null)
			{
				tabButton.tabText.color = selected ? Color.green : Color.white;
			}
		}
		tab.gameObject.SetActive(value: true);
		cubeTabSelected = tab == cubesTab;
		SetActive(cubeArea, cubeTabSelected);
		SetActive(cosmicubeMenuTab, cubeTabSelected);
		ColorChip defaultSelectable = tab.GetDefaultSelectable();
		if (defaultSelectable != null)
		{
			HandleSelection(tab.ColorChips, defaultSelectable);
		}
		UpdateEquipState();
		if (swapTabSound != null && SoundManager.Instance != null)
		{
			SoundManager.Instance.PlaySound(swapTabSound, loop: false);
		}
	}

	private void CloseAllTabs()
	{
		if (Tabs == null)
		{
			return;
		}
		for (int i = 0; i < Tabs.Length; i++)
		{
			if (Tabs[i]?.Tab != null)
			{
				Tabs[i].Tab.gameObject.SetActive(value: false);
			}
		}
	}

	private void HandleSelection(List<ColorChip> buttons, ColorChip selectedChip)
	{
		if (buttons != null)
		{
			for (int i = 0; i < buttons.Count; i++)
			{
				if (buttons[i] != null)
				{
					buttons[i].Deselect();
				}
			}
		}
		selectedChip?.ShowSelected();
		UpdateEquipState();
	}

	public void Open()
	{
		DestroyDuplicateMenus();
		Instance = this;
		base.gameObject.SetActive(value: true);
		EnsureRuntimeReferences();
		InstallTextRenderers();
		OnOpen?.Invoke();
		if (PreviewArea != null)
		{
			PreviewArea.SetBodyType(PlayerBodyTypes.Normal);
			PreviewArea.SetBodyCosmeticsVisible(true);
			PreviewArea.SetBodyColor(PlayerCustomization.ColorId);
			PreviewArea.SetHat(PlayerCustomization.HatId, PlayerCustomization.ColorId);
			PreviewArea.SetSkin(PlayerCustomization.SkinId, PlayerCustomization.ColorId);
			PreviewArea.SetVisor(PlayerCustomization.VisorId, PlayerCustomization.ColorId);
			PreviewArea.SetPetIdle(PlayerCustomization.PetId, PlayerCustomization.ColorId);
		}
		if (Tabs != null && Tabs.Length > 0)
		{
			OpenTab(Tabs[Mathf.Clamp(selectedTab, 0, Tabs.Length - 1)].Tab);
		}
	}

	public void Close(bool canMove)
	{
		if (canMove && (bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.moveable = true;
		}
		OnClose?.Invoke();
		DestroyObj();
	}

	public void Close()
	{
		Close(true);
	}

	private void DestroyObj()
	{
		if (Instance == this)
		{
			Instance = null;
		}
		CloseAllTabs();
		CleanupGeneratedObjects();
		UnityEngine.Object.Destroy(base.gameObject);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Close(true);
		}
	}

	public void ViewCube()
	{
		if (cubesTab != null)
		{
			cubesTab.ViewCube();
		}
		SetActive(cosmicubeMenu, true);
	}

	public void SetItemName(string text)
	{
		if (itemName != null)
		{
			itemName.text = text ?? string.Empty;
			TMPTextRendererBridge bridge = itemName.GetComponent<TMPTextRendererBridge>();
			if ((bool)bridge)
			{
				bridge.ForceSync();
			}
		}
	}

	public void ClickEquip()
	{
		InventoryTab tab = GetSelectedTab();
		if (tab != null)
		{
			tab.ClickEquip();
			UpdateEquipState();
		}
	}

	private void OnDestroy()
	{
		if (Instance == this)
		{
			Instance = null;
		}
	}

	private InventoryTab GetSelectedTab()
	{
		if (Tabs == null || Tabs.Length == 0)
		{
			return null;
		}
		return Tabs[Mathf.Clamp(selectedTab, 0, Tabs.Length - 1)].Tab;
	}

	private void EnsureRuntimeReferences()
	{
		if (PreviewArea == null)
		{
			PreviewArea = GetComponentInChildren<PoolablePlayer>(true);
		}
		if (Tabs == null || Tabs.Length == 0)
		{
			List<TabButton> rebuiltTabs = new List<TabButton>();
			InventoryTab[] inventoryTabs = GetComponentsInChildren<InventoryTab>(true);
			for (int i = 0; i < inventoryTabs.Length; i++)
			{
				if (inventoryTabs[i] is CubesTab)
				{
					continue;
				}
				rebuiltTabs.Add(new TabButton
				{
					Tab = inventoryTabs[i]
				});
			}
			if (cubesTab == null)
			{
				cubesTab = GetComponentInChildren<CubesTab>(true);
			}
			if (cubesTab != null)
			{
				rebuiltTabs.Add(new TabButton
				{
					Tab = cubesTab
				});
			}
			Tabs = rebuiltTabs.ToArray();
		}
		for (int i = 0; Tabs != null && i < Tabs.Length; i++)
		{
			InventoryTab tab = Tabs[i]?.Tab;
			if (tab == null)
			{
				continue;
			}
			if (tab.PlayerPreview == null)
			{
				tab.PlayerPreview = PreviewArea;
			}
		}
	}

	private void InstallTextRenderers()
	{
		TMP_Text[] texts = GetComponentsInChildren<TMP_Text>(true);
		for (int i = 0; i < texts.Length; i++)
		{
			TMP_Text textMeshPro = texts[i];
			if (textMeshPro == null)
			{
				continue;
			}
			TMPTextRendererBridge bridge = textMeshPro.GetComponent<TMPTextRendererBridge>();
			if (bridge == null)
			{
				bridge = textMeshPro.gameObject.AddComponent<TMPTextRendererBridge>();
			}
			bridge.Source = textMeshPro;
			bridge.Font = TextRenderer.TextFont.MainMenuOutline;
			bridge.SizeMultiplier = 1f;
			bridge.CharacterSpacing = 0.02f;
			bridge.ForceSync();
		}
	}

	private void DestroyDuplicateMenus()
	{
		PlayerCustomizationMenu[] menus = Resources.FindObjectsOfTypeAll<PlayerCustomizationMenu>();
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i] != null && menus[i] != this && menus[i].gameObject.scene.IsValid())
			{
				menus[i].CleanupGeneratedObjects();
				UnityEngine.Object.Destroy(menus[i].gameObject);
			}
		}
	}

	private void CleanupGeneratedObjects()
	{
		if (Tabs != null)
		{
			for (int i = 0; i < Tabs.Length; i++)
			{
				InventoryTab tab = Tabs[i]?.Tab;
				if (tab != null)
				{
					tab.OnDisable();
				}
			}
		}
		InventoryTab[] inventoryTabs = GetComponentsInChildren<InventoryTab>(true);
		for (int j = 0; j < inventoryTabs.Length; j++)
		{
			if (inventoryTabs[j] != null)
			{
				inventoryTabs[j].OnDisable();
			}
		}
	}

	public void UpdateEquipState()
	{
		InventoryTab tab = GetSelectedTab();
		bool equipped = tab != null && tab.IsSelectedItemEquipped();
		SetActive(equipButton, !equipped && !cubeTabSelected);
		SetActive(equippedText, equipped && !cubeTabSelected);
		if (glyphL != null)
		{
			glyphL.SetActive(Tabs != null && Tabs.Length > 1);
		}
		if (glyphR != null)
		{
			glyphR.SetActive(Tabs != null && Tabs.Length > 1);
		}
	}

	private static void SetActive(GameObject obj, bool active)
	{
		if (obj != null && obj.activeSelf != active)
		{
			obj.SetActive(active);
		}
	}
}
