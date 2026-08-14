using UnityEngine;

public class StoreMannequin : MonoBehaviour
{
	[Header("Cosmetic Slots")]
	[SerializeField]
	private HatParent hat;

	[SerializeField]
	private VisorLayer visor;

	[SerializeField]
	private SpriteRenderer skin;

	[SerializeField]
	private SpriteRenderer pet;

	[Header("Materials")]
	[SerializeField]
	private Material defaultMaterial;

	[SerializeField]
	private Material playerMaterial;

	public void WearThing(IBuyable product, PlayerMaterial.MaskType maskType, int outfitColorOverride = -1)
	{
	}
}
