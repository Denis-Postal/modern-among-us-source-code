using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcBootFromVentMessage : BaseRpcMessage
	{
		private readonly int ventId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcBootFromVentMessage(uint rpcObjectNetId, int ventId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
