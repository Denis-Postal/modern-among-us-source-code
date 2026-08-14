using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcCloseMeetingMessage : BaseRpcMessage
	{
		public override RpcCalls RpcType => default(RpcCalls);

		public RpcCloseMeetingMessage(uint rpcObjectNetId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
