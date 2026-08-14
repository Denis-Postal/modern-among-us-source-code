using System.Collections.Generic;
using UnityEngine;

public class CounterArea : MonoBehaviour
{
	public SystemTypes RoomType;

	public ObjectPoolBehavior pool;

	private List<PoolableBehavior> myIcons;

	public float XOffset;

	public float YOffset;

	public int MaxWidth;

	public int MaxColumns;

	public bool DetectiveExclusiveLocation;

	public void UpdateCount(int cnt)
	{
	}
}
