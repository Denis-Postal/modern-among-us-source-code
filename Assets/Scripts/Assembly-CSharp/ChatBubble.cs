using TMPro;
using UnityEngine;

internal class ChatBubble : PoolableBehavior
{
	private static readonly Vector3 PlayerMessageScale;

	private static readonly Vector3 PlayerNotificationScale;

	private static readonly Vector3 VotedAndDeadMarkerPosition;

	private static readonly Vector3 VotedAndDeadMarkerPositionRight;

	public PoolablePlayer Player;

	public SpriteRenderer Xmark;

	public SpriteRenderer votedMark;

	public TextMeshPro NameText;

	public TextMeshPro TextArea;

	public SpriteRenderer Background;

	public SpriteRenderer MaskArea;

	public PlatformIdentifier PlatformIcon;

	public TextMeshPro ColorBlindName;

	private NetworkedPlayerInfo playerInfo;

	private int maskLayer;

	private float playerZ;

	public void SetLeft()
	{
	}

	public void SetNotification()
	{
	}

	public void SetWarning(string text)
	{
	}

	public void SetCosmetics(NetworkedPlayerInfo playerInfo)
	{
	}

	public void SetRight()
	{
	}

	public void SetName(string playerName, bool isDead, bool voted, Color color)
	{
	}

	public override void Reset()
	{
	}

	public void AlignChildren()
	{
	}

	internal void SetText(string chatText)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SetColorblindText()
	{
	}

	private void SetMaskLayer()
	{
	}
}
