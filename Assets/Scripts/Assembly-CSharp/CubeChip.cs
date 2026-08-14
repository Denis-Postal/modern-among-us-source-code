using Innersloth.Assets;
using TMPro;
using UnityEngine;

public class CubeChip : ColorChip
{
	[SerializeField]
	private SpriteRenderer image;

	[SerializeField]
	private TextMeshPro cubeTitle;

	[SerializeField]
	private TextMeshPro percentCompleteText;

	[SerializeField]
	private TextMeshPro podAmount;

	[SerializeField]
	private SpriteRenderer ImageMask;

	[SerializeField]
	private SpriteRenderer podIcon;

	private CosmicubeData cube;

	private AddressableSpriteBehavior imageAssetHandler;

	private AddressableSpriteBehavior podIconAssetHandler;

	private void Awake()
	{
	}

	public void SetUp(CosmicubeData cube, int maskLayer)
	{
	}

	private void RefreshText()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}
}
