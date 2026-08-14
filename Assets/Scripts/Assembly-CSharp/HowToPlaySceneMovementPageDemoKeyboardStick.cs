using UnityEngine;

public class HowToPlaySceneMovementPageDemoKeyboardStick : VirtualJoystick
{
	public SpriteRenderer UpKey;

	public SpriteRenderer DownKey;

	public SpriteRenderer LeftKey;

	public SpriteRenderer RightKey;

	protected override void FixedUpdate()
	{
	}

	public override void UpdateJoystick(HowToPlaySceneMovementPageFingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
	}
}
