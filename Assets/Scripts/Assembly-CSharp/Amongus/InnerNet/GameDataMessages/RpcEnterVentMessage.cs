using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcEnterVentMessage : BaseRpcMessage
	{
		private readonly int ventId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcEnterVentMessage(uint rpcObjectNetId, int ventId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
