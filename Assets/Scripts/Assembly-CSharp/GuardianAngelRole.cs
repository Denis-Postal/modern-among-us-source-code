using System.Text;

public class GuardianAngelRole : CrewmateGhostRole
{
	private PlayerControl currentTarget;

	private float cooldownSecondsRemaining;

	private bool IsCoolingDown => false;

	public override bool IsAffectedByComms => false;

	public override void UseAbility()
	{
	}

	public override void SetPlayerTarget(PlayerControl target)
	{
	}

	public override void OnVotingComplete()
	{
	}

	public override void SetCooldown()
	{
	}

	private void FixedUpdate()
	{
	}

	private void UpdateCooldown()
	{
	}

	public override PlayerControl FindClosestTarget()
	{
		return null;
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}
}
