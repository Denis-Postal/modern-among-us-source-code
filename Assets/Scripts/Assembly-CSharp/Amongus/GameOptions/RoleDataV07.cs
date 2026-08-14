namespace AmongUs.GameOptions
{
	public class RoleDataV07
	{
		public RoleTypes Type { get; }

		public IRoleOptions RoleOptions { get; }

		public RoleRate Rate { get; set; }

		public RoleDataV07(IRoleOptions roleOptions, RoleRate rate)
		{
		}

		public RoleDataV07(RoleTypes type)
		{
		}
	}
}
