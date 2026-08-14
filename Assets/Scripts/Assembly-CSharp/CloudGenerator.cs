using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
	private struct Cloud
	{
		public int CloudIdx;

		public float Rate;

		public float Size;

		public float FlipX;

		public float PositionX;

		public float PositionY;

		public float PositionZ;
	}

	public Sprite[] CloudImages;

	public int NumClouds;

	public float Length;

	public float Width;

	public Vector2 Direction;

	public FloatRange Rates;

	public FloatRange Sizes;

	public bool Depth;

	public float MaxDepth;

	public float ParallaxOffset;

	public float ParallaxStrength;

	[HideInInspector]
	private Cloud[] clouds;

	private Vector2[] ExtentCache;

	[HideInInspector]
	private Mesh mesh;

	private Vector2 NormDir;

	private Vector2 Tangent;

	private float tanLen;

	[HideInInspector]
	private Vector3[] verts;

	public void Start()
	{
	}

	public void SetDirection(Vector2 dir)
	{
	}

	private void Update()
	{
	}

	private float OrthoDistance(float pointx, float pointy)
	{
		return 0f;
	}
}
