using UnityEngine;

public class VirtualJoystick : MonoBehaviour, IVirtualJoystick
{
	public float InnerRadius;

	public float OuterRadius;

	public CircleCollider2D Outer;

	public SpriteRenderer Inner;

	public SpriteRenderer[] AllSprites;

	public bool IsDragged;

	public bool IsRightJoystick;

	private VirtualJoystickController myController;

	public Vector2 DeltaL { get; private set; }

	public Vector2 DeltaR { get; private set; }

	public void ToggleVisuals(bool on)
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	public virtual void UpdateJoystick(HowToPlaySceneMovementPageFingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
	}
}
