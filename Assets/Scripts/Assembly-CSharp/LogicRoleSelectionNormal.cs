using System.Collections.Generic;
using AmongUs.GameOptions;
using Hazel;

public class LogicRoleSelectionNormal : LogicRoleSelection
{
	public LogicRoleSelectionNormal(GameManager manager)
		: base(null)
	{
	}

	public override void OnGameStart()
	{
	}

	public override void OnGameEnd()
	{
	}

	public override void FixedUpdate()
	{
	}

	public override void OnDestroy()
	{
	}

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}

	public override void AssignRolesForTeam(List<NetworkedPlayerInfo> players, IGameOptions opts, RoleTeamTypes team, int teamMax, RoleTypes? defaultRole)
	{
	}

	private void AssignRolesFromList(List<NetworkedPlayerInfo> players, int teamMax, List<RoleTypes> roleList, ref int rolesAssigned)
	{
	}

	public override void OnPlayerDeath(PlayerControl player, bool assignGhostRole)
	{
	}
}
