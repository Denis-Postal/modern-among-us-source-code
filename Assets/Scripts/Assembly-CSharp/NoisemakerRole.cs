using System.Text;
using UnityEngine;

public class NoisemakerRole : CrewmateRole
{
	[SerializeField]
	private AudioClip deathSound;

	[SerializeField]
	private GameObject deathArrowPrefab;

	private const string SFX_ALERT_NAME = "NoisemakerAlert";

	private const float FALLOFF_START_DISTANCE = 7f;

	private const float FALLOFF_MAX_DISTANCE = 50f;

	private const float MIN_VOL_ALERT = 0.5f;

	private const float VIBRATION_INTENSITY = 1f;

	private const float VIBRATION_DURATION = 1.2f;

	private NoisemakerArrow deathArrow;

	private bool impostorAlert => false;

	private float alertDuration => 0f;

	public void NotifyOfDeath()
	{
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	public override void OnDeath(DeathReason reason)
	{
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}

	private bool KilledByViper()
	{
		return false;
	}
}
