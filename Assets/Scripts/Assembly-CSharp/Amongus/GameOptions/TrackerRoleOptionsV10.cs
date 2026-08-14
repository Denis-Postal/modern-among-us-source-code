using Hazel;

namespace AmongUs.GameOptions
{
	public class TrackerRoleOptionsV10 : IRoleOptions
	{
		public float TrackerCooldown;

		public float TrackerDuration;

		public float TrackerDelay;

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
