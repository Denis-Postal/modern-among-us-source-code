using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;

public class StoreMenu : DestroyableSingleton<StoreMenu>
{
	public const string BoughtAdsProductId = "bought_ads";

	private const float MaxItemsPerRow = 4f;

	private const float NumRowsVisible = 2f;

	private const float DefaultAspectRatio = 1.7777778f;

	private HatData[] allHats;

	private SkinData[] allSkins;

	private VisorData[] allVisors;

	private NamePlateData[] allPlates;

	private BundleData[] allBundles;

	private CosmicubeData[] allCubes;

	private PetData[] allPets;

	private CosmeticData[] allFeaturedItems;

	private CosmicubeData[] allFeaturedCubes;

	private BundleData[] allLargeFeaturedBundles;

	private BundleData[] allFeaturedBundles;

	private StarBundle[] allStars;

	private Product[] allProducts;

	[Header("Store Menu")]
	public StoreTabButton[] Tabs;

	public GameObject normalMenu;

	public GameObject featuredMenu;

	public TextMeshPro LoadingText;

	public TextMeshPro RestorePurchasesButton;

	public GameObject RestorePurchasesObj;

	public UiElement OpenAllInEShopButton;

	public PurchaseButton PurchasablePrefab;

	public PurchaseButton PurchasableNameplatePrefab;

	public BundlePurchaseButton BundlePurchasablePrefab;

	public BundlePurchaseButton LargeBundlePurchasablePrefab;

	public TextMeshPro beanAmount;

	public TextMeshPro starAmount;

	public GameObject comingSoonText;

	public TextMeshPro tabHeader;

	[Header("Confirm Menu")]
	public PurchasePopUp plsWaitModal;

	public GameObject confirmMenu;

	public CubeCellPurchaseButton priceButton;

	public CubeCellPurchaseButton priceButtonCube;

	public GameObject starConfirmMenu;

	public TextMeshPro StarBundleName;

	public TextMeshPro StarPriceText;

	public PassiveButton starBuyButton;

	public SpriteRenderer starPreviewImage;

	public CosmicubeMenu cosmicubePreviewMenu;

	public PoolablePlayer dressMeUp;

	public PoolablePlayer dressMeUpCube;

	public PlayerVoteArea NameplatePreviewArea;

	public TextMeshPro ItemName;

	public TextMeshPro ItemNameCube;

	public TextMeshPro BundleName;

	public TextMeshPro CosmicubeName;

	public SpriteRenderer PurchaseBackground;

	public TextMeshPro PriceText;

	public TextMeshPro PriceTextCube;

	public StoreChip PreviewPrefab;

	public Scroller ConfirmMenuScroller;

	public UpdateProductTimerDisplay itemLimitedTimeText;

	public FloatRange BundleRange;

	public FloatRange XRange;

	public FloatRange CubesRange;

	public float YStart;

	public float YOffset;

	public int NumPerRow;

	public Vector3 ConfirmCosmeticPosition;

	public Sprite starIcon;

	public Sprite beanIcon;

	[HideInInspector]
	public List<ColorChip> ColorChips;

	private RefreshTimer[] refreshTimers;

	private StoreTab selectedTab;

	private StoreTabButton selectedTabObject;

	[SerializeField]
	private AudioClip swapTabSound;

	private const float NormalHeight = -1.95f;

	private const float BoxHeight = -1.95f;

	public TextMeshPro starDisclaimerText;

	private List<TextMeshPro> BundleTitles;

	private Logger logger;

	public Action OnOpen;

	public Action OnClose;

	private StoreTab[] controllerSelectableTabs;

	[Header("Store Menu")]
	public Scroller Scroller;

	public Scroller FeatureTabScroller;

	private MainMenuManager manager;

	private PurchaseButton CurrentButton;

	private List<GameObject> AllObjects;

	[Header("Console Controller Navigation")]
	private ControllerNavMenu controllerNavMenu;

	public GameObject glyphL;

	public GameObject glyphR;

	private bool initialized;

	public PurchaseStates PurchaseState { get; private set; }

	public bool Initialized => false;

	public void CloseConfirm()
	{
	}

	public void CloseWaitModal()
	{
	}

	public void DisplayFailed(string error)
	{
	}

	public void DisplaySuccess()
	{
	}

	public void UpdateStarDisplay()
	{
	}

	public void Start()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public void OpenTab(StoreMenuTabButton Butt)
	{
	}

	public void OpenTab(StoreTab tab)
	{
	}

	public void ShowConfirm(PurchaseButton butt)
	{
	}

	public void StarPurchaseFinished()
	{
	}

	public void Initialize()
	{
	}

	public void Update()
	{
	}

	public void Open()
	{
	}

	public void OpenGeneralShop()
	{
	}

	private void DestroySliderObjects()
	{
	}

	public void PreviewItem(StoreChip storeChip, CosmeticData product)
	{
	}

	public void SetProduct(PurchaseButton button)
	{
	}

	private void DeselectAllItems()
	{
	}

	public void BuyProduct()
	{
	}

	public void Close()
	{
	}

	public void CloseEntirely()
	{
	}

	private void LoadCosmeticData()
	{
	}

	public void OnSaveDataChanged()
	{
	}

	private void ReSortCosmeticTabs()
	{
	}

	private void SetRefreshTimers()
	{
	}

	private void HandleRefreshTimers()
	{
	}

	private void UpdateRefreshTimers()
	{
	}

	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<CosmeticData> cosmetics, params StoreTab[] tabs)
	{
	}

	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<CosmicubeData> cosmicubes, params StoreTab[] tabs)
	{
	}

	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<BundleData> bundles, params StoreTab[] tabs)
	{
	}

	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<FeaturedItemGroup> features)
	{
	}

	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, DateTime start, DateTime end, params StoreTab[] tabs)
	{
	}

	private void AddRefreshTimer(Dictionary<DateTime, List<StoreTab>> dictionary, DateTime time, params StoreTab[] tabs)
	{
	}

	private void DebugRefreshTimers()
	{
	}

	private T[] GetSortedStoreCosmetics<T>(IEnumerable<T> all) where T : CosmeticData
	{
		return null;
	}

	private void ShowTab()
	{
	}

	private Vector3 AddProductFromList(Vector3 position, IBuyable[] products, List<PurchaseButton> allBtns, float yOffset, int numPerRow, FloatRange xRange, float spacingMultiplier = 1f, bool centerRemainder = false)
	{
		return default(Vector3);
	}

	private PurchaseButton InsertProduct(Vector3 position, IBuyable item)
	{
		return null;
	}

	public void BuyStars()
	{
	}

	public void ResetPurchaseState()
	{
	}
}
