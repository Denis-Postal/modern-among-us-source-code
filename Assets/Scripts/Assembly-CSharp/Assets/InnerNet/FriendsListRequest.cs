using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class FriendsListRequest
	{
		[JsonProperty("username")]
		public string Username;

		[JsonProperty("recipient_puid")]
		public string RecipientId;

		[JsonProperty("recipient_friendcode")]
		public string RecipientUsername;

		public static Request<FriendsListRequest> ChangeUsername(string username)
		{
			return null;
		}

		public static Request<FriendsListRequest> SendRequest(string recipientId, string type)
		{
			return null;
		}

		public static Request<FriendsListRequest> SendRequestByUsername(string recipientName)
		{
			return null;
		}
	}
}
