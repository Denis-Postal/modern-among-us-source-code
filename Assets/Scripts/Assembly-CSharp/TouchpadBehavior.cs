using Rewired.ControllerExtensions;
using UnityEngine;

public class TouchpadBehavior : MonoBehaviour
{
	private float aspect;

	private bool touching;

	private bool firstTouch;

	private Vector2 toCenter;

	private Vector2 firstTouchPos;

	private Vector2 delta;

	private Vector2 fromCenter;

	private IDualShock4Extension ds4;

	public float touchpadSensitivity;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GetExtension()
	{
	}

	private void Update()
	{
	}

	public bool IsTouching()
	{
		return false;
	}

	public bool IsFirstTouch()
	{
		return false;
	}

	public void ResetTouch()
	{
	}

	public Vector2 GetTouchVector()
	{
		return default(Vector2);
	}

	public Vector2 GetCenterToTouch()
	{
		return default(Vector2);
	}
}
