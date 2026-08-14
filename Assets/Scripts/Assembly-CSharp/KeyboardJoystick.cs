using Rewired;
using UnityEngine;

public class KeyboardJoystick : MonoBehaviour, IVirtualJoystick
{
	private Vector2 del;

	private static Player player;

	private Controller myController;

	private Collider2D[] hitBuffer;

	private int touchId;

	public Vector2 DeltaL => default(Vector2);

	public Vector2 DeltaR => default(Vector2);

	public void ToggleVisuals(bool on)
	{
	}

	private void UpdateTouchMovement()
	{
	}

	private void Update()
	{
	}

	private static void HandleHud()
	{
	}
}
