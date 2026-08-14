using System.Collections.Generic;
using UnityEngine;

public class MultiPrefabInstantiator : MonoBehaviour
{
	[SerializeField]
	private GameObject prefab;

	private List<GameObject> instances;

	public int Count => 0;

	public T Create<T>() where T : Component
	{
		return null;
	}

	public GameObject GetInstance(int index)
	{
		return null;
	}

	public T GetInstanceComponent<T>(int index) where T : Component
	{
		return null;
	}

	public void DestroyInstance(GameObject obj)
	{
	}

	public void DestroyAll()
	{
	}
}
