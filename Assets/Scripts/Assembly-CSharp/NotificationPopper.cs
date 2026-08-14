using System.Collections.Generic;
using AmongUs.GameOptions;
using UnityEngine;

public class NotificationPopper : MonoBehaviour
{
	[SerializeField]
	private LobbyNotificationMessage notificationMessageOrigin;

	[SerializeField]
	private Sprite playerDisconnectSprite;

	[SerializeField]
	private Sprite settingsChangeSprite;

	[SerializeField]
	private AudioClip playerDisconnectSound;

	[SerializeField]
	private AudioClip settingsChangeSound;

	[SerializeField]
	private float spacingY;

	[SerializeField]
	private int maxMessages;

	[SerializeField]
	private Color disconnectColor;

	[SerializeField]
	private Color settingsChangeColor;

	[SerializeField]
	private AspectPosition aspectPosition;

	private List<LobbyNotificationMessage> activeMessages;

	private int lastMessageKey;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void AddDisconnectMessage(string item)
	{
	}

	public void AddSettingsChangeMessage(StringNames key, string value, bool playSound = true, RoleTypes associatedRole = RoleTypes.Crewmate)
	{
	}

	public void AddRoleSettingsChangeMessage(StringNames key, int roleCount, int roleChance, RoleTeamTypes teamType, bool playSound = true)
	{
	}

	private void SettingsChangeMessageLogic(StringNames key, string item, bool playSound)
	{
	}

	private void AddMessageToQueue(LobbyNotificationMessage newMessage)
	{
	}

	private void ShiftMessages()
	{
	}

	private void OnMessageDestroy(LobbyNotificationMessage m)
	{
	}
}
