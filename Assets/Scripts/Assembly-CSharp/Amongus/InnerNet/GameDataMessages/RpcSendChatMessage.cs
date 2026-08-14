using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSendChatMessage : BaseRpcMessage
	{
		private readonly string chatText;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSendChatMessage(uint rpcObjectNetId, string chatText)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
