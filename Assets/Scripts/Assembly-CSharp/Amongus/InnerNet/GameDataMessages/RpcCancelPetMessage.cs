using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcCancelPetMessage : BaseRpcMessage
	{
		public override RpcCalls RpcType => default(RpcCalls);

		public RpcCancelPetMessage(uint rpcObjectNetId)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
