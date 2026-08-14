using System;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
	public static void SetAllGameObjectsActive<T>(this IList<T> self, bool isActive) where T : MonoBehaviour
	{
	}

	public static T Find<T>(this List<T> self, GameObject toFind) where T : MonoBehaviour
	{
		return null;
	}

	public static void SetLocalX(this Transform self, float x)
	{
	}

	public static void SetLocalY(this Transform self, float y)
	{
	}

	public static void SetLocalZ(this Transform self, float z)
	{
	}

	public static void SetWorldZ(this Transform self, float z)
	{
	}

	public static void LookAt2d(this Transform self, Vector3 target)
	{
	}

	public static void LookAt2d(this Transform self, Transform target)
	{
	}

	public static void DestroyChildren(this Transform self)
	{
	}

	public static void DestroyChildren(this MonoBehaviour self)
	{
	}

	public static bool IsDestroyedOrNull(this MonoBehaviour self)
	{
		return false;
	}

	public static bool IsDestroyedOrNull(this GameObject self)
	{
		return false;
	}

	public static void ForEachChild(this GameObject self, Action<GameObject> todo)
	{
	}

	public static void ForEachChildBehavior<T>(this MonoBehaviour self, Action<T> todo) where T : MonoBehaviour
	{
	}
}
