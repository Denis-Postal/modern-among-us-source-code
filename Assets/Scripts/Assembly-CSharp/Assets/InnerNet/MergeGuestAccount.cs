using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class MergeGuestAccount
	{
		[JsonProperty("merge_to_id_token")]
		public string MergeToToken;

		[JsonProperty("merge_from_id_token")]
		public string MergeFromToken;

		public static Request<MergeGuestAccount> ToMergeGuestAccount(string mergeToToken, string mergeFromToken)
		{
			return null;
		}
	}
}
