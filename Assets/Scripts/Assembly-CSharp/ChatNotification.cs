using TMPro;
using UnityEngine;

public class ChatNotification : MonoBehaviour
{
	[SerializeField]
	private PoolablePlayer player;

	[SerializeField]
	private TextMeshPro chatText;

	[SerializeField]
	private TextMeshPro playerNameText;

	[SerializeField]
	private TextMeshPro playerColorText;

	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	private SpriteRenderer maskArea;

	private float timeOnScreen;

	private const int maskLayer = 55;

	private void Awake()
	{
	}

	public void SetUp(PlayerControl sender, string text)
	{
	}

	public void SetCosmetics(NetworkedPlayerInfo playerInfo)
	{
	}

	private void SetMaskLayer()
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}
}
