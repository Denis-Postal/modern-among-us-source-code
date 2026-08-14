using System.Collections.Generic;
using Hazel.Udp;
using UnityEngine;

public class GameDiscovery : MonoBehaviour
{
	public JoinGameButton ButtonPrefab;

	public Transform ItemLocation;

	public float YStart;

	public float YOffset;

	public Scroller TargetArea;

	private Dictionary<string, JoinGameButton> received;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void Receive(BroadcastPacket packet)
	{
	}

	private void CreateButtonForAddess(string fromAddress, string[] gameNameParts)
	{
	}
}
