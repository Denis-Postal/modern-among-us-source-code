using UnityEngine;

public class AdjustSteeringGame : Minigame
{
	private const float ArrowOffset = -3.25f;

	private const float ThrustOffset = -2.15f;

	private static readonly FloatRange ThrustRange;

	private static readonly FloatRange SteeringRange;

	public Collider2D Thrust;

	public Collider2D Steering;

	public SpriteRenderer ThrustTarget;

	public SpriteRenderer SteeringTarget;

	private Controller controller;

	private float TargetThrustY;

	private float TargetSteeringRot;

	private bool thrustLocked;

	private bool steeringLocked;

	private float startAngle;

	public AudioClip HornSound;

	private bool prevHadLeftInput;

	private bool prevHadRightInput;

	private Vector2 prevRightStickInput;

	private bool prevThrustWasGood;

	private bool prevSteeringWasGood;

	private bool playerHasDualshock;

	private const float rotationSensitivity = 0.035f;

	private const float hintVibrationIntensity = 0.5f;

	public void HonkHorn()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateControllerIsDualshock()
	{
	}

	public void Update()
	{
	}
}
