using System;
using AmongUs.GameOptions;
using Hazel;

namespace InnerNet
{
	[Serializable]
	public struct GameListing
	{
		public uint IP;

		public ushort Port;

		public int GameId;

		public byte PlayerCount;

		public string HostName;

		public string TrueHostName;

		public string HostPlatformName;

		public QuickChatModes QuickChat;

		public Platforms Platform;

		public int Age;

		public int MaxPlayers;

		public int NumImpostors;

		public byte MapId;

		public uint Language;

		public IGameOptions Options;

		public string IPString => null;

		public static GameListing DeserializeV2(MessageReader reader)
		{
			return default(GameListing);
		}
	}
}
