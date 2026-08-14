using Hazel;

namespace AmongUs.GameOptions
{
	public class ScientistRoleOptionsV09 : IRoleOptions
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
