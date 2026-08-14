using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetColorMessage : BaseRpcMessage
	{
		private readonly uint netIdToColor;

		private readonly byte bodyColor;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetColorMessage(uint rpcObjectNetId, uint netIdToColor, byte bodyColor)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
