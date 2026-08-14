using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class InnerslothReceipt
	{
		[JsonProperty("items")]
		public string[] Items;

		public InnerslothReceipt()
		{
		}

		public InnerslothReceipt(string[] items)
		{
		}

		public InnerslothReceipt(List<string> items)
		{
		}
	}
}
