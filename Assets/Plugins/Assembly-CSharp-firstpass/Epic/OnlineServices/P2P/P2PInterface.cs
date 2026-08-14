using System;

namespace Epic.OnlineServices.P2P
{
	public sealed class P2PInterface : Handle
	{
		public const int AcceptconnectionApiLatest = 1;

		public const int AddnotifyincomingpacketqueuefullApiLatest = 1;

		public const int AddnotifypeerconnectionclosedApiLatest = 1;

		public const int AddnotifypeerconnectionestablishedApiLatest = 1;

		public const int AddnotifypeerconnectioninterruptedApiLatest = 1;

		public const int AddnotifypeerconnectionrequestApiLatest = 1;

		public const int ClearpacketqueueApiLatest = 1;

		public const int CloseconnectionApiLatest = 1;

		public const int CloseconnectionsApiLatest = 1;

		public const int GetnattypeApiLatest = 1;

		public const int GetnextreceivedpacketsizeApiLatest = 2;

		public const int GetpacketqueueinfoApiLatest = 1;

		public const int GetportrangeApiLatest = 1;

		public const int GetrelaycontrolApiLatest = 1;

		public const int MaxConnections = 32;

		public const int MaxPacketSize = 1170;

		public const int MaxQueueSizeUnlimited = 0;

		public const int QuerynattypeApiLatest = 1;

		public const int ReceivepacketApiLatest = 2;

		public const int SendpacketApiLatest = 3;

		public const int SetpacketqueuesizeApiLatest = 1;

		public const int SetportrangeApiLatest = 1;

		public const int SetrelaycontrolApiLatest = 1;

		public const int SocketidApiLatest = 1;

		public const int SocketidSocketnameSize = 33;

		public P2PInterface()
		{
		}

		public P2PInterface(IntPtr innerHandle)
		{
		}

		public Result AcceptConnection(ref AcceptConnectionOptions options)
		{
			return default(Result);
		}

		public ulong AddNotifyIncomingPacketQueueFull(ref AddNotifyIncomingPacketQueueFullOptions options, object clientData, OnIncomingPacketQueueFullCallback incomingPacketQueueFullHandler)
		{
			return 0uL;
		}

		public ulong AddNotifyPeerConnectionClosed(ref AddNotifyPeerConnectionClosedOptions options, object clientData, OnRemoteConnectionClosedCallback connectionClosedHandler)
		{
			return 0uL;
		}

		public ulong AddNotifyPeerConnectionEstablished(ref AddNotifyPeerConnectionEstablishedOptions options, object clientData, OnPeerConnectionEstablishedCallback connectionEstablishedHandler)
		{
			return 0uL;
		}

		public ulong AddNotifyPeerConnectionInterrupted(ref AddNotifyPeerConnectionInterruptedOptions options, object clientData, OnPeerConnectionInterruptedCallback connectionInterruptedHandler)
		{
			return 0uL;
		}

		public ulong AddNotifyPeerConnectionRequest(ref AddNotifyPeerConnectionRequestOptions options, object clientData, OnIncomingConnectionRequestCallback connectionRequestHandler)
		{
			return 0uL;
		}

		public Result ClearPacketQueue(ref ClearPacketQueueOptions options)
		{
			return default(Result);
		}

		public Result CloseConnection(ref CloseConnectionOptions options)
		{
			return default(Result);
		}

		public Result CloseConnections(ref CloseConnectionsOptions options)
		{
			return default(Result);
		}

		public Result GetNATType(ref GetNATTypeOptions options, out NATType outNATType)
		{
			outNATType = default(NATType);
			return default(Result);
		}

		public Result GetNextReceivedPacketSize(ref GetNextReceivedPacketSizeOptions options, out uint outPacketSizeBytes)
		{
			outPacketSizeBytes = default(uint);
			return default(Result);
		}

		public Result GetPacketQueueInfo(ref GetPacketQueueInfoOptions options, out PacketQueueInfo outPacketQueueInfo)
		{
			outPacketQueueInfo = default(PacketQueueInfo);
			return default(Result);
		}

		public Result GetPortRange(ref GetPortRangeOptions options, out ushort outPort, out ushort outNumAdditionalPortsToTry)
		{
			outPort = default(ushort);
			outNumAdditionalPortsToTry = default(ushort);
			return default(Result);
		}

		public Result GetRelayControl(ref GetRelayControlOptions options, out RelayControl outRelayControl)
		{
			outRelayControl = default(RelayControl);
			return default(Result);
		}

		public void QueryNATType(ref QueryNATTypeOptions options, object clientData, OnQueryNATTypeCompleteCallback completionDelegate)
		{
		}

		public void RemoveNotifyIncomingPacketQueueFull(ulong notificationId)
		{
		}

		public void RemoveNotifyPeerConnectionClosed(ulong notificationId)
		{
		}

		public void RemoveNotifyPeerConnectionEstablished(ulong notificationId)
		{
		}

		public void RemoveNotifyPeerConnectionInterrupted(ulong notificationId)
		{
		}

		public void RemoveNotifyPeerConnectionRequest(ulong notificationId)
		{
		}

		public Result SendPacket(ref SendPacketOptions options)
		{
			return default(Result);
		}

		public Result SetPacketQueueSize(ref SetPacketQueueSizeOptions options)
		{
			return default(Result);
		}

		public Result SetPortRange(ref SetPortRangeOptions options)
		{
			return default(Result);
		}

		public Result SetRelayControl(ref SetRelayControlOptions options)
		{
			return default(Result);
		}

		[MonoPInvokeCallback(typeof(OnIncomingConnectionRequestCallbackInternal))]
		internal static void OnIncomingConnectionRequestCallbackInternalImplementation(ref OnIncomingConnectionRequestInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnIncomingPacketQueueFullCallbackInternal))]
		internal static void OnIncomingPacketQueueFullCallbackInternalImplementation(ref OnIncomingPacketQueueFullInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnPeerConnectionEstablishedCallbackInternal))]
		internal static void OnPeerConnectionEstablishedCallbackInternalImplementation(ref OnPeerConnectionEstablishedInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnPeerConnectionInterruptedCallbackInternal))]
		internal static void OnPeerConnectionInterruptedCallbackInternalImplementation(ref OnPeerConnectionInterruptedInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnQueryNATTypeCompleteCallbackInternal))]
		internal static void OnQueryNATTypeCompleteCallbackInternalImplementation(ref OnQueryNATTypeCompleteInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnRemoteConnectionClosedCallbackInternal))]
		internal static void OnRemoteConnectionClosedCallbackInternalImplementation(ref OnRemoteConnectionClosedInfoInternal data)
		{
		}

		public Result ReceivePacket(ref ReceivePacketOptions options, ref ProductUserId outPeerId, ref SocketId outSocketId, out byte outChannel, ArraySegment<byte> outData, out uint outBytesWritten)
		{
			outChannel = default(byte);
			outBytesWritten = default(uint);
			return default(Result);
		}
	}
}
