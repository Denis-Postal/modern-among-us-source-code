using UnityEngine;

public class MapSelectButton : MonoBehaviour
{
	public PassiveButton Button;

	[SerializeField]
	private SpriteRenderer[] MapIcon;

	[SerializeField]
	private SpriteRenderer[] allSprites;

	[SerializeField]
	private BoxCollider2D boxCollider;

	public int MapID;

	public void SetImage(Sprite mapSprite, int maskLayer)
	{
		if (MapIcon != null)
		{
			for (int i = 0; i < MapIcon.Length; i++)
			{
				if ((bool)MapIcon[i])
				{
					MapIcon[i].sprite = mapSprite;
				}
			}
		}
		if (allSprites != null)
		{
			for (int j = 0; j < allSprites.Length; j++)
			{
				if ((bool)allSprites[j])
				{
					allSprites[j].gameObject.layer = maskLayer;
#if UNITY_EDITOR
					if (UnityEditor.EditorUtility.IsPersistent(allSprites[j]))
					{
						continue;
					}
#endif
					Material material = allSprites[j].gameObject.scene.IsValid() ? allSprites[j].material : allSprites[j].sharedMaterial;
					if ((bool)material)
					{
						PlayerMaterial.SetMaskLayer(material, maskLayer);
					}
				}
			}
		}
		if ((bool)Button)
		{
			Button.SetMaskLayer(maskLayer);
		}
		if ((bool)boxCollider)
		{
			boxCollider.enabled = true;
		}
	}
}
