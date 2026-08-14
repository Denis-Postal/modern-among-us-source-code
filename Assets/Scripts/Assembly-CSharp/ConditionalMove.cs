using System;
using UnityEngine;

public class ConditionalMove : MonoBehaviour
{
	[Serializable]
	public struct MoveForPlatforms
	{
		public RuntimePlatform runtimePlatform;

		public Vector3 offset;
	}

	public MoveForPlatforms[] moveForPlatforms;

	private void Awake()
	{
	}
}
