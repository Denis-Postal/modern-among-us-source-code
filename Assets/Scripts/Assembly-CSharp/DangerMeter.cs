using UnityEngine;

public class DangerMeter : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer[] barSprites;

	[SerializeField]
	private SpriteRenderer crewmateSeekerSprite;

	[SerializeField]
	private Color emptyColor;

	[SerializeField]
	private Color safeColor;

	[SerializeField]
	private Color cautionColor;

	[SerializeField]
	private Color dangerColor;

	private Vector3 originalLocalPosition;

	private Coroutine shakeCoroutine;

	public void SetDangerValue(float dangerLevel1, float dangerLevel2)
	{
	}

	private void SetFirstNBarColors(int numBars, Color color)
	{
	}
}
