using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class RedeemCurrency
	{
		[JsonProperty("item_id")]
		public string ItemId;

		[JsonProperty("currency_type")]
		public string CurrencyType;

		[JsonProperty("platform")]
		public string Platform;

		public static Request<RedeemCurrency> ForNonCubePurchase(string productId, CurrencyTypes currencyType)
		{
			return null;
		}

		public static Request<RedeemCurrency> ForCubePurchase(string productId, string cubeName)
		{
			return null;
		}

		public static string ProductIdToItemId(string productId)
		{
			return null;
		}
	}
}
