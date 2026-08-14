using UnityEngine;

public class AspectSize : MonoBehaviour
{
	public Sprite Background;

	public SpriteRenderer Renderer;

	private Vector2 lastScreenSize;

	public float PercentWidth;

	private Vector3? originalScale;

	private void OnValidate()
	{
	}

	public static float CalculateSize(Vector3 parentPos, Sprite sprite, float percentWidth)
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void DoSetUp()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen)
	{
	}

	private void AdjustScale(float aspect)
	{
	}

	private float GetScale(float orthographicSize, float aspect)
	{
		return 0f;
	}
}
