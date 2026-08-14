using UnityEngine;

public class BundleData : ScriptableObject, IBuyable
{
	public const string TranslationPrefix = "Bundle.";

	public BundleSizes BundleSize;

	public string productId;

	public int beanCost;

	public int starCost;

	public CosmeticData[] cosmetics;

	public Sprite StoreImage;

	public bool NotInStore;

	public bool Free;

	public bool paidOnMobile;

	[SerializeField]
	private LimitedTimeStartEnd limitedTime;

	public string ProdId => null;

	public int BeanCost => 0;

	public int StarCost => 0;

	public bool PaidOnMobile => false;

	public LimitedTimeStartEnd LimitedTimeAvailable => default(LimitedTimeStartEnd);

	public string GetItemName()
	{
		return null;
	}

	public string GetPurchasingProductId()
	{
		return null;
	}

	public string[] GetCosmeticIDs()
	{
		return null;
	}
}
