namespace AmongUs.GameOptions
{
	public class RoleDataV08
	{
		public RoleTypes Type { get; }

		public IRoleOptions RoleOptions { get; }

		public RoleRate Rate { get; set; }

		public RoleDataV08(IRoleOptions roleOptions, RoleRate rate)
		{
		}

		public RoleDataV08(RoleTypes type)
		{
		}
	}
}
