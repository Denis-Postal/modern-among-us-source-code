using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetStartCounterMessage : BaseRpcMessage
	{
		private readonly int counterId;

		private readonly sbyte secondsLeft;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetStartCounterMessage(uint rpcObjectNetId, int counterId, sbyte secondsLeft)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
