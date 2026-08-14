using UnityEngine;

public class SystemConsole : MonoBehaviour, IUsable
{
	public ImageNames useIcon;

	public Vector2 SafePositionLocal;

	public float usableDistance;

	public bool FreeplayOnly;

	public bool onlyFromBelow;

	public SpriteRenderer Image;

	public Minigame MinigamePrefab;

	public ImageNames UseIcon => default(ImageNames);

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void Start()
	{
	}

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void Use()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
