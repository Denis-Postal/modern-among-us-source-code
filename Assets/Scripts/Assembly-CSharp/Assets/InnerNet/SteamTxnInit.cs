using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class SteamTxnInit
	{
		[JsonProperty("steam_id")]
		public string steamId;

		[JsonProperty("currency_code")]
		public string currencyCode;

		[JsonProperty("language_code")]
		public uint languageCode;

		[JsonProperty("item_id")]
		public int itemId;

		public static Request<SteamTxnInit> Create(SteamTxnInit payloadData)
		{
			return null;
		}
	}
}
