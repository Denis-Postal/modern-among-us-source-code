using TMPro;
using UnityEngine;

public class PlayerIdentifierButton : PoolableBehavior
{
	[SerializeField]
	private TextMeshPro NameText;

	[SerializeField]
	private PlatformIdentifier PlatformIdentifier;

	[SerializeField]
	private PoolablePlayer PlayerPreview;

	[SerializeField]
	private SpriteRenderer MaskArea;

	private byte targetPlayerId;

	public void Populate(NetworkedPlayerInfo player)
	{
	}

	private void SetTargetPlayerId(byte targetId)
	{
	}

	private void SetMaskLayer(int maskLayer)
	{
	}

	public void DisplayProfileInfo()
	{
	}

	public override void Reset()
	{
	}
}
