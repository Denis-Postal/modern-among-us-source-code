using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetTasksMessage : BaseRpcMessage
	{
		private readonly byte[] taskTypeIds;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetTasksMessage(uint rpcObjectNetId, byte[] taskTypeIds)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
