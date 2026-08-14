using System.Collections.Generic;
using AmongUs.GameOptions;

public class RoleManager : DestroyableSingleton<RoleManager>
{
	public class RoleAssignmentData
	{
		public RoleBehaviour Role;

		public int Count;

		public int Chance;

		public RoleAssignmentData(RoleBehaviour role, int count, int chance)
		{
		}
	}

	private static readonly HashSet<RoleTypes> GhostRoles;

	public List<RoleBehaviour> AllRoles;

	public RoleEffectAnimation shapeshiftAnim;

	public RoleEffectAnimation protectAnim;

	public RoleEffectAnimation protectLoopAnim;

	public RoleEffectAnimation vanish_ChargeAnim;

	public RoleEffectAnimation vanish_PoofAnim;

	public RoleEffectAnimation appear_PoofAnim;

	public override void Awake()
	{
	}

	public RoleBehaviour GetRole(RoleTypes roleType)
	{
		return null;
	}

	public void SetRole(PlayerControl targetPlayer, RoleTypes roleType)
	{
	}

	public void SelectRoles()
	{
	}

	public void AssignRoleOnDeath(PlayerControl player, bool specialRolesAllowed)
	{
	}

	private void DebugRoleAssignments(List<NetworkedPlayerInfo> players, ref int numImpostors)
	{
	}

	private static void TryAssignSpecialGhostRoles(PlayerControl player, bool impostorRoles)
	{
	}

	public static bool IsGhostRole(RoleTypes role)
	{
		return false;
	}

	private static List<RoleTypes> SpecialCrewmateGhostRoles()
	{
		return null;
	}

	private static List<RoleTypes> SpecialImpostorGhostRoles()
	{
		return null;
	}

	public static bool IsImpostorRole(RoleTypes roleType)
	{
		return false;
	}
}
