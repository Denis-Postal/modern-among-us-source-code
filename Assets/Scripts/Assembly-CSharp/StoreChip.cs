using UnityEngine;

public class StoreChip : ColorChip
{
	public CosmeticData product;

	public StoreMannequin storeMannequin;

	public SpriteRenderer NameplateConfirmPreview;

	public StoreMenu Parent { get; set; }

	public void SetData(CosmeticData prod)
	{
	}
}
