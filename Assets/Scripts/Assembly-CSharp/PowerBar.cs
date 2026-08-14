using UnityEngine;

public class PowerBar : MonoBehaviour
{
	public SpriteRenderer SegmentPrefab;

	public Sprite greenImage;

	public Sprite yellowImage;

	public Sprite redImage;

	public Sprite greenEmptyImage;

	public Sprite yellowEmptyImage;

	public Sprite redEmptyImage;

	public int numberGreen;

	public int numberYellow;

	public int numberRed;

	public float Width;

	private float value;

	private SpriteRenderer[] Segments;

	public int NumSegments => 0;

	public void Awake()
	{
	}

	public void SetValue(float value)
	{
	}

	public void Update()
	{
	}
}
