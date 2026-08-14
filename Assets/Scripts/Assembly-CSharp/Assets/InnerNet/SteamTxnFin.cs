using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class SteamTxnFin
	{
		[JsonProperty("order_id")]
		public string orderId;

		public static Request<SteamTxnFin> Create(string orderId)
		{
			return null;
		}
	}
}
