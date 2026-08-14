using Innersloth.DebugTool;
using UnityEngine;

public class TutorialDebugCommands : MonoBehaviour
{
	private static bool AutoResetTask;

	private void Update()
	{
	}

	public static void AddCommands(GameObject parent)
	{
	}

	public static void RemoveCommands(GameObject parent)
	{
	}

	[DebugCommand("Game/Toggle Auto-Reset Task After Complete", null, true)]
	public static void GameToggleAutoResetTask()
	{
	}
}
