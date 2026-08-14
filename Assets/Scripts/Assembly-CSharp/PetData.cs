using Innersloth.Assets;
using UnityEngine.AddressableAssets;

public class PetData : CosmeticData, IAddressableAssetProvider<PetBehaviour>
{
	public const string EmptyId = "pet_EmptyPet";

	public StringNames StoreName;

	public AssetReference PetPrefabRef;

	public bool IsEmpty => ProductId == EmptyId || name == EmptyId || string.IsNullOrEmpty(ProductId) && string.IsNullOrEmpty(name);

	public AddressableAsset<PetBehaviour> CreateAddressableAsset()
	{
		return null;
	}

	public AssetReference GetAssetReference()
	{
		return PetPrefabRef;
	}

	public override string GetItemCategory()
	{
		return "Pet";
	}

	public override void PreviewOnPlayer(PoolablePlayer p, int colorId, string resetIgnoreType = "")
	{
		if (p != null)
		{
			p.SetPetIdle(this, colorId);
		}
	}
}
