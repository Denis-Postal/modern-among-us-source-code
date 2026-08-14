using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcReportDeadBodyMessage : BaseRpcMessage
	{
		private readonly byte targetPlayerId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcReportDeadBodyMessage(uint rpcObjectNetId, byte targetPlayerId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
