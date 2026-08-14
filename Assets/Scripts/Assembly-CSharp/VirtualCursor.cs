using UnityEngine;

public class VirtualCursor : MonoBehaviour
{
	public float speed;

	private float currentSpeed;

	public float acceleration;

	public Vector2 screenBounds;

	public Vector3 position;

	private const float deadzone = 0.03f;

	private const float touchpadSensitivity = 4f;

	public Camera cam;

	public static Vector2 currentPosition;

	public static bool buttonDown;

	public static bool joystickMoved;

	public static VirtualCursor instance;

	public static int horizontalAxis;

	public static int verticalAxis;

	private int framesVisible;

	private const int minFramesToAppear = 3;

	private SpriteRenderer sr;

	private Vector2 prevTouchPos;

	private bool setTouchPos;

	public static bool CursorActive => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void SetWorldPosition(Vector2 worldPos)
	{
	}

	public void SetScreenPosition(Vector2 screenPos)
	{
	}

	private void Update()
	{
	}
}
