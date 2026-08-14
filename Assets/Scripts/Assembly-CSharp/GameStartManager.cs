using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class GameStartManager : DestroyableSingleton<GameStartManager>, IDisconnectHandler
{
	private enum StartingStates
	{
		NotStarting = 0,
		Countdown = 1,
		Starting = 2
	}

	[SerializeField]
	private List<MapIconByName> AllMapIcons;

	private IGameOptions cachedData;

	private const float CountdownDuration = 5.0001f;

	public int MinPlayers;

	public TextMeshPro PlayerCounter;

	private int LastPlayerCount;

	public GameObject GameSizePopup;

	public GameObject GameRoomButton;

	public GameObject RoomCodeHeader;

	public GameObject LocalLabel;

	public TextMeshPro GameRoomNameCode;

	public SpriteRenderer MapImage;

	public LobbyBehaviour LobbyPrefab;

	public GameObject GameStartTextParent;

	public TextMeshPro GameStartText;

	public SpriteRenderer StartButtonClient;

	public TextMeshPro GameStartTextClient;

	public ActionMapGlyphDisplay StartButtonGlyph;

	public GameObject StartButtonGlyphContainer;

	public TextMeshPro RulesPresetText;

	public GameObject HostInfoPanelButtons;

	public GameObject ClientInfoPanelButtons;

	public TextMeshPro privatePublicPanelText;

	public SpriteRenderer ShareOnDiscordButton;

	public GameObject InviteFriendsButton;

	private StartingStates startState;

	private float countDownTimer;

	[SerializeField]
	private PassiveButton StartButton;

	[SerializeField]
	private GameObject RulesViewPanel;

	[SerializeField]
	private GameObject RulesEditPanel;

	[SerializeField]
	private HostInfoPanel HostInfoPanel;

	[SerializeField]
	private PassiveButton EditButton;

	[SerializeField]
	private Vector3 GameOptionsPosition;

	[SerializeField]
	private GameObject PlayerOptionsMenu;

	[SerializeField]
	private GameObject HostPrivacyButtons;

	[SerializeField]
	private PassiveButton HostPublicButton;

	[SerializeField]
	private PassiveButton HostPrivateButton;

	[SerializeField]
	private GameObject ClientPrivacyValue;

	[SerializeField]
	private LobbyInfoPane LobbyInfoPane;

	[SerializeField]
	private AudioClip lobbyViewPanelOpenSound;

	[SerializeField]
	private AudioClip lobbyViewPanelCloseSound;

	[SerializeField]
	private AudioClip gameStartSound;

	[SerializeField]
	private PassiveButton HostViewButton;

	[SerializeField]
	private PassiveButton ClientViewButton;

	public bool IsPersistent => false;

	public void Start()
	{
	}

	private void DoHostSetup()
	{
	}

	public override void OnDestroy()
	{
	}

	public void ClickEdit()
	{
	}

	private void UpdateStreamerModeUI()
	{
	}

	public void MakePublic()
	{
	}

	public void ShareGameInvite()
	{
	}

	private int GetRoleRateChange(IGameOptions cachedOpts, out int roleStringName, out int chance, out int count, out RoleTeamTypes team)
	{
		roleStringName = default(int);
		chance = default(int);
		count = default(int);
		team = default(RoleTeamTypes);
		return 0;
	}

	private void CheckSettingsDiffs()
	{
	}

	public void Update()
	{
	}

	public void ResetStartState()
	{
	}

	public void SetStartCounter(sbyte sec)
	{
	}

	public void BeginGame()
	{
	}

	public void ReallyBegin(bool neverShow)
	{
	}

	public void FinallyBegin()
	{
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}

	public void ShowInviteMenu()
	{
	}

	public void ToggleButtonGlyphs(bool enabled)
	{
	}

	public void UpdateMapImage(MapNames map)
	{
	}

	public void ToggleViewPane()
	{
	}

	public void SelectViewButton(bool selected)
	{
	}

	public void UpdateHostPanelImage(NetworkedPlayerInfo player)
	{
	}

	public void CloseGameOptionsMenus()
	{
	}
}
