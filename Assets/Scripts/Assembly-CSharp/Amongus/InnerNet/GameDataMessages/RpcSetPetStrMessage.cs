using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetPetStrMessage : BaseRpcMessage
	{
		private readonly string petId;

		private readonly byte rpcSequenceId;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetPetStrMessage(uint rpcObjectNetId, string petId, byte rpcSequenceId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
