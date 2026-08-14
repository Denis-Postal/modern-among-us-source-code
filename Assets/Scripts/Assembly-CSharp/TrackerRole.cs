using System.Text;
using UnityEngine;

public class TrackerRole : CrewmateRole
{
	private PlayerControl currentTarget;

	private float cooldownSecondsRemaining;

	private float durationSecondsRemaining;

	private float delaySecondsRemaining;

	private bool pauseTrackingTime;

	[SerializeField]
	private AudioClip cancelSound;

	private bool isTrackingActive;

	private const float DelaySeconds = 1f;

	private bool IsCoolingDown => false;

	private bool IsDelayed => false;

	public override void UseAbility()
	{
	}

	private void CancelTracking(bool setCooldown = true)
	{
	}

	public override void SetPlayerTarget(PlayerControl target)
	{
	}

	private void ClearPlayerTarget()
	{
	}

	public override PlayerControl FindClosestTarget()
	{
		return null;
	}

	protected override float GetAbilityDistance()
	{
		return 0f;
	}

	private bool ShouldUpdateCancelTimer()
	{
		return false;
	}

	public override void OnMeetingStart()
	{
	}

	public void CheckCancelTracking(PlayerControl pc)
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

	public override void OnDeath(DeathReason reason)
	{
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}

	private void OnDestroy()
	{
	}
}
