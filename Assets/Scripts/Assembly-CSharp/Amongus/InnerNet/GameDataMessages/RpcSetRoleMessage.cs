using AmongUs.GameOptions;
using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class RpcSetRoleMessage : BaseRpcMessage
	{
		private readonly RoleTypes roleType;

		private readonly bool canOverrideRole;

		public override RpcCalls RpcType => default(RpcCalls);

		public RpcSetRoleMessage(uint rpcObjectNetId, RoleTypes roleType, bool canOverrideRole)
			: base(0u)
		{
		}

		protected override void SerializeRpcValues(MessageWriter msg)
		{
		}
	}
}
