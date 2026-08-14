using System;
using System.Collections.Generic;
using UnityEngine;

namespace InnerNet
{
	public class InnerNetObjectCollection
	{
		private readonly List<InnerNetObject> allObjects = new List<InnerNetObject>();

		private readonly List<InnerNetObject> allReliableObjects = new List<InnerNetObject>();

		private readonly List<InnerNetObject> allUnreliableObjects = new List<InnerNetObject>();

		private readonly Dictionary<uint, InnerNetObject> allObjectsFast = new Dictionary<uint, InnerNetObject>();

		private readonly Logger logger = new Logger(Logger.Category.Network, "InnerNetObjects");

		public IReadOnlyList<InnerNetObject> AllObjects => allObjects;

		public IReadOnlyList<InnerNetObject> AllReliableObjects => allReliableObjects;

		public IReadOnlyList<InnerNetObject> AllUnreliableObjects => allUnreliableObjects;

		public IReadOnlyDictionary<uint, InnerNetObject> AllObjectsFast => allObjectsFast;

		public void Clear()
		{
			allObjects.Clear();
			allReliableObjects.Clear();
			allUnreliableObjects.Clear();
			allObjectsFast.Clear();
		}

		public bool TryAddNetObject(InnerNetObject obj)
		{
			if (obj == null || obj.NetId == 0u || allObjectsFast.ContainsKey(obj.NetId))
			{
				return false;
			}
			allObjects.Add(obj);
			allObjectsFast[obj.NetId] = obj;
			if (obj.sendMode == Hazel.SendOption.Reliable)
			{
				allReliableObjects.Add(obj);
			}
			else
			{
				allUnreliableObjects.Add(obj);
			}
			return true;
		}

		public void RemoveNetObject(InnerNetObject obj)
		{
			if (obj == null)
			{
				return;
			}
			allObjects.Remove(obj);
			allReliableObjects.Remove(obj);
			allUnreliableObjects.Remove(obj);
			if (obj.NetId != 0u)
			{
				allObjectsFast.Remove(obj.NetId);
			}
		}

		public void RemoveNullObjects()
		{
			allObjects.RemoveAll(o => o == null);
			allReliableObjects.RemoveAll(o => o == null);
			allUnreliableObjects.RemoveAll(o => o == null);
		}

		public void RemoveUnownedObjects(HashSet<int> clientIds, int ownerClientId, Action<GameObject> removalAction)
		{
			for (int i = allObjects.Count - 1; i >= 0; i--)
			{
				InnerNetObject obj = allObjects[i];
				if (obj == null)
				{
					RemoveNetObject(obj);
					continue;
				}
				if (obj.OwnerId != ownerClientId && (clientIds == null || !clientIds.Contains(obj.OwnerId)))
				{
					RemoveNetObject(obj);
					removalAction?.Invoke(obj.gameObject);
				}
			}
		}

		public void DestroyPlayerInfoObjects(Action<GameObject> destroyAction)
		{
			for (int i = allObjects.Count - 1; i >= 0; i--)
			{
				if (allObjects[i] is NetworkedPlayerInfo info)
				{
					RemoveNetObject(info);
					destroyAction?.Invoke(info.gameObject);
				}
			}
		}
	}
}
