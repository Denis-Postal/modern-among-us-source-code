namespace AmongUs.GameOptions
{
	public class RoleDataV09
	{
		public RoleTypes Type { get; }

		public IRoleOptions RoleOptions { get; }

		public RoleRate Rate { get; set; }

		public RoleDataV09(IRoleOptions roleOptions, RoleRate rate)
		{
		}

		public RoleDataV09(RoleTypes type)
		{
		}
	}
}
