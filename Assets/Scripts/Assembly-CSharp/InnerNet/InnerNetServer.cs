using System.Collections.Generic;
using Hazel;
using Hazel.Udp;
using UnityEngine;

namespace InnerNet
{
	public class InnerNetServer : DestroyableSingleton<InnerNetServer>
	{
		protected class Player
		{
			private static int IdCount;

			public int Id;

			public Connection Connection;

			public string PlayerName;

			public PlatformSpecificData PlatformData;

			public LimboStates LimboState;

			public Player(Connection connection, string playerName, PlatformSpecificData platformData)
			{
			}
		}

		public const int LocalGameId = 32;

		private const int InvalidHost = -1;

		private int HostId;

		public PlatformSpecificData PlatformData;

		public HashSet<string> ipBans;

		public int Port;

		[SerializeField]
		private GameStates GameState;

		private UdpConnectionListener listener;

		private List<Player> Clients;

		public override void OnDestroy()
		{
		}

		public void StartAsServer()
		{
		}

		private void OnInternalError(HazelInternalErrors errorType)
		{
		}

		public void StartAsLocalServer()
		{
		}

		private void DebugString(string obj)
		{
		}

		public void StopServer()
		{
		}

		public static bool IsCompatibleVersion(int version)
		{
			return false;
		}

		private void OnServerConnect(NewConnectionEventArgs evt)
		{
		}

		private static void SendIncorrectVersion(Connection connection)
		{
		}

		private void Connection_DataRecievedRaw(byte[] data, int length)
		{
		}

		private void OnDataReceived(Player client, DataReceivedEventArgs evt)
		{
		}

		private void HandleMessage(Player client, MessageReader reader, SendOption sendOption)
		{
		}

		private void KickPlayer(int targetId, bool ban)
		{
		}

		protected void JoinGame(Player client)
		{
		}

		private void HandleRejoin(Player client)
		{
		}

		private void HandleNewGameJoin(Player client)
		{
		}

		private void EndGame(MessageReader message, Player source)
		{
		}

		private void StartGame(MessageReader message, Player source)
		{
		}

		private void ClientDisconnect(Player client)
		{
		}

		protected void SendTo(MessageWriter msg, int targetId)
		{
		}

		protected void Broadcast(MessageWriter msg, Player source)
		{
		}

		private void BroadcastJoinMessage(Player client, MessageWriter msg)
		{
		}

		private void WriteJoinedMessage(Player client, MessageWriter msg, bool clear)
		{
		}
	}
}
