using UnityEngine;

public class WireMinigame : Minigame
{
	private static readonly Color[] colors;

	public Sprite[] Symbols;

	public Wire[] LeftNodes;

	public WireNode[] RightNodes;

	public SpriteRenderer[] LeftLights;

	public SpriteRenderer[] RightLights;

	private Controller myController;

	private sbyte[] ExpectedWires;

	private sbyte[] ActualWires;

	public AudioClip[] WireSounds;

	private int prevSelectedWireIndex;

	private int selectedWireIndex;

	private bool prevButtonDown;

	private float inputCooldown;

	public Vector2 controllerWirePos;

	private const float controllerWireSpeed = 7f;

	public GameObject[] selectingWireGlyphs;

	public GameObject[] movingWireGlyphs;

	public Transform selectedWireUI;

	private bool TaskIsForThisPanel()
	{
		return false;
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	private void UpdateLights()
	{
	}

	private WireNode CheckRightSide(Vector2 pos)
	{
		return null;
	}

	private void CheckTask()
	{
	}
}
