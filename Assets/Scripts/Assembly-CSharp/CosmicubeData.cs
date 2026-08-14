using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class CosmicubeData : ScriptableObject, IBuyable
{
	public AssetReference StoreImageRef;

	public AssetReference CosmicubePrefabRef;

	public AssetReference podIconRef;

	public string DateCreated;

	public List<UnlockableCosmetic> allUnlockables;

	public int starCost;

	public int beanCost;

	public int Order;

	public bool Free;

	public bool NotInStore;

	public FloatRange XRange;

	public FloatRange YRange;

	public string podId;

	[SerializeField]
	private string productId;

	[SerializeField]
	private string cosmicubeName;

	[SerializeField]
	private LimitedTimeStartEnd limitedTime;

	[SerializeField]
	private string epicId;

	public string ProdId => null;

	public int BeanCost => 0;

	public int StarCost => 0;

	public string EpicId => null;

	public bool PaidOnMobile => false;

	public bool IsAlwaysAvailable => false;

	public LimitedTimeStartEnd LimitedTimeAvailable => default(LimitedTimeStartEnd);

	public bool IsEmpty => false;

	public string GetCosmicubeName()
	{
		return null;
	}

	public string GetPodName()
	{
		return null;
	}

	public DateTime GetDateCreated()
	{
		return default(DateTime);
	}
}
