using System;
using Hazel;
using UnityEngine;

public class ElectricalDoors : MonoBehaviour, ISystemType
{
	[Serializable]
	public class DoorSet
	{
		public string Name;

		public StaticDoor[] Doors;

		public override string ToString()
		{
			return null;
		}
	}

	public StaticDoor[] Doors;

	public DoorSet[] Rooms;

	public DoorSet LeftExits;

	public bool IsDirty { get; private set; }

	[ContextMenu("Shuffle Doors")]
	public void Initialize()
	{
	}

	public void Deteriorate(float deltaTime)
	{
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	public void MarkClean()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
