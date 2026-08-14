namespace AmongUs.GameOptions
{
	public class RoleDataV10
	{
		public RoleTypes Type { get; }

		public IRoleOptions RoleOptions { get; }

		public RoleRate Rate { get; set; }

		public RoleDataV10(IRoleOptions roleOptions, RoleRate rate)
		{
		}

		public RoleDataV10(RoleTypes type)
		{
		}
	}
}
