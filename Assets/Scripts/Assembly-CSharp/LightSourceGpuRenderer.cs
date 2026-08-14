using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LightSourceGpuRenderer : LightSourceRenderer
{
	public delegate void AddEdgeDelegate(Vector3 a, Vector3 b);

	private const float TWO_PI = (float)Math.PI * 2f;

	private Mesh occluderMesh;

	private List<Vector3> occVerts;

	private List<Vector3> occNorms;

	private List<Vector2> occUVs;

	private List<int> occTris;

	private Collider2D[] hits;

	private Material shadowCasterMaterial;

	private CommandBuffer cb;

	private bool noGeomSupport;

	private RenderTexture shadowTexture;

	private AddEdgeDelegate AddEdge;

	public override LightSourceRendererType Type => default(LightSourceRendererType);

	public LightSourceGpuRenderer(LightSource lightSource)
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

	private void GenerateShadowmap()
	{
	}

	private void GPUShadows(Vector2 origin)
	{
	}

	private void ClearEdges()
	{
	}

	private void UpdateOccMesh()
	{
	}

	private void DrawOcclusion(float effectiveRadius)
	{
	}

	private void DebugDrawRadius(Vector2 center, float radius)
	{
	}

	private void AddEdgeNoGeom(Vector3 a, Vector3 b)
	{
	}

	private void AddEdgeInternal(Vector3 a, Vector3 b, Vector2 uv)
	{
	}

	private void AddEdgeDefault(Vector3 a, Vector3 b)
	{
	}
}
