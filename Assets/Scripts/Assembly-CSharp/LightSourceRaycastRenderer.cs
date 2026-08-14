using System.Collections.Generic;
using UnityEngine;

public class LightSourceRaycastRenderer : LightSourceRenderer
{
	private class VertInfo
	{
		public float Angle;

		public Vector3 Position;

		internal void Complete(float x, float y)
		{
		}

		internal void Complete(Vector2 point)
		{
		}
	}

	private class AngleComparer : IComparer<VertInfo>
	{
		public static readonly AngleComparer Instance;

		public int Compare(VertInfo x, VertInfo y)
		{
			return 0;
		}
	}

	private class HitDepthComparer : IComparer<RaycastHit2D>
	{
		public static readonly HitDepthComparer Instance;

		public int Compare(RaycastHit2D x, RaycastHit2D y)
		{
			return 0;
		}
	}

	private Camera camera;

	private List<VertInfo> verts;

	private int vertCount;

	private Vector3[] vec;

	private Vector2[] uvs;

	private int[] triangles;

	private RaycastHit2D[] buffer;

	private ContactFilter2D filter;

	private Collider2D[] hits;

	private Vector2[] requiredDels;

	private Mesh myMesh;

	private Vector2 del;

	private Vector2 tan;

	private Vector2 side;

	private List<RaycastHit2D> lightHits;

	public override LightSourceRendererType Type => default(LightSourceRendererType);

	public LightSourceRaycastRenderer(LightSource lightSource)
		: base(null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Render(Vector2 origin)
	{
	}

	public override void Dispose()
	{
	}

	private float GetValidViewDistance()
	{
		return 0f;
	}

	private void RaycastShadows(Vector2 origin)
	{
	}

	private void TestBothSides(Vector2 origin)
	{
	}

	private void CreateVert(Vector2 origin, ref Vector2 del)
	{
	}

	private VertInfo GetEmptyVert()
	{
		return null;
	}

	private static float length(float x, float y)
	{
		return 0f;
	}

	public static float PseudoAngle(float dx, float dy)
	{
		return 0f;
	}
}
