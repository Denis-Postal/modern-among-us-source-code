using System.Collections.Generic;
using UnityEngine;

public class DetectiveLocationsController : MonoBehaviour
{
	public static DetectiveLocationsController Instance;

	public List<DetectiveLocation> DetectiveLocations;

	public List<DetectiveDeadBodyInfo> DeadBodyInfos;

	public SystemTypes DefaultLocation;

	private void Awake()
	{
	}

	public DetectiveLocation GetPlayerLocation(NetworkedPlayerInfo player)
	{
		return null;
	}

	public void AddBodyInfo(DetectiveDeadBodyInfo bodyInfo)
	{
	}
}
