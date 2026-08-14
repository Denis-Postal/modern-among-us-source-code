using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcCompleteTaskMessage : BaseRpcMessage
	{
		private readonly uint idx;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcCompleteTaskMessage(uint rpcObjectNetId, uint idx)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
