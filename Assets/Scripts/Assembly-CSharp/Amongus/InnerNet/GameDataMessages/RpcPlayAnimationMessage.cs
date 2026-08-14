using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcPlayAnimationMessage : BaseRpcMessage
	{
		private readonly byte animType;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcPlayAnimationMessage(uint rpcObjectNetId, byte animType)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
