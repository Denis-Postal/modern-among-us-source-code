using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Weather1Game : Minigame
{
	private static int[] BarrierValidX;

	private static int[] BarrierValidY;

	private const int MinX = -10;

	private const int MaxX = 8;

	private const int MinY = -3;

	private const int MaxY = 3;

	public Tilemap BarrierMap;

	public Tile fillTile;

	public Tile controlTile;

	public Tile barrierTile;

	public SpriteRenderer pulseCircle1;

	public SpriteRenderer pulseCircle2;

	public AudioClip NodeMove;

	private Controller control;

	private bool inControl;

	private Vector3Int controlTilePos;

	private static Vector3Int[] Directions;

	private float moveCooldown;

	public void Start()
	{
	}

	private bool SolveMaze(Vector3Int curPos, HashSet<Vector3Int> solution)
	{
		return false;
	}

	public void Update()
	{
	}

	private void FillLine(Vector3Int controlTilePos, Vector3Int touchCellPos)
	{
	}

	private bool AnythingBetween(Vector3Int controlTilePos, Vector3Int touchCellPos)
	{
		return false;
	}

	private bool PointIsValid(Vector3Int touchCellPos)
	{
		return false;
	}

	private bool Contains<T>(T[] self, T item) where T : IComparable
	{
		return false;
	}
}
