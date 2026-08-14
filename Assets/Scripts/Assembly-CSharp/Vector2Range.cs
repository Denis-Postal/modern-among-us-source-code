using System;
using UnityEngine;

[Serializable]
public struct Vector2Range
{
	public Vector2 min;

	public Vector2 max;

	public float Width => 0f;

	public float Height => 0f;

	public Vector2Range(Vector2 min, Vector2 max)
	{
		this.min = default(Vector2);
		this.max = default(Vector2);
	}

	public void LerpUnclamped(ref Vector3 output, float t, float z)
	{
	}

	public void Lerp(ref Vector3 output, float t, float z)
	{
	}

	public Vector2 Next()
	{
		return default(Vector2);
	}

	public static Vector2 NextEdge()
	{
		return default(Vector2);
	}
}
