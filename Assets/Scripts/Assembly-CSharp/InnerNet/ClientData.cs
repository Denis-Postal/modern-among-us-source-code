using System;

namespace InnerNet
{
	[Serializable]
	public class ClientData
	{
		public int Id;

		public bool InScene;

		public bool IsReady;

		public bool HasBeenReported;

		public bool IsBeingCreated;

		public PlayerControl Character;

		public readonly uint PlayerLevel;

		public readonly PlatformSpecificData PlatformData;

		public string PlayerName;

		public string ProductUserId;

		public string FriendCode;

		public int ColorId;

		public ClientData(int id, string playerName, PlatformSpecificData platformData, uint playerLevel, string productUserId, string friendCode)
		{
			Id = id;
			PlayerName = playerName;
			PlatformData = platformData;
			PlayerLevel = playerLevel;
			ProductUserId = productUserId;
			FriendCode = friendCode;
		}

		public void UpdatePlayerName(string playerName)
		{
			PlayerName = playerName;
		}
	}
}
