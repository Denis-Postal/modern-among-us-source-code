using UnityEngine;

public class FungleSurveillanceMinigame : Minigame
{
	private const float MAGIC_Z_INDEX = 50f;

	[SerializeField]
	private FungleSecurityCamera securityCamera;

	[SerializeField]
	private MeshRenderer viewport;

	[SerializeField]
	private Vector3 initialOffset;

	[SerializeField]
	private float cameraOrthographicSize;

	[Header("Speeds")]
	[SerializeField]
	private float keyboardMoveSpeed;

	[SerializeField]
	private float buttonMoveSpeed;

	[SerializeField]
	private float joystickMoveSpeed;

	[SerializeField]
	private float mobileJoystickMoveSpeed;

	[Header("Navigation")]
	[SerializeField]
	private PassiveButton arrowUp;

	[SerializeField]
	private PassiveButton arrowDown;

	[SerializeField]
	private PassiveButton arrowLeft;

	[SerializeField]
	private PassiveButton arrowRight;

	[SerializeField]
	private VirtualJoystick virtualJoystick;

	private Vector2 cameraSpeed;

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	private void SetSpeed(Vector2 speed)
	{
	}

	private void OnCameraCollision(Collision2D col)
	{
	}

	private void OnCameraExitCollision(Collision2D col)
	{
	}
}
