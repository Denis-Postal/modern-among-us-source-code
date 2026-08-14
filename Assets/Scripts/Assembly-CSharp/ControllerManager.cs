using System;
using System.Collections.Generic;
using System.Diagnostics;
using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(-10)]
public class ControllerManager : MonoBehaviour
{
	public static ControllerManager Instance;

	[HideInInspector]
	[SerializeField]
	private int playerId;

	[SerializeField]
	private Player player;

	private const string DISCONNECT_POPUP_MENUNAME = "DisconnectPopup_Real";

	private const float DELTA_SINCE_LAST_BUTTON_HIGHLIGHT_THRESHOLD = 0.25f;

	private const float DELTA_SINCE_LAST_SLIDER_MOVEMENT_THRESHOLD = 0.1f;

	private bool inputDetectedLastFrame;

	[SerializeField]
	private GameObject PrefabMouseCursorForConsole;

	private GameObject ConsoleMouse;

	[HideInInspector]
	public bool IsButtonHeld;

	public ControllerUiElementsState CurrentUiState;

	public List<ControllerUiElementsState> CurrentUiStateStack;

	private float deltaSinceLastUiHighlight;

	private bool disabledVirtualCursor;

	private int frameDelaySinceInputChanged;

	private Dictionary<Vector2, AxisDirection> directions;

	private readonly Logger logger;

	private string currentScene;

	public bool IsUiControllerActive => false;

	private void Awake()
	{
	}

	private void SceneManager_activeSceneChanged(Scene from, Scene to)
	{
	}

	private void SceneManager_sceneUnloaded(Scene scene)
	{
	}

	private void Start()
	{
	}

	public bool IsMenuActiveAtAll(string menuName)
	{
		return false;
	}

	private void OnInputTypeChanged()
	{
	}

	public void NewScene(string menuName, UiElement backButton, UiElement defaultSelection, List<UiElement> selectableElements, bool gridNav = false)
	{
	}

	public void OpenOverlayMenu(string menuName, UiElement backButton)
	{
	}

	public void OpenOverlayMenu(string menuName, UiElement backButton, UiElement defaultSelection)
	{
	}

	public void OpenOverlayMenu(string menuName, UiElement backButton, UiElement defaultSelection, List<UiElement> selectableElements, bool gridNav = false)
	{
	}

	public ControllerUiElementsState GetMenu(string menuName)
	{
		return null;
	}

	public void OpenSpecificMenu(string menuNameToOpen)
	{
	}

	private void OpenTopmostMenu()
	{
	}

	public void SetUpSelectables(ControllerUiElementsState state, UiElement defaultSelection, List<UiElement> selectables)
	{
	}

	public void SetDefaultSelection(UiElement defaultSelection, List<UiElement> selectableElements = null)
	{
	}

	public void SetBackButton(UiElement backButton)
	{
	}

	public void UnsetBackButton(UiElement backButton)
	{
	}

	public void AddSelectableUiElement(UiElement uiElement, bool forceSelect = false)
	{
	}

	public void RemoveSelectableUiElement(UiElement uiElement)
	{
	}

	public void AddSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu)
	{
	}

	public void RemoveSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu)
	{
	}

	public void ClearDestroyedSelectableUiElements()
	{
	}

	public void ClearDestroyedSelectableUiElements(ControllerUiElementsState state)
	{
	}

	public void CloseOverlayMenu(string menuName)
	{
	}

	public void CloseAndResetAll()
	{
	}

	public void ResetAll()
	{
	}

	private void Update()
	{
	}

	private AxisDirection FindClosestDirection(Vector2 direction)
	{
		return default(AxisDirection);
	}

	private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2, Vector2 direction)
	{
		return 0f;
	}

	private UiElement FindUiElementByRaycast(Vector2 origin, Vector2 direction, float radius)
	{
		return null;
	}

	private UiElement FindUiElementByExplicitNavigation(UiElement start, UiElement from, AxisDirection direction)
	{
		return null;
	}

	private UiElement FindUiElementByGridDirection(Vector2 origin, AxisDirection direction, float orthogonalOffsetThreshold)
	{
		return null;
	}

	[Obsolete("FindUiElementByDistance is deprecated, please use FindUiElementByGridDirection instead.")]
	private UiElement FindUiElementByDistance(Vector2 origin, AxisDirection direction)
	{
		return null;
	}

	private void VerticalAxisInputForSlideBar(float v, SlideBar slideBar, bool dpadDetected)
	{
	}

	private void HorizontalAxisInputForSlideBar(float h, SlideBar slideBar, bool dpadDetected)
	{
	}

	private void HighlightSelection(UiElement selection)
	{
	}

	public void SetCurrentSelected(UiElement selection)
	{
	}

	public void PickTopSelectable()
	{
	}

	[Conditional("DEBUG")]
	public void PrintSelectableUiList()
	{
	}

	[Conditional("DEBUG")]
	public void ClearSelectableUiList()
	{
	}
}
