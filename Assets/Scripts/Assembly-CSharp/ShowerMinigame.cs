using TMPro;
using UnityEngine;

public class ShowerMinigame : Minigame
{
	public VerticalGauge Gauge;

	public TextMeshPro PercentText;

	private float timer;

	public float MaxTime;

	public AudioClip washSound;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	public override void Close()
	{
	}
}
