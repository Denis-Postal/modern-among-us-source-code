using Hazel;

namespace AmongUs.GameOptions
{
	public class PhantomRoleOptionsV09 : IRoleOptions
	{
		public float PhantomCooldown;

		public float PhantomDuration;

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
