using Hazel;

namespace AmongUs.GameOptions
{
	public class ViperRoleOptionsV10 : IRoleOptions
	{
		public float viperDissolveTime;

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
