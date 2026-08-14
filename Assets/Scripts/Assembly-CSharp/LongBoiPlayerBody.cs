using UnityEngine;

public class LongBoiPlayerBody : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer neckSprite;

	[SerializeField]
	private SpriteRenderer foregroundNeckSprite;

	[SerializeField]
	private SpriteRenderer headSprite;

	[SerializeField]
	private PlayerControl myPlayerControl;

	[SerializeField]
	private PoolablePlayer myPoolablePlayer;

	[SerializeField]
	private CosmeticsLayer cosmeticLayer;

	[SerializeField]
	private float neckHeadZPos;

	[SerializeField]
	private float cosmeticYOffset;

	[SerializeField]
	private bool isPoolablePlayer;

	[SerializeField]
	private bool isExiledPlayer;

	[SerializeField]
	private float targetHeight;

	[SerializeField]
	private bool skipNeckAnim;

	[SerializeField]
	private bool isSeekerHorse;

	[SerializeField]
	private GameObject neckHeadParent;

	[SerializeField]
	private bool hideCosmeticsQC;

	[SerializeField]
	private float growSpeed;

	private PlayerControl hideAndSeekImpostor;

	private float calculatedNeckHeight;

	private bool ShouldLongAround;

	private float[] heightsPerColor;

	private const float BASE_NECK_MAX_HEIGHT = 1.1f;

	private const float GHOST_NECK_WIDTH = 3.17f;

	private const float GHOST_NECK_YPOS = 0.531f;

	private const float NAME_POS_Y = 0.45f;

	public const float HAT_Y_OFFSET = 0.1f;

	private const float Z_ROTATION_OFFSET = -17.75f;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public bool ValidateSkin(string prodId, int colorID)
	{
		return false;
	}

	private void OnCosmeticSet(string prodId, int colorID, CosmeticsLayer.CosmeticKind cosmeticType)
	{
	}

	public void SetHeightFromColor(int colorIndex)
	{
	}

	public void SetHeighFromDistanceHnS(float distance)
	{
	}

	private void HideAndSeekUpdate()
	{
	}

	private void SetupNeckGrowth(bool snapNeck = false, bool resetNeck = true)
	{
	}

	private void LateUpdate()
	{
	}

	private void GrowNeck()
	{
	}

	private void ResetNeck()
	{
	}

	public void SetPoolableGhost()
	{
	}
}
