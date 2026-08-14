using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetLevelMessage : BaseRpcMessage
	{
		private readonly uint level;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetLevelMessage(uint rpcObjectNetId, uint level)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
