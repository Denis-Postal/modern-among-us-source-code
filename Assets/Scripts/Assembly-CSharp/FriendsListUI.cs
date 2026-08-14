using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FriendsListUI : MonoBehaviour
{
	[Serializable]
	public class FriendsListTabButton
	{
		public FriendsListTab tab;

		public GameObject tabObject;

		public List<SpriteRenderer> selectedSprites;

		public bool selectable;
	}

	[Serializable]
	public enum FriendsListTab
	{
		LobbyPlayers = 0,
		RecentPlayers = 1,
		AmongUsFriends = 2,
		Blocked = 3,
		Notifications = 4,
		AddFriend = 5
	}

	public static FriendsListUI Instance;

	public TextMeshPro FriendCodeText;

	public SpriteRenderer FriendCodeHiddenIcon;

	public GameObject FriendCodeHideToggleObject;

	public FriendsListTabButton[] Tabs;

	public GameObject NotifArea;

	public GameObject BlockedArea;

	public GameObject FriendArea;

	public GameObject PlatformFriendArea;

	public GameObject LobbyPlayerArea;

	public GameObject RecentlyPlayedArea;

	public GameObject LobbyPlayersTab;

	public GameObject LobbyPlayersInactiveTab;

	public GameObject PlatformFriendsButton;

	public FriendRequestBar FriendRequestBar;

	public BlockedPlayerBar BlockedPlayerBar;

	public OnlineFriendBar OnlineFriendBar;

	public OnlineFriendBar PlatformFriendBar;

	public LobbyPlayerBar LobbyPlayerBar;

	public LobbyInviteBar LobbyInviteBar;

	public Scroller FriendsScroller;

	public Scroller PlatformFriendsScroller;

	public Scroller BlockedScroller;

	public Scroller NotifScroller;

	public Scroller LobbyScroller;

	public Scroller RecentlyPlayedScroller;

	public SpriteRenderer InactiveAllFriends;

	public SpriteRenderer InactivePlatformFriends;

	public TextBoxTMP AddFriendArea;

	public List<FriendsListGuestWarning> guestAccountWarnings;

	public float YStart;

	public float YOffset;

	public SpriteRenderer ViewRequestsButton;

	public TextMeshPro ViewRequestsText;

	public Color NewRequestColor;

	public Color NoRequestsColor;

	public GameObject AddFriendObjects;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public GameObject glyphL;

	public GameObject glyphR;

	private int selectedTab;

	private List<FriendsListBar> lobbyBars;

	private List<FriendsListBar> friendBars;

	private List<FriendsListBar> platformFriendBars;

	private List<FriendsListBar> notifBars;

	private string friendCodeHiddenText;

	private bool viewingAllFriends;

	private string currentSceneName;

	private float addFriendCooldown;

	public FriendsListTab CurrentTab => default(FriendsListTab);

	public bool IsOpen => false;

	public void Open()
	{
	}

	public void OpenTab(int tabType)
	{
	}

	public void Close(bool force = false)
	{
	}

	public virtual void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void CloseTab()
	{
	}

	public void AddFriend()
	{
	}

	public void RefreshFriends()
	{
	}

	public void RefreshPlatformFriends()
	{
	}

	public void RefreshBlockedPlayers()
	{
	}

	private void ClearNotifs()
	{
	}

	public void RefreshNotifications()
	{
	}

	public void RefreshLobbyPlayers()
	{
	}

	public void RefreshRecentlyPlayed()
	{
	}

	public void UpdateFriendBars()
	{
	}

	public void GiveFocus()
	{
	}

	public void ToggleFriendCode()
	{
	}

	public void UpdateFriendCodeUI()
	{
	}

	public void ViewAllFriends()
	{
	}

	public void ViewPlatformFriends()
	{
	}

	public void ResendGuardianEmail()
	{
	}

	public void SortSamePlatformToTop(List<FriendsListBar> friendBars)
	{
	}
}
