using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ReferenceData", menuName = "ReferenceData", order = 1)]
public class ReferenceData : ScriptableObject
{
	public string userFacingVersion;

	public int privacyPolicyVersion;

	public TextAsset credits;

	public List<CosmicubeData> cosmicubes;

	public List<StarBundle> starBundles;

	public List<PetData> pets;

	public List<HatData> hats;

	public List<SkinData> skins;

	public List<VisorData> visors;

	public List<NamePlateData> nameplates;

	public List<BundleData> bundles;

	public List<CosmeticData> CosmeticBlacklist;

	public List<CosmeticData> LongModeBlacklist;

	public List<TranslatedImageSet> languages;

	[Header("Store Features")]
	public List<FeaturedItemGroup> FeaturedItemGroups;

	public CosmeticGroups Groups;

	[Header("Store versions. MM/DD/YYYY")]
	public string StoreBundlesVersion;

	public string StoreHatsVersion;

	public string StoreOutfitsVersion;

	public string StorePetsVersion;

	public string StoreNameplatesVersion;

	public string StoreVisorsVersion;

	public string StoreCubesVersion;
}
