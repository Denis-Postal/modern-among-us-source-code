using UnityEngine;

public class PlatformConsole : MonoBehaviour, IUsable
{
	public float usableDistance;

	public SpriteRenderer Image;

	public MovingPlatformBehaviour Platform;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public ImageNames UseIcon => default(ImageNames);

	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public void Use()
	{
	}
}
