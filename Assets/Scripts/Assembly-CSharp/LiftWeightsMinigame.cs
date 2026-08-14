using Rewired;
using UnityEngine;

public class LiftWeightsMinigame : Minigame
{
	private enum State
	{
		Idle = 0,
		Lifting = 1,
		Dropping = 2
	}

	private const string BAR_FILL_SFX = "liftWeightsBarFillLoop";

	[SerializeField]
	private Transform barbell;

	[SerializeField]
	private Collider2D actionButton;

	[SerializeField]
	private Transform top;

	[SerializeField]
	private Transform bottom;

	[SerializeField]
	private AnimationCurve liftSpeedCurve;

	[SerializeField]
	private AnimationCurve dropSpeedCurve;

	[SerializeField]
	private float secondsToLift;

	[SerializeField]
	private SpriteRenderer[] counters;

	[SerializeField]
	private Transform fillBarParent;

	[SerializeField]
	private SpriteRenderer fillBar;

	[SerializeField]
	private Transform validIndicator;

	[SerializeField]
	private FloatRange fillBarScaleRange;

	[SerializeField]
	private FloatRange validFillPercentRange;

	[SerializeField]
	private Sprite buffSprite;

	[SerializeField]
	private Sprite weakSprite;

	[SerializeField]
	private SpriteRenderer buffButton;

	[SerializeField]
	private SpriteRenderer hands;

	[Header("Sounds")]
	[SerializeField]
	private AudioClip startLiftingSound;

	[SerializeField]
	private AudioClip barfillSound;

	[SerializeField]
	private AudioClip completeRepSound;

	[SerializeField]
	private AudioClip completeAllRepsSound;

	[SerializeField]
	private AudioClip failRepSound;

	private readonly Controller controller;

	private Player player;

	private bool hasInput;

	private State state;

	private float currentBarFillPercent;

	private float liftStartTime;

	private float dropStartTime;

	private float secondsToDrop;

	private AudioSource barfillAudioSource;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private bool GetTouchInput()
	{
		return false;
	}

	public bool GetControllerInput()
	{
		return false;
	}

	private void StartLifting()
	{
	}

	private void ContinueLifting()
	{
	}

	private void EndLifting()
	{
	}

	private void SetBarFill(float t)
	{
	}

	private void UpdateBarbellPosition()
	{
	}

	private void OnValidate()
	{
	}

	private void InitializeValidIndicator()
	{
	}

	public override void Close()
	{
	}
}
