using UnityEngine;

public class MouseCursorForConsole : MonoBehaviour
{
	public float speed;

	public float acceleration;

	public Vector2 screenBounds;

	public Vector3 position;

	public Camera cam;

	public static Vector2 currentPosition;

	public static bool buttonDown;

	public static bool joystickMoved;

	public static MouseCursorForConsole instance;

	public static int horizontalAxis;

	public static int verticalAxis;

	private int framesVisible;

	private const int minFramesToAppear = 3;

	private SpriteRenderer sr;

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

	public void SetScreenPosition(Vector2 screenPos)
	{
	}

	private void Update()
	{
	}
}
