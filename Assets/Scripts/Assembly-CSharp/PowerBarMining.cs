using System;
using Rewired;
using UnityEngine;

public class PowerBarMining : MonoBehaviour
{
	private static readonly string shaderPercentage;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private PassiveButton passiveButton;

	private float barSpeed;

	private float currentPercentage;

	private bool updatePowerMeter;

	private Action<float, Vector3> hitRock;

	private Action<float> onPitch;

	private Player gamepad;

	private Vector3 clickPos;

	private Controller controller;

	private void Awake()
	{
	}

	private void PowerMeterClick()
	{
	}

	private bool IsUsingController()
	{
		return false;
	}

	private void Update()
	{
	}

	public void Initialize(float speed, Action<float, Vector3> hitAction, Vector3 pos, Action<float> pitchAction)
	{
	}

	private void SetPercentage(float value)
	{
	}

	private void StopPowerMeter()
	{
	}
}
