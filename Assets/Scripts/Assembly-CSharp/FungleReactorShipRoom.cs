using UnityEngine;

public class FungleReactorShipRoom : PlainShipRoom, IReactorShipRoom
{
	[SerializeField]
	private GameObject reactorCableLeft;

	[SerializeField]
	private GameObject reactorCableRight;

	[SerializeField]
	private GameObject reactorMain;

	[SerializeField]
	private GameObject reactorMainBroken;

	private void Awake()
	{
	}

	public void StartMeltdown()
	{
	}

	public void StopMeltdown()
	{
	}
}
