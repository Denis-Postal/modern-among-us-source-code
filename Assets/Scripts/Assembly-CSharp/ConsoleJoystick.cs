using Rewired;
using UnityEngine;

public class ConsoleJoystick : MonoBehaviour, IVirtualJoystick
{
	public enum ConsoleInputState
	{
		Gameplay = 0,
		Menu = 1,
		Task = 2,
		Sabotage = 3,
		Vent = 4,
		QuickChat = 5,
		None = 6
	}

	private Vector2 delta;

	private Vector2 deltaR;

	private static Player player;

	private static Rewired.Controller controller;

	private static Rewired.Controller prevController;

	public static ConsoleInputState inputState;

	private static ConsoleInputState oldInputState;

	private static int highlightedVentIndex;

	public Vector2 DeltaL => default(Vector2);

	public Vector2 DeltaR => default(Vector2);

	public void ToggleVisuals(bool on)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static void ReapplyCurrentInputState()
	{
	}

	public static void SetMode_MenuAdditive()
	{
	}

	public static void SetMode_Gameplay()
	{
	}

	public static void SetMode_Menu()
	{
	}

	public static void SetMode_Task()
	{
	}

	public static void SetMode_Sabotage()
	{
	}

	public static void SetMode_Vent()
	{
	}

	public static void SetMode_QuickChat()
	{
	}

	public static void SetMode_None()
	{
	}

	private static void SetMapEnabled(int rewiredCategoryIndex, bool enableMap)
	{
	}

	private void Update()
	{
	}

	private void HandleHUD()
	{
	}
}
