using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetVisorStrMessage : BaseRpcMessage
	{
		private readonly string visorId;

		private readonly byte rpcSequenceId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetVisorStrMessage(uint rpcObjectNetId, string visorId, byte rpcSequenceId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
