using UnityEngine;

public class Wire : MonoBehaviour
{
	private const int WireDepth = -14;

	public SpriteRenderer Liner;

	public SpriteRenderer ColorBase;

	public SpriteRenderer SymbolBase;

	public SpriteRenderer ColorEnd;

	public Collider2D hitbox;

	public SpriteRenderer WireTip;

	public sbyte WireId;

	public Vector2 BaseWorldPos { get; internal set; }

	public void Start()
	{
	}

	public void ResetLine(Vector3 targetWorldPos, bool reset = false)
	{
	}

	public void ConnectRight(WireNode node)
	{
	}

	public void SetColor(Color color, Sprite symbol)
	{
	}
}
