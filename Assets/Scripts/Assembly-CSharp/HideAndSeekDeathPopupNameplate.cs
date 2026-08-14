using TMPro;
using UnityEngine;

public class HideAndSeekDeathPopupNameplate : MonoBehaviour
{
	[SerializeField]
	[Header("Nameplate")]
	private PoolablePlayer playerIcon;

	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	[Header("Text")]
	private TextMeshPro nameText;

	[SerializeField]
	private TextMeshPro levelText;

	public void SetPlayer(PlayerControl player)
	{
	}

	public void SetPlayer(NetworkedPlayerInfo playerInfo)
	{
	}

	private void SetMaskLayer(int maskLayer)
	{
	}
}
