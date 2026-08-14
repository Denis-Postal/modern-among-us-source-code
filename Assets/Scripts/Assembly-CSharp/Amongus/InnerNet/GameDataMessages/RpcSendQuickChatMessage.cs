using AmongUs.QuickChat;
using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSendQuickChatMessage : BaseRpcMessage
	{
		private readonly QuickChatPhraseBuilderResult quickChatData;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSendQuickChatMessage(uint rpcObjectNetId, QuickChatPhraseBuilderResult quickChatData)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
