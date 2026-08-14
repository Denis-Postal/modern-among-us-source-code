using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCosmeticGroup : ScriptableObject
{
	[SerializeField]
	private List<string> ids;

	public IReadOnlyList<string> IDs => null;

	public int Count => 0;

	public bool Contains(CosmeticData cosmetic)
	{
		return false;
	}

	public bool Contains(string id)
	{
		return false;
	}

	public int IndexOf(CosmeticData cosmetic)
	{
		return 0;
	}
}
