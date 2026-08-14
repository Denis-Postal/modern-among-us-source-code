public class EngineerRole : RoleBehaviour
{
	private Vent currentTarget;

	private float cooldownSecondsRemaining;

	private float inVentTimeRemaining;

	private int usesRemaining;

	private bool isExitVentQueued;

	public override bool IsDead => false;

	private bool IsCoolingDown => false;

	public override void Initialize(PlayerControl player)
	{
	}

	private float GetCooldown()
	{
		return 0f;
	}

	private float GetVentTime()
	{
		return 0f;
	}

	public override bool CanUse(IUsable console)
	{
		return false;
	}

	public override bool DidWin(GameOverReason gameOverReason)
	{
		return false;
	}

	public override void SetUsableTarget(IUsable target)
	{
	}

	public override void UseAbility()
	{
	}

	public override void SetCooldown()
	{
	}

	public override void OnVotingComplete()
	{
	}

	private void FixedUpdate()
	{
	}

	public override PlayerControl FindClosestTarget()
	{
		return null;
	}
}
