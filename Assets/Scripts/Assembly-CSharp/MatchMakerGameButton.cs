using InnerNet;
using PowerTools;
using TMPro;
using UnityEngine;

public class MatchMakerGameButton : PoolableBehavior, IConnectButton
{
	public TextMeshPro NameText;

	public TextMeshPro SmallNameText;

	public TextMeshPro PlayerCountText;

	public TextMeshPro ImpostorCountText;

	public SpriteRenderer MapIcon;

	public PlatformIdentifier PlatformIdentifier;

	public TextMeshPro LanguageText;

	public Sprite[] MapIcons;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public GameListing myListing;

	public void OnClick()
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}

	public void SetGame(GameListing gameListing)
	{
	}
}
