using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FontData
{
	public Vector2 TextureSize;

	public List<Vector4> bounds;

	public List<Vector3> offsets;

	public List<Vector4> Channels;

	public Dictionary<int, int> charMap;

	public float LineHeight;

	public Dictionary<int, Dictionary<int, float>> kernings;

	public float GetKerning(int last, int cur)
	{
		return 0f;
	}
}
