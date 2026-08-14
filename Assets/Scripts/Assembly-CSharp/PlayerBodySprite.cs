using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class PlayerBodySprite
{
	public SpriteRenderer BodySprite;

	[FormerlySerializedAs("extraParts")]
	public SpriteRenderer[] LongModeParts;

	public PlayerPettingHand PettingHand;

	public SpriteRenderer HandHat;

	public Sprite GhostSprite;

	public Sprite[] ExtraGhostSprites;

	public PlayerBodyTypes Type;

	public Vector3 flippedCosmeticOffset;

	public Vector3 normalCosmeticOffset;

	public bool Visible
	{
		get
		{
			return BodySprite != null && BodySprite.enabled;
		}
		set
		{
			if (BodySprite != null)
			{
				BodySprite.enabled = value;
			}
			if (LongModeParts != null)
			{
				for (int i = 0; i < LongModeParts.Length; i++)
				{
					if (LongModeParts[i] != null)
					{
						LongModeParts[i].enabled = value;
					}
				}
			}
			if (HandHat != null)
			{
				HandHat.enabled = value;
			}
		}
	}

	public void SetFlipX(bool flipX)
	{
		if (BodySprite != null)
		{
			BodySprite.flipX = flipX;
		}
		if (LongModeParts != null)
		{
			for (int i = 0; i < LongModeParts.Length; i++)
			{
				if (LongModeParts[i] != null)
				{
					LongModeParts[i].flipX = flipX;
				}
			}
		}
		if (HandHat != null)
		{
			HandHat.flipX = flipX;
		}
	}
}
