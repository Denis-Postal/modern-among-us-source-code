using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FriendListNotification : MonoBehaviour
{
	public enum IconType
	{
		Friend = 0,
		Block = 1,
		LobbyInvite = 2,
		Failed = 3,
		Sent = 4
	}

	[Serializable]
	public class FriendNotificationIcon
	{
		public IconType type;

		public Sprite icon;

		public float scale;

		public Vector2 offset;
	}

	public List<FriendNotificationIcon> IconTypes;

	public SpriteRenderer Icon;

	public TextMeshPro Text;

	private float timeOnScreen;

	public void SetUp(string text, IconType type)
	{
	}

	private void Update()
	{
	}
}
