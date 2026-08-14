using System.Collections.Generic;
using UnityEngine;

public class SweepMinigame : Minigame
{
	public SpriteRenderer[] Spinners;

	public SpriteRenderer[] Shadows;

	public SpriteRenderer[] Lights;

	public HorizontalGauge[] Gauges;

	private int spinnerIdx;

	private float timer;

	public float SpinRate;

	private float initialTimer;

	public AudioClip SpinningSound;

	public AudioClip AcceptSound;

	public AudioClip RejectSound;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	public void FixedUpdate()
	{
	}

	private float CalcXPerc()
	{
		return 0f;
	}

	public void HitButton(int i)
	{
	}

	private void ResetGauges()
	{
	}
}
