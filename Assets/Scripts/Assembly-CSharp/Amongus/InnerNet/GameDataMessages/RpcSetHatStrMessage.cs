using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetHatStrMessage : BaseRpcMessage
	{
		private readonly string hatId;

		private readonly byte rpcSequenceId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetHatStrMessage(uint rpcObjectNetId, string hatId, byte rpcSequenceId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
