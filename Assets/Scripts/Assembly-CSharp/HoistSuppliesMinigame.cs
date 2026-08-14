using Rewired;
using UnityEngine;

public class HoistSuppliesMinigame : Minigame
{
	private const string PULL_LOOP_NAME = "hoist_supplies_pull_loop_sfx";

	[SerializeField]
	private Collider2D draggable;

	[Header("Input")]
	[SerializeField]
	[Tooltip("The difficulty of the hoist minigame, increasing as the target gets closer to completion.")]
	private AnimationCurve liftMultiplierCurve;

	[SerializeField]
	[Range(0.01f, 4f)]
	[Tooltip("The forced delay (in seconds) between each hoist controller button press. Players cannot press the hoist button faster than this.")]
	private float controllerButtonDelay;

	[Range(0.01f, 2f)]
	[Tooltip("The amount added every time a controller button is pressed (Multiplied by the liftMultiplierCurve)")]
	[SerializeField]
	private float controllerRaiseAmount;

	[Range(0.01f, 2f)]
	[SerializeField]
	[Tooltip("The amount of offset to add to the pull-rope every time the controller pull button is pressed")]
	private float controllerPullAmount;

	[Header("Animation Speeds")]
	[SerializeField]
	[Tooltip("The Speed at which the hoisted sprite animates to it's intended offset each time the controller pull button is pressed. (Recommended between the 3-15 range)")]
	private float raiseAnimSpeed;

	[Tooltip("The Speed at which the pull-rope animates to it's intended offset each time the controller pull button is pressed. (Recommended between the 3-15 range)")]
	[SerializeField]
	private float pullAnimSpeed;

	[SerializeField]
	[Header("Rope")]
	private SpriteRenderer rope;

	[SerializeField]
	private Vector3 ropeTopPos;

	[SerializeField]
	private Vector3 ropeBottomPos;

	[SerializeField]
	private FloatRange ropeLength;

	[SerializeField]
	[Header("Basket")]
	private Transform basket;

	[SerializeField]
	private FloatRange basketSize;

	[SerializeField]
	private Vector3 basketTopPos;

	[SerializeField]
	private Vector3 basketBottomPos;

	[SerializeField]
	[Header("Draggable Rope")]
	private Vector3 draggableRopeTopPos;

	[SerializeField]
	private Vector3 draggableRopeBottomPos;

	[SerializeField]
	private Transform ropeTexture;

	[Header("Lights")]
	[SerializeField]
	private GameObject redCircle;

	[SerializeField]
	private GameObject greenCircle;

	[SerializeField]
	[Header("Controller Hint")]
	private GameObject controllerHintContainer;

	[SerializeField]
	[Header("Audio")]
	private AudioClip[] pullOneShotSfx;

	[SerializeField]
	private AudioClip pullLoopSfx;

	[Space(10f)]
	[SerializeField]
	private AnimationCurve pullLoopSfxVolumeCurve;

	[SerializeField]
	private float pullLoopSfxVolumeSpeed;

	private readonly Controller controller;

	private Player player;

	private bool completed;

	private Vector2 lastDragPosition;

	private float targetPullLoopVolume;

	private float truePullLoopVolume;

	private float targetRaisedValue;

	private float trueRaisedValue;

	private float targetPullValue;

	private float truePullValue;

	private float raisedValueOnDragStart;

	private float pullValueOnDragStart;

	private float lastControllerInputTime;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	[ContextMenu("ResetRope")]
	private void ResetRope()
	{
	}

	[ContextMenu("Complete Hoist")]
	private void CompleteHoist()
	{
	}

	private void SetRopePosition(float distanceFromTop)
	{
	}

	private void SetPullPosition(float amount)
	{
	}

	private void OnInputMethodChanged()
	{
	}

	private void PullLoopDynamics(AudioSource source, float dt)
	{
	}
}
