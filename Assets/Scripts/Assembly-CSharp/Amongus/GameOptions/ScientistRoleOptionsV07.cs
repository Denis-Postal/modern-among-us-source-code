using Hazel;

namespace AmongUs.GameOptions
{
	public class ScientistRoleOptionsV07 : IRoleOptions
	{
		public float ScientistCooldown;

		public float ScientistBatteryCharge;

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
