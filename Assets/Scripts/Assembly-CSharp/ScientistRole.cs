public class ScientistRole : RoleBehaviour
{
	public VitalsMinigame VitalsPrefab;

	private VitalsMinigame minigame;

	private float currentCharge;

	private float currentCooldown;

	public override bool IsDead => false;

	private bool IsCoolingDown => false;

	private float RoleCooldownValue => 0f;

	private float RoleBatteryCharge => 0f;

	public override void Initialize(PlayerControl player)
	{
	}

	public override void OnVotingComplete()
	{
	}

	private void Update()
	{
	}

	public bool Recharge()
	{
		return false;
	}

	public override void UseAbility()
	{
	}

	public override bool CanUse(IUsable console)
	{
		return false;
	}

	public override bool DidWin(GameOverReason gameOverReason)
	{
		return false;
	}

	private void RefreshAbilityButton()
	{
	}

	public override PlayerControl FindClosestTarget()
	{
		return null;
	}
}
