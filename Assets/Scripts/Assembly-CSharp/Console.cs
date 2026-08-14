using UnityEngine;

public class Console : MonoBehaviour, IUsable
{
	public float usableDistance;

	public int ConsoleId;

	public bool onlyFromBelow;

	public bool onlySameRoom;

	public bool checkWalls;

	public bool GhostsIgnored;

	public bool AllowImpostor;

	public SystemTypes Room;

	public TaskTypes[] TaskTypes;

	public TaskSet[] ValidTasks;

	public SpriteRenderer Image;

	public ImageNames UseIcon => default(ImageNames);

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	private bool InRoom(Vector2 truePos)
	{
		return false;
	}

	private PlayerTask FindTask(PlayerControl pc)
	{
		return null;
	}

	public virtual void Use()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
