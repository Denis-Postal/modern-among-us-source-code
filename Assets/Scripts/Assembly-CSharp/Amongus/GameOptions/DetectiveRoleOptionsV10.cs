using Hazel;

namespace AmongUs.GameOptions
{
	public class DetectiveRoleOptionsV10 : IRoleOptions
	{
		public float DetectiveSuspectLimit;

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
