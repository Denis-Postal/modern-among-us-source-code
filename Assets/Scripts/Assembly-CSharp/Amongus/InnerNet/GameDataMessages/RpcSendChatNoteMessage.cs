using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSendChatNoteMessage : BaseRpcMessage
	{
		private readonly byte srcPlayerId;

		private readonly ChatNoteTypes noteType;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSendChatNoteMessage(uint rpcObjectNetId, byte srcPlayerId, ChatNoteTypes noteType)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
