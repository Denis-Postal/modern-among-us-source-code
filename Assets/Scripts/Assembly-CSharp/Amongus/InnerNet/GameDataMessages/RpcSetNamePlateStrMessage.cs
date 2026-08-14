using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetNamePlateStrMessage : BaseRpcMessage
	{
		private readonly string namePlateId;

		private readonly byte rpcSequenceId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetNamePlateStrMessage(uint rpcObjectNetId, string namePlateId, byte rpcSequenceId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
