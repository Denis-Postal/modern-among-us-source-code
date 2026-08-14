using UnityEngine;

public class ScreenJoystick : MonoBehaviour, IVirtualJoystick
{
	private Collider2D[] hitBuffer;

	private Controller myController;

	private int touchId;

	public Vector2 DeltaL { get; private set; }

	public Vector2 DeltaR => default(Vector2);

	public void ToggleVisuals(bool on)
	{
	}

	private void FixedUpdate()
	{
	}
}
