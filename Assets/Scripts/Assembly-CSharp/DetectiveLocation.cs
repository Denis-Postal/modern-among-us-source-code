using System.Collections.Generic;
using UnityEngine;

public class DetectiveLocation : MonoBehaviour
{
	public SystemTypes associatedRoom;

	public List<NetworkedPlayerInfo> playersInRoom;

	public bool IsPlayerInRoom(NetworkedPlayerInfo player)
	{
		return false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
