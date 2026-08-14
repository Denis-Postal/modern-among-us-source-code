using System;
using Rewired;
using UnityEngine;

public class ActiveInputManager : DestroyableSingleton<ActiveInputManager>
{
	public enum InputType
	{
		Joystick = 0,
		Keyboard = 1,
		Touch = 2
	}

	public InputType testCurrentControlType;

	public static InputType currentControlType;

	public double kChangeTime;

	public double mChangeTime;

	public double jChangeTime;

	public double tChangeTime;

	private Vector2 lastMousePosition;

	public static Action CurrentInputSourceChanged;

	private Rewired.Controller lastUsedController;

	private static InputType PlatformDefault => default(InputType);

	public Rewired.Controller CurrentController => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnLastActiveControllerChanged(Player player, Rewired.Controller controller)
	{
	}

	public void UpdateActiveControlType()
	{
	}

	private bool ShouldEnableTouch()
	{
		return false;
	}
}
