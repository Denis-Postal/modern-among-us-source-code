using Hazel;

namespace AmongUs.GameOptions
{
	public class NoisemakerRoleOptionsV09 : IRoleOptions
	{
		public bool NoisemakerImpostorAlert;

		public float NoisemakerAlertDuration;

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
