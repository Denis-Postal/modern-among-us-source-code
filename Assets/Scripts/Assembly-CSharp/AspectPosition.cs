using UnityEngine;

public class AspectPosition : MonoBehaviour
{
	public enum EdgeAlignments
	{
		RightBottom = 6,
		LeftBottom = 5,
		RightTop = 10,
		Left = 1,
		Right = 2,
		Top = 8,
		Bottom = 4,
		LeftTop = 9,
		Center = 16
	}

	public Camera parentCam;

	private const int LeftFlag = 1;

	private const int RightFlag = 2;

	private const int BottomFlag = 4;

	private const int TopFlag = 8;

	private const int CenterFlag = 16;

	public bool updateAlways;

	[Tooltip("Screen Coordinates 0-1")]
	public Vector2 anchorPoint;

	public Vector3 DistanceFromEdge;

	public EdgeAlignments Alignment;

	public void Update()
	{
	}

	private void OnEnable()
	{
	}

	internal void SetNormalizedX(float nx, float widthPadding)
	{
	}

	private void OnDisable()
	{
	}

	public void AdjustPosition()
	{
	}

	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen)
	{
	}

	public void AdjustPosition(float aspect)
	{
	}

	public static Vector3 ComputeWorldPosition(Camera cam, EdgeAlignments alignment, Vector3 relativePos)
	{
		return default(Vector3);
	}

	public static Vector3 ComputePosition(EdgeAlignments alignment, Vector3 relativePos)
	{
		return default(Vector3);
	}

	public static Vector3 ComputePosition(EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect)
	{
		return default(Vector3);
	}

	public static Vector3 ComputePositionSafeArea(EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect, Camera cam)
	{
		return default(Vector3);
	}

	public Vector3 ComputePositionAnchor(Camera cam, Vector3 relativePos, Vector2 anchor, float aspect)
	{
		return default(Vector3);
	}
}
