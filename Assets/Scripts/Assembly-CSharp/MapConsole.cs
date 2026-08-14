using UnityEngine;

public class MapConsole : MonoBehaviour, IUsable
{
	public ImageNames useIcon;

	public float usableDistance;

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

	public void Use()
	{
	}
}
