using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HatManager : DestroyableSingleton<HatManager>
{
	public Material DefaultShader;

	public Material PlayerMaterial;

	public Material MaskedPlayerMaterial;

	public Material MaskedMaterial;

	private PetData[] allPets;

	private HatData[] allHats;

	private SkinData[] allSkins;

	private VisorData[] allVisors;

	private NamePlateData[] allNamePlates;

	private List<StarBundle> allStarBundles;

	private List<BundleData> allBundles;

	private List<CosmeticData> allFeaturedItems;

	private List<BundleData> allFeaturedBundles;

	private List<CosmicubeData> allFeaturedCubes;

	private List<CosmeticData> longModeBlackList;

	private List<CosmeticData> CosmeticBlackList;

	public IReadOnlyList<HatData> AllHats => allHats ?? (allHats = LoadAll<HatData>());

	public IReadOnlyList<SkinData> AllSkins => allSkins ?? (allSkins = LoadAll<SkinData>());

	public IReadOnlyList<NamePlateData> AllNamePlates => allNamePlates ?? (allNamePlates = LoadAll<NamePlateData>());

	public IReadOnlyList<VisorData> AllVisors => allVisors ?? (allVisors = LoadAll<VisorData>());

	public IReadOnlyList<PetData> AllPets => allPets ?? (allPets = LoadAll<PetData>());

	public IReadOnlyList<BundleData> AllBundles => allBundles ?? new List<BundleData>();

	public IReadOnlyList<StarBundle> AllStarBundles => allStarBundles ?? new List<StarBundle>();

	public IReadOnlyList<CosmeticData> AllFeaturedItems => allFeaturedItems ?? new List<CosmeticData>();

	public IReadOnlyList<BundleData> AllFeaturedBundles => allFeaturedBundles ?? new List<BundleData>();

	public IReadOnlyList<CosmicubeData> AllFeaturedCubes => allFeaturedCubes ?? new List<CosmicubeData>();

	public void Initialize()
	{
		allPets = LoadAll<PetData>();
		allHats = LoadAll<HatData>();
		allSkins = LoadAll<SkinData>();
		allVisors = LoadAll<VisorData>();
		allNamePlates = LoadAll<NamePlateData>();
	}

	public void RefreshFeatured()
	{
	}

	public PetData GetPetById(string petId)
	{
		return FindById(AllPets, petId) ?? FindById(AllPets, PetData.EmptyId);
	}

	public PetData[] GetUnlockedPets()
	{
		return GetUnlocked(AllPets);
	}

	public HatData GetHatById(string hatId)
	{
		return FindById(AllHats, hatId) ?? FindById(AllHats, HatData.EmptyId);
	}

	public HatData[] GetUnlockedHats()
	{
		return GetUnlocked(AllHats);
	}

	public SkinData[] GetUnlockedSkins()
	{
		return GetUnlocked(AllSkins);
	}

	public SkinData GetSkinById(string skinId)
	{
		return FindById(AllSkins, skinId) ?? FindById(AllSkins, SkinData.EmptyId);
	}

	public VisorData[] GetUnlockedVisors()
	{
		return GetUnlocked(AllVisors);
	}

	public VisorData GetVisorById(string visorId)
	{
		return FindById(AllVisors, visorId) ?? FindById(AllVisors, VisorData.EmptyId);
	}

	public NamePlateData[] GetUnlockedNamePlates()
	{
		return GetUnlocked(AllNamePlates);
	}

	public NamePlateData GetNamePlateById(string namePlateId)
	{
		return FindById(AllNamePlates, namePlateId) ?? FindById(AllNamePlates, NamePlateData.EmptyId);
	}

	public bool CheckValidCosmetic(string cosmeticID)
	{
		return CheckLongModeValidCosmetic(cosmeticID);
	}

	public bool CheckLongModeValidCosmetic(string cosmeticID, bool ignoreLongMode = false)
	{
		if (string.IsNullOrEmpty(cosmeticID))
		{
			return true;
		}
		return FindById(AllHats, cosmeticID) != null || FindById(AllSkins, cosmeticID) != null || FindById(AllVisors, cosmeticID) != null || FindById(AllPets, cosmeticID) != null || FindById(AllNamePlates, cosmeticID) != null;
	}

	private T[] GetSorted<T>(List<T> all) where T : CosmeticData
	{
		return (all ?? new List<T>()).OrderBy((T item) => item.displayOrder).ThenBy((T item) => item.name).ToArray();
	}

	private T[] GetUnlocked<T>(IEnumerable<T> all) where T : CosmeticData
	{
		return (all ?? Enumerable.Empty<T>()).OrderBy((T item) => item.displayOrder).ThenBy((T item) => item.name).ToArray();
	}

	private static T[] LoadAll<T>() where T : CosmeticData
	{
		return CosmeticAssetLoader.LoadAll<T>().Where((T item) => item != null).OrderBy((T item) => item.displayOrder).ThenBy((T item) => item.name).ToArray();
	}

	private static T FindById<T>(IEnumerable<T> all, string id) where T : CosmeticData
	{
		if (all == null || string.IsNullOrEmpty(id))
		{
			return null;
		}
		foreach (T item in all)
		{
			string itemId = PlayerCustomization.GetCosmeticId(item, string.Empty);
			if (itemId == id || item.name == id)
			{
				return item;
			}
		}
		return null;
	}
}
