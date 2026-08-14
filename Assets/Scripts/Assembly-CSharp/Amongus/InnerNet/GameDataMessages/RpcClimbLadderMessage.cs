using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcClimbLadderMessage : BaseRpcMessage
	{
		private readonly byte ladderId;

		private readonly byte lastClimbLadderSid;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcClimbLadderMessage(uint rpcObjectNetId, byte ladderId, byte lastClimbLadderSid)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
