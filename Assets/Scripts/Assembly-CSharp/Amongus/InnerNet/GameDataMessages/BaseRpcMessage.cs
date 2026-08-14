using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public abstract class BaseRpcMessage : BaseGameDataMessage
	{
		private readonly uint rpcObjectNetId;

		public sealed override GameDataTypes GameDataType { get; }

		public abstract RpcCalls RpcType { get; }

		public BaseRpcMessage(uint rpcObjectNetId)
		{
		}

		protected sealed override void SerializeValues(MessageWriter msg)
		{
		}

		protected abstract void SerializeRpcValues(MessageWriter msg);
	}
}
