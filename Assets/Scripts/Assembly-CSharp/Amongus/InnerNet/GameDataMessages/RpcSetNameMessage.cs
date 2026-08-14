using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetNameMessage : BaseRpcMessage
	{
		private readonly uint netIdOfNamed;

		private readonly string name;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetNameMessage(uint rpcObjectNetId, uint netIdOfNamed, string name)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
