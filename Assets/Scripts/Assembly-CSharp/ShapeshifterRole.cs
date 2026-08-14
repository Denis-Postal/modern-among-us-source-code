using System.Text;
using UnityEngine;

public class ShapeshifterRole : ImpostorRole
{
	public ShapeshifterEvidence EvidencePrefab;

	public Vector3 EvidenceOffset;

	public ShapeshifterMinigame ShapeshifterMenu;

	private float cooldownSecondsRemaining;

	private float durationSecondsRemaining;

	private bool IsCoolingDown => false;

	public override void UseAbility()
	{
	}

	public void RevertPlayerToNormal(bool shouldAnimate = true, bool setCooldown = true)
	{
	}

	public override void OnVotingComplete()
	{
	}

	public override void SetCooldown()
	{
	}

	private bool ShouldUpdateUnshiftTimer()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	public void SetEvidence()
	{
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}
}
