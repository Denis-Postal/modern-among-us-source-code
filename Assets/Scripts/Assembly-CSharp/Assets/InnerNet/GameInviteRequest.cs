using Newtonsoft.Json;

namespace Assets.InnerNet
{
	public class GameInviteRequest
	{
		[JsonProperty("recipient_puid")]
		public string RecipientId;

		[JsonProperty("room_code")]
		public string RoomCode;

		public static Request<GameInviteRequest> SendGameInvite(string recipientId, string roomCode)
		{
			return null;
		}
	}
}
