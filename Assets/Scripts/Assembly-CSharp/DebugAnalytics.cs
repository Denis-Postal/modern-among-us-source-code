using Innersloth.DebugTool;
using UnityEngine;

public class DebugAnalytics : DestroyableSingleton<DebugAnalytics>
{
	public static bool AnalyticsEnabled;

	private Texture2D consoleBackground;

	private GUIStyle debugStyle;

	private const string analyticsText = "Analytics Enabled";

	public IAnalyticsReporter Analytics { get; private set; }

	private void OnGUI()
	{
	}

	private void Start()
	{
	}

	private new void OnDestroy()
	{
	}

	[DebugCommand("Analytics/Toggle Playtest Analytics", null, true)]
	public static void ToggleAnalytics()
	{
	}

	private void CreateAnalyticsReporter()
	{
	}
}
