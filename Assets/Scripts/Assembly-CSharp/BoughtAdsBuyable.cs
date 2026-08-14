using UnityEngine;

public class BoughtAdsBuyable : Object, IBuyable
{
	public string ProdId => null;

	public int BeanCost => 0;

	public int StarCost => 0;

	public string EpicId => null;

	public bool PaidOnMobile => false;

	public LimitedTimeStartEnd LimitedTimeAvailable => default(LimitedTimeStartEnd);
}
