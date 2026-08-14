using System;
using UnityEngine;

public class CosmeticGroups : ScriptableObject
{
	[SerializeField]
	private CosmeticVariantGroup[] variantGroups;

	[SerializeField]
	private CosmeticReleaseGroup[] releaseGroups;

	public CosmeticVariantGroup[] VariantGroups => null;

	public CosmeticReleaseGroup[] ReleaseGroups => null;

	public bool TryGetVariantGroup(CosmeticData cosmetic, out CosmeticVariantGroup output)
	{
		output = null;
		return false;
	}

	public bool TryGetReleaseGroup(CosmeticData cosmetic, out CosmeticReleaseGroup output)
	{
		output = null;
		return false;
	}

	public int GetReleaseGroupIndex(CosmeticData cosmetic)
	{
		return 0;
	}

	public int GetVariantGroupIndex(CosmeticData cosmetic)
	{
		return 0;
	}

	public DateTime GetReleaseGroupDate(CosmeticData cosmetic)
	{
		return default(DateTime);
	}

	private bool TryGetGroup<T>(T[] groups, CosmeticData cosmetic, out T output) where T : AbstractCosmeticGroup
	{
		output = null;
		return false;
	}

	private int GetGroupItemIndex<T>(T[] groups, CosmeticData cosmetic) where T : AbstractCosmeticGroup
	{
		return 0;
	}

	public void RebuildGroups(CosmeticVariantGroup[] variantGroups, CosmeticReleaseGroup[] releaseGroups)
	{
	}
}
