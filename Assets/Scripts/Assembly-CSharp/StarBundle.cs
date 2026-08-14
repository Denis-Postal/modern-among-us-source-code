using UnityEngine;

[CreateAssetMenu]
public class StarBundle : ScriptableObject, IBuyable
{
	public const string TranslationPrefix = "Bundle.";

	public string epicId;

	public string productId;

	public string SteamAppId;

	public string SteamPrice;

	public float price;

	public int starAmount;

	public Sprite StoreImage;

	public Sprite StoreBackImage;

	public string ProdId => null;

	public int BeanCost => 0;

	public int StarCost => 0;

	public string EpicId => null;

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
}
