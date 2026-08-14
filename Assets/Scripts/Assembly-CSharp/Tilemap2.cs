using UnityEngine;

public class Tilemap2 : MonoBehaviour
{
	public Sprite[] sprites;

	private Tile2[] tileData;

	public int Width;

	public int Height;

	internal void SetTile(Vector3Int vec, int tileId)
	{
	}

	internal void SetTransformMatrix(Vector3Int vec, Matrix4x4 rot90)
	{
	}

	internal MonoBehaviour GetTile(Vector3Int touchCellPos)
	{
		return null;
	}

	internal Vector3Int WorldToCell(Vector2 worldPos)
	{
		return default(Vector3Int);
	}
}
