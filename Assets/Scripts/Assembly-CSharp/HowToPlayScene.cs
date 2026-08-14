using System.Collections.Generic;
using AmongUs.GameOptions;
using UnityEngine;

public class HowToPlayScene : MonoBehaviour
{
	public enum HowToPlayCategory
	{
		None = 0,
		GameMode_Classic = 100,
		GameMode_HideAndSeek = 101,
		Roles = 200,
		RolesSelection = 201
	}

	public static string SceneOnClose;

	[SerializeField]
	[Header("UI")]
	private GameObject startPage;

	[SerializeField]
	[Space(10f)]
	private GameObject arrows;

	[SerializeField]
	private SpriteRenderer leftButton;

	[SerializeField]
	private SpriteRenderer rightButton;

	[Space(10f)]
	[SerializeField]
	private UiElement closeButton;

	[SerializeField]
	[Space(10f)]
	private Transform dotParent;

	[SerializeField]
	private Transform dotTemplate;

	[Header("Game Mode Scenes")]
	[SerializeField]
	private AbstractHowToPlayScenePage[] classicScenes;

	[SerializeField]
	private AbstractHowToPlayScenePage[] hideAndSeekScenes;

	[SerializeField]
	[Space(10f)]
	private ConditionalHowToPlayScenePage pcMove;

	[SerializeField]
	[Header("Misc Scenes")]
	private GameObject roleSelectionScene;

	[SerializeField]
	private Transform roleButtonsParent;

	[SerializeField]
	private GameObject roleButtonPrefab;

	private HashSet<HowToPlayRoleButton> roleButtons;

	[SerializeField]
	private PassiveButton roleRightArrowButton;

	[SerializeField]
	private PassiveButton roleLeftArrowButton;

	[SerializeField]
	private List<HowToPlayRolePage> rolesScenes;

	[Header("Console Controller Navigation")]
	[SerializeField]
	private UiElement defaultButtonSelected;

	private UiElement previouslySelectedRoleButton;

	[SerializeField]
	private List<UiElement> controllerSelectables;

	private int sceneIndex;

	private int rolePageIndex;

	private Transform[] dots;

	private HowToPlayCategory category;

	public void Start()
	{
	}

	public void StartClassic()
	{
	}

	public void StartHideAndSeek()
	{
	}

	public void OpenRolesSelectionMenu()
	{
	}

	public void OpenRolesDescription()
	{
	}

	public void OpenRolePage(RoleTypes roleType)
	{
	}

	private void Reset()
	{
	}

	public void Update()
	{
	}

	private void DisableAllScenes()
	{
	}

	public void NextScene()
	{
	}

	public void PreviousScene()
	{
	}

	public void AdjustRolePage(int dir)
	{
	}

	public void Close()
	{
	}

	private void ChangeScene(int del)
	{
	}

	private bool CanClose()
	{
		return false;
	}

	private void SetupDots(int count)
	{
	}

	private void SetActiveDot(int index)
	{
	}
}
