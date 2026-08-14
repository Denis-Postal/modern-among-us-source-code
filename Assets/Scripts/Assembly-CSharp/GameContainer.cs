using System;
using InnerNet;
using TMPro;
using UnityEngine;

public class GameContainer : MonoBehaviour, IConnectButton
{
	[SerializeField]
	private TextMeshPro tag1;

	[SerializeField]
	private TextMeshPro tag2;

	[SerializeField]
	private SpriteRenderer mapBackground;

	[SerializeField]
	private SpriteRenderer mapLogo;

	[SerializeField]
	private Sprite[] mapBackgroundSprites;

	[SerializeField]
	private Sprite[] mapLogoSprites;

	[SerializeField]
	private TextMeshPro capacity;

	public Action<GameListing> OnMoreAction;

	private GameListing gameListing;

	public void SetGameListing(GameListing gameL)
	{
	}

	public void SetupGameInfo()
	{
	}

	public void OnClick()
	{
	}

	public void ClickMore()
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}
}
