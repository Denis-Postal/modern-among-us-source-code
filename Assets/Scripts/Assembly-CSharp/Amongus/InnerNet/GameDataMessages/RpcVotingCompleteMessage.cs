using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcVotingCompleteMessage : BaseRpcMessage
	{
		private readonly MeetingHud.VoterState[] voterStates;

		private readonly byte exiledPlayerId;

		private readonly bool tie;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcVotingCompleteMessage(uint rpcObjectNetId, MeetingHud.VoterState[] voterStates, byte exiledPlayerId, bool tie)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
