using System;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class StarGen : MonoBehaviour
{
	[Serializable]
	private struct Stars
	{
		public float Size;

		public float Rate;

		public float PositionX;

		public float PositionY;
	}

	public static StarGen instance;

	public int NumStars = 500;

	public float Length = 25f;

	public float Width = 25f;

	public float MaxStarRadius = 0.05f;

	public Vector2 Direction = new Vector2(1f, 0f);

	private Vector2 NormDir = new Vector2(1f, 0f);

	private Vector2 Tangent = new Vector2(0f, 1f);

	private float tanLen = 1f;

	public FloatRange Sizes = new FloatRange(0.01f, 0.05f);

	public FloatRange Rates = new FloatRange(0.25f, 1f);

	[HideInInspector]
	private Stars[] stars;

	[HideInInspector]
	private Vector3[] verts;

	[HideInInspector]
	private Mesh mesh;

	private static readonly Color32 StarColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	public void Awake()
	{
		instance = this;
		MeshRenderer component = GetComponent<MeshRenderer>();
		if (component != null)
		{
			component.sortingOrder = -1000;
			if (component.sharedMaterial != null)
			{
				component.sharedMaterial.renderQueue = 2500;
			}
		}
	}

	public void Start()
	{
		if (NumStars <= 0)
		{
			return;
		}
		stars = new Stars[NumStars];
		verts = new Vector3[NumStars * 4];
		Vector2[] uvs = new Vector2[NumStars * 4];
		Color32[] colors = new Color32[NumStars * 4];
		int[] indices = new int[NumStars * 6];
		SetDirection(Direction);

		MeshFilter meshFilter = GetComponent<MeshFilter>();
		mesh = new Mesh();
		mesh.name = "StarGen Mesh";
		mesh.MarkDynamic();
		meshFilter.mesh = mesh;

		for (int i = 0; i < stars.Length; i++)
		{
			Stars star = stars[i];
			float forward = FloatRange.Next(-1f, 1f) * Length;
			float side = FloatRange.Next(-1f, 1f) * Width;
			float x = star.PositionX = forward * NormDir.x + side * Tangent.x;
			float y = star.PositionY = forward * NormDir.y + side * Tangent.y;
			float size = star.Size = NextStarSize();
			star.Rate = Rates.Next();
			stars[i] = star;

			int vert = i * 4;
			verts[vert].Set(x - size, y + size, 0f);
			verts[vert + 1].Set(x - size, y - size, 0f);
			verts[vert + 2].Set(x + size, y - size, 0f);
			verts[vert + 3].Set(x + size, y + size, 0f);

			uvs[vert].Set(-1f, 1f);
			uvs[vert + 1].Set(-1f, -1f);
			uvs[vert + 2].Set(1f, -1f);
			uvs[vert + 3].Set(1f, 1f);

			Color32 color = PickStarColor();
			colors[vert] = color;
			colors[vert + 1] = color;
			colors[vert + 2] = color;
			colors[vert + 3] = color;

			int index = i * 6;
			indices[index] = vert;
			indices[index + 1] = vert + 1;
			indices[index + 2] = vert + 2;
			indices[index + 3] = vert + 2;
			indices[index + 4] = vert;
			indices[index + 5] = vert + 3;
		}

		mesh.vertices = verts;
		mesh.uv = uvs;
		mesh.colors32 = colors;
		mesh.SetIndices(indices, MeshTopology.Triangles, 0);
		mesh.RecalculateBounds();
	}

	private void FixedUpdate()
	{
		if (stars == null || verts == null || mesh == null)
		{
			return;
		}

		float start = -0.99f * Length;
		Vector2 movement = Direction * Time.fixedDeltaTime;
		float maxSize = Mathf.Max(0.0001f, GetMaxStarSize());
		for (int i = 0; i < stars.Length; i++)
		{
			Stars star = stars[i];
			float size = star.Size;
			float x = star.PositionX;
			float y = star.PositionY;
			float speed = star.Rate * (size / maxSize);
			x += speed * movement.x;
			y += speed * movement.y;
			if (OrthoDistance(x, y) > Length)
			{
				float side = FloatRange.Next(-1f, 1f) * Width;
				x = start * NormDir.x + side * Tangent.x;
				y = start * NormDir.y + side * Tangent.y;
				star.Rate = Rates.Next();
			}

			star.PositionX = x;
			star.PositionY = y;
			stars[i] = star;

			int vert = i * 4;
			verts[vert].x = x - size;
			verts[vert].y = y + size;
			verts[vert + 1].x = x - size;
			verts[vert + 1].y = y - size;
			verts[vert + 2].x = x + size;
			verts[vert + 2].y = y - size;
			verts[vert + 3].x = x + size;
			verts[vert + 3].y = y + size;
		}
		mesh.vertices = verts;
		mesh.RecalculateBounds();
	}

	public void SetDirection(Vector2 dir)
	{
		if (dir.sqrMagnitude <= 0.0001f)
		{
			dir = Vector2.right;
		}
		Direction = dir;
		NormDir = Direction.normalized;
		Tangent = new Vector2(0f - NormDir.y, NormDir.x);
		tanLen = Mathf.Sqrt(Tangent.y * Tangent.y + Tangent.x * Tangent.x);
		if (tanLen <= 0.0001f)
		{
			tanLen = 1f;
		}
	}

	public void RegenPositions()
	{
		if (stars == null)
		{
			return;
		}
		for (int i = 0; i < stars.Length; i++)
		{
			float forward = FloatRange.Next(-1f, 1f) * Length;
			float side = FloatRange.Next(-1f, 1f) * Width;
			stars[i].PositionX = forward * NormDir.x + side * Tangent.x;
			stars[i].PositionY = forward * NormDir.y + side * Tangent.y;
		}
	}

	private float OrthoDistance(float pointx, float pointy)
	{
		return (Tangent.y * pointx - Tangent.x * pointy) / tanLen;
	}

	private float NextStarSize()
	{
		float maxSize = GetMaxStarSize();
		float minSize = Sizes != null ? Sizes.min : 0.01f;
		minSize = Mathf.Clamp(minSize, 0.001f, maxSize);
		return FloatRange.Next(minSize, maxSize);
	}

	private float GetMaxStarSize()
	{
		if (MaxStarRadius > 0f)
		{
			return MaxStarRadius;
		}
		if (Sizes != null && Sizes.max > 0f)
		{
			return Sizes.max;
		}
		return 0.05f;
	}

	private static Color32 PickStarColor()
	{
		return StarColor;
	}
}
