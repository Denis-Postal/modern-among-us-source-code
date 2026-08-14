using Hazel;

namespace AmongUs.GameOptions
{
	public class GuardianAngelRoleOptionsV09 : IRoleOptions
	{
		public float GuardianAngelCooldown;

		public float ProtectionDurationSeconds;

		public bool ImpostorsCanSeeProtect;

		public RoleTypes Type { get; }

		public void Serialize(MessageWriter writer)
		{
		}

		public void Deserialize(MessageReader reader)
		{
		}

		public void SetRecommended()
		{
		}
	}
}
