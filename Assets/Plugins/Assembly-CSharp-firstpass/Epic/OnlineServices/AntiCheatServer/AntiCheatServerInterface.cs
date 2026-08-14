using System;
using Epic.OnlineServices.AntiCheatCommon;

namespace Epic.OnlineServices.AntiCheatServer
{
	public sealed class AntiCheatServerInterface : Handle
	{
		public const int AddnotifyclientactionrequiredApiLatest = 1;

		public const int AddnotifyclientauthstatuschangedApiLatest = 1;

		public const int AddnotifymessagetoclientApiLatest = 1;

		public const int BeginsessionApiLatest = 3;

		public const int BeginsessionMaxRegistertimeout = 120;

		public const int BeginsessionMinRegistertimeout = 10;

		public const int EndsessionApiLatest = 1;

		public const int GetprotectmessageoutputlengthApiLatest = 1;

		public const int OnmessagetoclientcallbackMaxMessageSize = 512;

		public const int ProtectmessageApiLatest = 1;

		public const int ReceivemessagefromclientApiLatest = 1;

		public const int RegisterclientApiLatest = 2;

		public const int SetclientnetworkstateApiLatest = 1;

		public const int UnprotectmessageApiLatest = 1;

		public const int UnregisterclientApiLatest = 1;

		public AntiCheatServerInterface()
		{
		}

		public AntiCheatServerInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyClientActionRequired(ref AddNotifyClientActionRequiredOptions options, object clientData, OnClientActionRequiredCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyClientAuthStatusChanged(ref AddNotifyClientAuthStatusChangedOptions options, object clientData, OnClientAuthStatusChangedCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyMessageToClient(ref AddNotifyMessageToClientOptions options, object clientData, OnMessageToClientCallback notificationFn)
		{
			return 0uL;
		}

		public Result BeginSession(ref BeginSessionOptions options)
		{
			return default(Result);
		}

		public Result EndSession(ref EndSessionOptions options)
		{
			return default(Result);
		}

		public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes)
		{
			outBufferSizeBytes = default(uint);
			return default(Result);
		}

		public Result LogEvent(ref LogEventOptions options)
		{
			return default(Result);
		}

		public Result LogGameRoundEnd(ref LogGameRoundEndOptions options)
		{
			return default(Result);
		}

		public Result LogGameRoundStart(ref LogGameRoundStartOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerDespawn(ref LogPlayerDespawnOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerRevive(ref LogPlayerReviveOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerSpawn(ref LogPlayerSpawnOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerTakeDamage(ref LogPlayerTakeDamageOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerTick(ref LogPlayerTickOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerUseAbility(ref LogPlayerUseAbilityOptions options)
		{
			return default(Result);
		}

		public Result LogPlayerUseWeapon(ref LogPlayerUseWeaponOptions options)
		{
			return default(Result);
		}

		public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten)
		{
			outBytesWritten = default(uint);
			return default(Result);
		}

		public Result ReceiveMessageFromClient(ref ReceiveMessageFromClientOptions options)
		{
			return default(Result);
		}

		public Result RegisterClient(ref RegisterClientOptions options)
		{
			return default(Result);
		}

		public Result RegisterEvent(ref RegisterEventOptions options)
		{
			return default(Result);
		}

		public void RemoveNotifyClientActionRequired(ulong notificationId)
		{
		}

		public void RemoveNotifyClientAuthStatusChanged(ulong notificationId)
		{
		}

		public void RemoveNotifyMessageToClient(ulong notificationId)
		{
		}

		public Result SetClientDetails(ref SetClientDetailsOptions options)
		{
			return default(Result);
		}

		public Result SetClientNetworkState(ref SetClientNetworkStateOptions options)
		{
			return default(Result);
		}

		public Result SetGameSessionId(ref SetGameSessionIdOptions options)
		{
			return default(Result);
		}

		public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten)
		{
			outBytesWritten = default(uint);
			return default(Result);
		}

		public Result UnregisterClient(ref UnregisterClientOptions options)
		{
			return default(Result);
		}

		[MonoPInvokeCallback(typeof(OnClientActionRequiredCallbackInternal))]
		internal static void OnClientActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnClientAuthStatusChangedCallbackInternal))]
		internal static void OnClientAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnMessageToClientCallbackInternal))]
		internal static void OnMessageToClientCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data)
		{
		}
	}
}
