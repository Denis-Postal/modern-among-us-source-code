using TMPro;
using UnityEngine;

public class ChatModeToggle : MonoBehaviour, IChatModeDisplay
{
	public SpriteRenderer quickChatBackgroundSprite;

	public SpriteRenderer freeChatBackgroundSprite;

	public TextMeshPro infoText;

	public TextMeshPro warningText;

	private float warningTimer;

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void ClickQuickChat()
	{
	}

	public void ClickFreeChat()
	{
	}

	public void UpdateDisplay()
	{
	}
}
