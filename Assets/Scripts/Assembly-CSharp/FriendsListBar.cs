using System.Collections.Generic;
using InnerNet;
using TMPro;
using UnityEngine;

public class FriendsListBar : MonoBehaviour
{
	public TextMeshPro SenderName;

	public List<PassiveButton> ControllerSelectable;

	public ClientData ClientData;

	public List<PassiveButton> Buttons;

	public SpriteRenderer InactiveSprite;

	public PlatformIdentifier PlatformIdentifier;

	public FriendsListManager.PlatformFriend PlatformFriendData;

	public PassiveButton PlatformProfileButton;

	protected float actionCooldown;

	protected string puid;

	protected string friendCode;

	protected FriendsListUI parentUI;

	private void Start()
	{
	}

	public virtual void SetUp(string puid, FriendsListUI parentUI, string friendCode, string playerInGameName)
	{
	}

	public void GetAndSetPlatform()
	{
	}

	public void SetPlatform(Platforms p, string name)
	{
	}

	private void Update()
	{
	}

	public bool CanUseApi()
	{
		return false;
	}

	protected void GoInactive()
	{
	}

	protected void GoActive()
	{
	}

	public void PlatformViewProfile()
	{
	}
}
