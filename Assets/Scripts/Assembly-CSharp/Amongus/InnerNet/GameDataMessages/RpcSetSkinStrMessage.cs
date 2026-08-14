using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetSkinStrMessage : BaseRpcMessage
	{
		private readonly string skinId;

		private readonly byte rpcSequenceId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetSkinStrMessage(uint rpcObjectNetId, string skinId, byte rpcSequenceId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
