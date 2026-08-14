using Hazel;

namespace AmongUs.GameOptions
{
	public class EngineerRoleOptionsV10 : IRoleOptions
	{
		public float EngineerCooldown;

		public float EngineerInVentMaxTime;

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
