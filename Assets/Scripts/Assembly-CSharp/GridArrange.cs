using System.Collections.Generic;
using UnityEngine;

public class GridArrange : MonoBehaviour
{
	public enum StartAlign
	{
		Left = 0,
		Right = 1
	}

	public Vector2 CellSize;

	public StartAlign Alignment;

	public int MaxColumns;

	private List<Transform> cells;

	private static List<Transform> currentChildren;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckCurrentChildren()
	{
	}

	private void GetChildsActive()
	{
	}

	private void ArrangeChilds()
	{
	}
}
