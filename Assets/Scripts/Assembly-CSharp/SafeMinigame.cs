using TMPro;
using UnityEngine;

public class SafeMinigame : Minigame
{
	private const float LowTumblerThreshold = 5f;

	private const float HighTumblerThreshold = 7f;

	private const float ReverseDirThreshold = 0.15f;

	public TextMeshPro ComboText;

	public Collider2D Tumbler;

	public SpriteRenderer TumblerBehind;

	public Collider2D Spinner;

	public SpriteRenderer[] Arrows;

	private int[] combo;

	private bool[] latched;

	private bool[] vibration;

	private Controller controller;

	private float lastTumDir;

	private Vector2 lastMouseVec;

	private float spinTime;

	private float spinDel;

	private float spinVel;

	private float reversalBuffer;

	public AudioClip DialTurnSound;

	public AudioClip DialGoodSound;

	public AudioClip SpinnerStartSound;

	public AudioClip SpinnerFreeSound;

	public AudioClip SpinnerStopSound;

	private AudioSource loopSound;

	private bool prevHadLeftInput;

	private bool prevHadRightInput;

	private Vector2 prevLeftInput;

	private Vector2 prevRightInput;

	private float leftStickStartAngle;

	public float TopSpinRate;

	public void OnEnable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void UpdateComboInstructions()
	{
	}

	private void Update()
	{
	}

	private void CheckTumblr(float delta, float tumRotZ, int unlatched, int expected)
	{
	}

	public override void Close()
	{
	}

	private bool AngleNear(float actual, float dir, float expected, float Threshold)
	{
		return false;
	}
}
