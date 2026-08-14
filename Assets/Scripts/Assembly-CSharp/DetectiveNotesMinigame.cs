using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectiveNotesMinigame : Minigame
{
	[SerializeField]
	private AudioClip[] scribbleSFXs;

	[SerializeField]
	private Transform tabsParent;

	[SerializeField]
	private GameObject tabPrefab;

	[SerializeField]
	private TMP_Text victimName;

	[SerializeField]
	private TMP_Text victimColorBlindText;

	[SerializeField]
	private TMP_Text victimPreposition;

	[SerializeField]
	private TMP_Text victimLocation;

	[SerializeField]
	private DetectiveNotesSuspectContainer[] suspectContainers;

	[SerializeField]
	private GameObject InterrogationsParent;

	[SerializeField]
	private GameObject NoPagesParent;

	[SerializeField]
	private GameObject noSuspectsPostIt;

	[SerializeField]
	private SpriteRenderer bodyMaterial;

	[SerializeField]
	private PassiveButton prepositionPopup;

	[SerializeField]
	private PassiveButton impostorTypePopup;

	[SerializeField]
	private Transform impostorTypeParent;

	[SerializeField]
	private Sprite defaultBodySprite;

	[SerializeField]
	private TMP_Text impostorTypeText;

	[SerializeField]
	private GameObject impostorTypePrefab;

	[SerializeField]
	private GameObject mapFadeBackground;

	[SerializeField]
	private PassiveButton closeButton;

	[Header("Console Controller Navigation")]
	[SerializeField]
	private List<UiElement> ControllerSelectable;

	[SerializeField]
	private List<UiElement> PrepositionSelectable;

	private List<UiElement> ImpostorIconControllerSelectables;

	[SerializeField]
	private SpriteRenderer glyphL;

	[SerializeField]
	private SpriteRenderer glyphR;

	private readonly string MainOverlay;

	private readonly string PrepositionOverlay;

	private readonly string ImpostorOverlay;

	private List<DetectiveNotesTab> tabs;

	private int currentPageIndex;

	private float suspectsWidth;

	private DetectiveRole associatedDetective;

	private DeadBody inspectedBody;

	private List<GameObject> impostorButton;

	public Dictionary<Color, Material> bodyColorMaterials;

	private bool notesSetup;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task = null)
	{
	}

	public override void Close()
	{
	}

	private void SetUpCurrentPage()
	{
	}

	public void OpenVictimLocationMap()
	{
	}

	public void CloseVictimLocationMap()
	{
	}

	public void SetVictimLocation(string _locationName)
	{
	}

	public void SetPrepositionPopup(bool active)
	{
	}

	public void SetImpostorPopup(bool active)
	{
	}

	public void SetImpostorType(string impostorString)
	{
	}

	public void SetVictimPreposition(string _preposition)
	{
	}

	public void ChangePage(int dir)
	{
	}

	public void SetPage(int index)
	{
	}

	public void GenerateNewPage(DetectiveRole detective, NetworkedPlayerInfo victimPlayer)
	{
	}

	public void OpenExistingPage(DetectiveRole detective, DetectiveNotesPageInfo pageInfo)
	{
	}

	private void SetupTabs()
	{
	}

	public void SetAssociatedDetective(DetectiveRole detective)
	{
	}

	public void ClearTabHighlights()
	{
	}

	public void MapClosed()
	{
	}

	private void CreateBodyMaterials()
	{
	}
}
