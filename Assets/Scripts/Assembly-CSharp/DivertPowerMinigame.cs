using UnityEngine;

public class DivertPowerMinigame : Minigame
{
	public SystemTypes[] SliderOrder;

	public Collider2D[] Sliders;

	public LineRenderer[] Wires;

	public VerticalGauge[] Gauges;

	private int sliderId;

	public FloatRange SliderY;

	private Controller myController;

	public ActionMapGlyphDisplay glyphDisplay;

	private int inputJoystick;

	private bool prevHadInput;

	public override void Begin(PlayerTask task)
	{
	}

	public void FixedUpdate()
	{
	}
}
