using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public abstract class PlayerTask : MonoBehaviour
{
	public SystemTypes StartAt;

	public TaskTypes TaskType;

	public Minigame MinigamePrefab;

	public bool HasLocation;

	public bool LocationDirty;

	public int Index { get; internal set; }

	public uint Id { get; internal set; }

	public PlayerControl Owner { get; internal set; }

	public abstract int TaskStep { get; }

	public abstract bool IsComplete { get; }

	public List<Vector2> Locations => null;

	public abstract void Initialize();

	public virtual void OnRemove()
	{
	}

	public abstract bool ValidConsole(Console console);

	public abstract void Complete();

	public abstract void AppendTaskText(StringBuilder sb);

	internal static bool TaskIsEmergency(PlayerTask arg)
	{
		return false;
	}

	protected List<Console> FindConsoles()
	{
		return null;
	}

	public static T GetOrCreateTask<T>(PlayerControl localPlayer, int insertAt = 0) where T : PlayerTask
	{
		return null;
	}

	public static bool DestroyTasksOfType<T>(PlayerControl localPlayer)
	{
		return false;
	}

	public static bool TryGetTaskOfType<T>(PlayerControl localPlayer, out T t)
	{
		t = default(T);
		return false;
	}

	public static bool PlayerHasTaskOfType<T>(PlayerControl localPlayer)
	{
		return false;
	}

	public List<Vector2> FindValidConsolesPositions()
	{
		return null;
	}

	protected Console FindSpecialConsole(Func<Console, bool> func)
	{
		return null;
	}

	protected Console FindObjectPos()
	{
		return null;
	}

	protected List<Vector2> FindConsolesPos()
	{
		return null;
	}

	public virtual Minigame GetMinigamePrefab()
	{
		return null;
	}

	protected static bool AllTasksCompleted(PlayerControl player)
	{
		return false;
	}
}
