using System.Collections.Generic;
using InnerNet;
using UnityEngine;

public class GameData : MonoBehaviour, IDisconnectHandler
{
	public static GameData Instance;

	public static float TimeGameStarted;

	public static float TimeLastMeetingStarted;

	public static int MeetingCount;

	public static int RoundsPlayedInSession;

	public static DeathReason LastDeathReason;

	public List<NetworkedPlayerInfo> AllPlayers;

	private List<NetworkedPlayerInfo> PlayerQueue;

	public int TotalTasks;

	public int CompletedTasks;

	public RoleBehaviour DefaultRole;

	public NetworkedPlayerInfo PlayerInfoPrefab;

	public const byte InvalidPlayerId = byte.MaxValue;

	public const byte DisconnectedPlayerId = 254;

	public int PlayerCount => AllPlayers != null ? AllPlayers.Count : 0;

	public bool IsPersistent => false;

	public static void DestroyInstance()
	{
		if ((bool)Instance)
		{
			UnityEngine.Object.Destroy(Instance.gameObject);
			Instance = null;
		}
	}

	public static void OnMeetingStart()
	{
	}

	public static void OnGameEnd()
	{
	}

	public static void OnDisconnected()
	{
		DestroyInstance();
	}

	public void Awake()
	{
		if ((bool)Instance && Instance != this)
		{
			UnityEngine.Object.Destroy(gameObject);
			return;
		}
		Instance = this;
		if (AllPlayers == null)
		{
			AllPlayers = new List<NetworkedPlayerInfo>();
		}
		if (PlayerQueue == null)
		{
			PlayerQueue = new List<NetworkedPlayerInfo>();
		}
		if (AmongUsClient.Instance != null && !AmongUsClient.Instance.DisconnectHandlers.Contains(this))
		{
			AmongUsClient.Instance.DisconnectHandlers.Add(this);
		}
		DisableVisiblePlayerInfoObjects();
	}

	private void DisableVisiblePlayerInfoObjects()
	{
		NetworkedPlayerInfo[] infos = UnityEngine.Object.FindObjectsOfType<NetworkedPlayerInfo>();
		for (int i = 0; i < infos.Length; i++)
		{
			if (infos[i] == null)
			{
				continue;
			}
			Renderer[] renderers = infos[i].GetComponentsInChildren<Renderer>(true);
			for (int j = 0; j < renderers.Length; j++)
			{
				renderers[j].enabled = false;
			}
			Collider2D[] colliders = infos[i].GetComponentsInChildren<Collider2D>(true);
			for (int k = 0; k < colliders.Length; k++)
			{
				colliders[k].enabled = false;
			}
		}
	}

	public NetworkedPlayerInfo GetHost()
	{
		return AmongUsClient.Instance != null ? GetPlayerByClient(AmongUsClient.Instance.GetHost()) : null;
	}

	public bool HasPlayer(ClientData client)
	{
		return GetPlayerByClient(client) != null;
	}

	public sbyte GetPlayerIdFromClient(ClientData client)
	{
		NetworkedPlayerInfo info = GetPlayerByClient(client);
		return info != null ? (sbyte)info.PlayerId : (sbyte)-1;
	}

	public sbyte GetAvailableId()
	{
		if (AllPlayers == null)
		{
			AllPlayers = new List<NetworkedPlayerInfo>();
		}
		for (sbyte i = 0; i < sbyte.MaxValue; i++)
		{
			bool used = false;
			for (int j = 0; j < AllPlayers.Count; j++)
			{
				if ((bool)AllPlayers[j] && AllPlayers[j].PlayerId == i)
				{
					used = true;
					break;
				}
			}
			if (!used)
			{
				return i;
			}
		}
		return -1;
	}

	public NetworkedPlayerInfo GetPlayerByClient(ClientData client)
	{
		if (client == null || AllPlayers == null)
		{
			return null;
		}
		for (int i = 0; i < AllPlayers.Count; i++)
		{
			if ((bool)AllPlayers[i] && AllPlayers[i].ClientId == client.Id)
			{
				return AllPlayers[i];
			}
		}
		return null;
	}

	public NetworkedPlayerInfo GetPlayerById(byte id)
	{
		if (AllPlayers == null || id == InvalidPlayerId)
		{
			return null;
		}
		for (int i = 0; i < AllPlayers.Count; i++)
		{
			if ((bool)AllPlayers[i] && AllPlayers[i].PlayerId == id)
			{
				return AllPlayers[i];
			}
		}
		return null;
	}

	public NetworkedPlayerInfo AddDummy(PlayerControl pc)
	{
		return AddPlayer(pc, null);
	}

	public NetworkedPlayerInfo AddPlayer(PlayerControl pc, ClientData client)
	{
		if (pc == null)
		{
			return null;
		}
		if (AllPlayers == null)
		{
			AllPlayers = new List<NetworkedPlayerInfo>();
		}
		NetworkedPlayerInfo existing = GetPlayerById(pc.PlayerId);
		if ((bool)existing)
		{
			existing.Init(pc, client != null ? client.Id : pc.OwnerId);
			return existing;
		}
		GameObject obj = new GameObject("PlayerInfo_" + pc.PlayerId);
		NetworkedPlayerInfo info = obj.AddComponent<NetworkedPlayerInfo>();
		info.Init(pc, client != null ? client.Id : pc.OwnerId);
		AddPlayerInfo(info);
		if (AmongUsClient.Instance != null)
		{
			AmongUsClient.Instance.Spawn(info, AmongUsClient.Instance.HostId);
		}
		return info;
	}

	public bool IsProcessingInfo(NetworkedPlayerInfo info)
	{
		return false;
	}

	public void DirtyAllData()
	{
	}

	public void AddPlayerInfo(NetworkedPlayerInfo info)
	{
		if (info == null)
		{
			return;
		}
		if (AllPlayers == null)
		{
			AllPlayers = new List<NetworkedPlayerInfo>();
		}
		if (!AllPlayers.Contains(info))
		{
			AllPlayers.Add(info);
		}
	}

	public bool RemovePlayer(byte playerId)
	{
		NetworkedPlayerInfo info = GetPlayerById(playerId);
		if (info == null || AllPlayers == null)
		{
			return false;
		}
		AllPlayers.Remove(info);
		if ((bool)info)
		{
			UnityEngine.Object.Destroy(info.gameObject);
		}
		return true;
	}

	public void RecomputeTaskCounts()
	{
	}

	public void TutOnlyRemoveTask(byte playerId, uint taskId)
	{
	}

	public uint TutOnlyAddTask(byte playerId)
	{
		return 0u;
	}

	public void CompleteTask(PlayerControl pc, uint taskId)
	{
	}

	public void RemoveDisconnectedPlayers()
	{
	}

	public void HandleDisconnect(PlayerControl player, DisconnectReasons reason)
	{
	}

	private void ShowNotification(string playerName, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}
}
