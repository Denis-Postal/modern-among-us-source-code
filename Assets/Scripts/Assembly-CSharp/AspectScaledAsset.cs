using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AspectScaledAsset : MonoBehaviour
{
	private class ScaledAsset
	{
		public float OriginalWidth;

		public ScaledAsset(float originalWidth)
		{
			OriginalWidth = originalWidth;
		}
	}

	private class ScaledSprite : ScaledAsset
	{
		public SpriteRenderer Sprite;

		public ScaledSprite(float originalWidth, SpriteRenderer sprite)
			: base(originalWidth)
		{
			Sprite = sprite;
		}
	}

	private class ScaledCollider : ScaledAsset
	{
		public BoxCollider2D Collider;

		public ScaledCollider(float originalWidth, BoxCollider2D collider)
			: base(originalWidth)
		{
			Collider = collider;
		}
	}

	private class ScaledText : ScaledAsset
	{
		public TextMeshPro Text;

		public ScaledText(float originalWidth, TextMeshPro text)
			: base(originalWidth)
		{
			Text = text;
		}
	}

	private class ScaledMask : ScaledAsset
	{
		public SpriteMask Mask;

		public ScaledMask(float originalWidth, SpriteMask mask)
			: base(originalWidth)
		{
			Mask = mask;
		}
	}

	[Header("Required")]
	[SerializeField]
	private List<SpriteRenderer> spritesToScale;

	[SerializeField]
	[Header("Optional")]
	private AspectPosition aspectPosition;

	[SerializeField]
	private int positionDirection;

	[SerializeField]
	private List<BoxCollider2D> collidersToScale;

	[SerializeField]
	private List<TextMeshPro> textToScale;

	[SerializeField]
	private List<SpriteMask> masksToScale;

	private float originalDistanceFromEdge;

	private List<ScaledSprite> allSprites;

	private List<ScaledCollider> allColliders;

	private List<ScaledText> allText;

	private List<ScaledMask> allMasks;

	private bool initialized;

	private void Awake()
	{
	}

	public void ScaleObject(float aspectDiff)
	{
	}
}
