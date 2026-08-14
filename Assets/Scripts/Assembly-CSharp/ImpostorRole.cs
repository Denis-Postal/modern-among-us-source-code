using System.Text;

public class ImpostorRole : RoleBehaviour
{
	public override bool IsDead => false;

	public override void Deinitialize(PlayerControl targetPlayer)
	{
	}

	public override void SpawnTaskHeader(PlayerControl playerControl)
	{
	}

	public override bool CanUse(IUsable usable)
	{
		return false;
	}

	public override bool DidWin(GameOverReason gameOverReason)
	{
		return false;
	}

	protected override bool IsValidTarget(NetworkedPlayerInfo target)
	{
		return false;
	}

	public override PlayerControl FindClosestTarget()
	{
		return null;
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}
}
