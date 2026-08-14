using TMPro;
using UnityEngine;

public class LogEntryBubble : PoolableBehavior
{
	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	private SpriteRenderer maskArea;

	[SerializeField]
	private PoolablePlayer player;

	[SerializeField]
	private TextMeshPro text;

	public void DecorateLog(SecurityLogBehaviour.SecurityLogEntry entry, Sprite backgroundSprite)
	{
	}

	public void SetMaskLayer(int maskLayer)
	{
	}

	private void SetBackground(Sprite backgroundSprite)
	{
	}

	private void SetCosmetics(NetworkedPlayerInfo playerData)
	{
	}

	private void SetText(SecurityLogBehaviour.SecurityLogEntry entry, NetworkedPlayerInfo playerData)
	{
	}
}
