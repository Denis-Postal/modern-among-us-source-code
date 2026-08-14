using Hazel;
using UnityEngine;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcPetMessage : BaseRpcMessage
	{
		private readonly Vector2 pos;

		private readonly Vector2 petPos;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcPetMessage(uint rpcObjectNetId, Vector2 pos, Vector2 petPos)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
