using UnityEngine;

public class DeadBody : MonoBehaviour
{
	public bool Reported;

	public byte ParentId;

	public Collider2D myCollider;

	public SpriteRenderer bloodSplatter;

	public SpriteRenderer[] bodyRenderers;

	public Vector2 TruePosition => default(Vector2);

	public void OnClick()
	{
	}
}
