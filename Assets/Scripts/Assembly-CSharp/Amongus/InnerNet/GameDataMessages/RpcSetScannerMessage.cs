using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetScannerMessage : BaseRpcMessage
	{
		private readonly bool value;

		private readonly byte count;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetScannerMessage(uint rpcObjectNetId, bool value, byte count)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
