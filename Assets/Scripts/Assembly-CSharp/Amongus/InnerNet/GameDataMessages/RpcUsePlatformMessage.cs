using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcUsePlatformMessage : BaseRpcMessage
	{
		public override RpcCalls RpcType => default(RpcCalls);

		public RpcUsePlatformMessage(uint rpcObjectNetId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
