using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class ValidateReceiptBatch
	{
		[JsonProperty("receipts")]
		public List<Request<ValidateReceipt>.RequestData> receipts;

		public static Request<ValidateReceiptBatch> Create(string entitlementType, List<string> receiptStrings)
		{
			return null;
		}
	}
}
