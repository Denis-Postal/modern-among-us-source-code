using System.Collections.Generic;
using InnerNet;
using TMPro;
using UnityEngine;

public class LobbyPlayerBar : FriendsListBar
{
	public TextMeshPro InGameName;

	public SpriteRenderer AddFriendButton;

	public SpriteRenderer BlockButton;

	public Sprite BlockedSprite;

	public Sprite FriendSprite;

	public SpriteRenderer StatusSpriteRen;

	private bool IsFriend;

	private bool IsBlocked;

	public UiElement ViewProfileButton;

	public List<PassiveButton> ButtonsToDisableForSelf;

	public override void SetUp(string puid, FriendsListUI parentUI, string friendCode, string playerInGameName)
	{
	}

	public void CheckAddFriend()
	{
	}

	public void AddFriend()
	{
	}

	public void CheckBlockPlayer()
	{
	}

	public void BlockPlayer()
	{
	}

	private void DisableButton(SpriteRenderer button)
	{
	}

	private void UpdateStatus()
	{
	}

	public void SetInfoFromClient(ClientData clientData)
	{
	}

	public void DisableButtonsForLocalPlayer()
	{
	}
}
