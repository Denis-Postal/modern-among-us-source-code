using Hazel;

namespace AmongUs.GameOptions
{
	public class PhantomRoleOptionsV10 : IRoleOptions
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
