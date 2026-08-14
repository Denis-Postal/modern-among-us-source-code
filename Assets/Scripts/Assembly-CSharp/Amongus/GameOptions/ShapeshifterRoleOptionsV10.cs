using Hazel;

namespace AmongUs.GameOptions
{
	public class ShapeshifterRoleOptionsV10 : IRoleOptions
	{
		public bool ShapeshifterLeaveSkin;

		public float ShapeshifterCooldown;

		public float ShapeshifterDuration;

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
