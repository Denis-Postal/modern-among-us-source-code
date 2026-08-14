using UnityEngine;

public class VirtualJoystickController
{
	private Collider2D amTouching;

	private int fingerId;

	private Controller.TouchState MyTouch;

	public Vector2 DragPosition => default(Vector2);

	public Vector2 DragStartPosition => default(Vector2);

	public Camera mainCam { get; set; }

	public void Update()
	{
	}

	public DragState CheckDrag(Collider2D coll, Collider2D deadZone = null)
	{
		return default(DragState);
	}
}
