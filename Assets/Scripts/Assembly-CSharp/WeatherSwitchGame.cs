using UnityEngine;

public class WeatherSwitchGame : Minigame
{
	public static StringNames[] ControlNames;

	public WeatherControl[] Controls;

	private WeatherNodeTask WeatherTask;

	public Transform buttonGlyph;

	public Vector3 buttonGlyphOffset_Off;

	public Vector3 buttonGlyphOffset_On;

	public AudioClip SwitchSound;

	public void Start()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}

	public void FlipSwitch(int i)
	{
	}
}
