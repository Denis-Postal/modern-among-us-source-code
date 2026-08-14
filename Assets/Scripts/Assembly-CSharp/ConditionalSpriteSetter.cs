using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ConditionalSpriteSetter : MonoBehaviour
{
	public bool ignoreIfNoSpriteForPlatform;

	public ConditionalSprite sprite;

	private void Start()
	{
	}
}
