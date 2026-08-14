using TMPro;
using UnityEngine;

public class SignInStatusComponent : MonoBehaviour
{
	private const string FRIEND_CODE_HIDDEN_TEXT = "XXXXXXXXXX";

	[SerializeField]
	private SpriteRenderer statusSprite;

	[SerializeField]
	private SpriteRenderer glowSprite;

	[SerializeField]
	private TextMeshPro friendCodeText;

	[SerializeField]
	private SpriteRenderer FriendCodeHiddenIcon;

	[SerializeField]
	private GameObject friendCodeShowToggle;

	[SerializeField]
	private GameObject friendsButton;

	[Header("Lights")]
	[SerializeField]
	private Sprite onlineSprite;

	[SerializeField]
	private Sprite pendingSprite;

	[SerializeField]
	private Sprite guestSprite;

	[SerializeField]
	private Sprite offlineSprite;

	[SerializeField]
	[Header("Glows")]
	private Sprite onlineGlow;

	[SerializeField]
	private Sprite pendingGlow;

	[SerializeField]
	private Sprite guestGlow;

	public void SetOnline()
	{
	}

	public void SetPending()
	{
	}

	public void SetGuest()
	{
	}

	public void SetOffline()
	{
	}

	public void ToggleFriendCode()
	{
	}

	private void Update()
	{
	}

	private void UpdateFriendCodeUI()
	{
	}
}
