using TMPro;

public class VitalsMinigame : Minigame
{
	public TextMeshPro BatteryText;

	public VitalsPanel PanelPrefab;

	public TextMeshPro SabText;

	public float XStart;

	public float YStart;

	public float XOffset;

	public float YOffset;

	private VitalsPanel[] vitals;

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}
}
