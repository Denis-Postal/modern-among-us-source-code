using System.Text;

public class CrewmateGhostRole : RoleBehaviour
{
	public Minigame HauntMenu;

	public override bool IsDead => false;

	public override bool IsAffectedByComms => false;

	public override bool CanUse(IUsable console)
	{
		return false;
	}

	public override bool DidWin(GameOverReason gameOverReason)
	{
		return false;
	}

	public override void UseAbility()
	{
	}

	public override void SpawnTaskHeader(PlayerControl playerControl)
	{
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}
}
