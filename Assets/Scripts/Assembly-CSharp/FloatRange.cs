using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatRange
{
	public float min;

	public float max;

	public float Last { get; private set; }

	public float Width => max - min;

	public float Midpoint => (min + max) * 0.5f;

	public FloatRange(float min, float max)
	{
		this.min = min;
		this.max = max;
	}

	public float ChangeRange(float y, float min, float max)
	{
		return Mathf.Lerp(min, max, (y - this.min) / Width);
	}

	public float Clamp(float value)
	{
		return Mathf.Clamp(value, min, max);
	}

	public bool Contains(float t)
	{
		return min <= t && max >= t;
	}

	public float CubicLerp(float v)
	{
		if (min >= max)
		{
			return min;
		}
		v = Mathf.Clamp01(v);
		return v * v * v * (max - min) + min;
	}

	public float EitherOr()
	{
		return UnityEngine.Random.value > 0.5f ? min : max;
	}

	public float LerpUnclamped(float v)
	{
		return Mathf.LerpUnclamped(min, max, v);
	}

	public float Lerp(float v)
	{
		return Mathf.Lerp(min, max, v);
	}

	public float ExpOutLerp(float v)
	{
		return Lerp(1f - Mathf.Pow(2f, -10f * v));
	}

	public static float ExpOutLerp(float v, float min, float max)
	{
		return Mathf.Lerp(min, max, 1f - Mathf.Pow(2f, -10f * v));
	}

	public static float Next(float min, float max)
	{
		return UnityEngine.Random.Range(min, max);
	}

	public float Next()
	{
		return Last = UnityEngine.Random.Range(min, max);
	}

	public float NextMinDistance(float center, float minDistance)
	{
		float clampedCenter = Mathf.Clamp(center, min, max);
		float leftMax = clampedCenter - minDistance;
		float rightMin = clampedCenter + minDistance;
		bool canUseLeft = leftMax >= min;
		bool canUseRight = rightMin <= max;
		if (canUseLeft && canUseRight)
		{
			if (UnityEngine.Random.value > 0.5f)
			{
				return UnityEngine.Random.Range(min, leftMax);
			}
			return UnityEngine.Random.Range(rightMin, max);
		}
		if (canUseLeft)
		{
			return UnityEngine.Random.Range(min, leftMax);
		}
		if (canUseRight)
		{
			return UnityEngine.Random.Range(rightMin, max);
		}
		return Next();
	}

	public IEnumerable<float> Range(int numStops)
	{
		if (numStops <= 0)
		{
			yield return min;
			yield break;
		}
		for (int i = 0; i <= numStops; i++)
		{
			yield return Mathf.Lerp(min, max, (float)i / numStops);
		}
	}

	public IEnumerable<float> RandomRange(int numStops)
	{
		for (int i = 0; i <= numStops; i++)
		{
			yield return Next();
		}
	}

	internal float ReverseLerp(float t)
	{
		return Mathf.Clamp01((t - min) / Width);
	}

	public static float ReverseLerp(float t, float min, float max)
	{
		return Mathf.Clamp01((t - min) / (max - min));
	}

	public float SpreadToEdges(int idx, int stops)
	{
		return SpreadToEdges(min, max, idx, stops);
	}

	public IEnumerable<float> SpreadToEdges(int stops)
	{
		return SpreadToEdges(min, max, stops);
	}

	public IEnumerable<float> SpreadEvenly(int stops)
	{
		return SpreadEvenly(min, max, stops);
	}

	public static float SpreadToEdges(float min, float max, int i, int stops)
	{
		if (stops <= 1)
		{
			return min;
		}
		return Mathf.Lerp(min, max, (float)i / (stops - 1));
	}

	public static IEnumerable<float> SpreadToEdges(float min, float max, int stops)
	{
		for (int i = 0; i < stops; i++)
		{
			yield return SpreadToEdges(min, max, i, stops);
		}
	}

	public static float SpreadEvenly(float min, float max, int i, int stops)
	{
		if (stops <= 0)
		{
			return Mathf.Lerp(min, max, 0.5f);
		}
		return Mathf.Lerp(min, max, (i + 1f) / (stops + 1f));
	}

	public static IEnumerable<float> SpreadEvenly(float min, float max, int stops)
	{
		for (int i = 0; i < stops; i++)
		{
			yield return SpreadEvenly(min, max, i, stops);
		}
	}
}
