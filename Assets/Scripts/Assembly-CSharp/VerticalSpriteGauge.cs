using UnityEngine;

public class VerticalSpriteGauge : MonoBehaviour
{
	public float Value;

	public float MaxValue;

	public FloatRange YRange;

	public SpriteRenderer Mask;

	private float lastValue;

	public float TopY { get; private set; }

	public void Update()
	{
	}
}
