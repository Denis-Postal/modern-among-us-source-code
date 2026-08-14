using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcAddVoteBanMessage : BaseRpcMessage
	{
		private readonly int sourceClientId;

		private readonly int clientIdToVoteBan;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcAddVoteBanMessage(uint rpcObjectNetId, int sourceClientId, int clientIdToVoteBan)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
