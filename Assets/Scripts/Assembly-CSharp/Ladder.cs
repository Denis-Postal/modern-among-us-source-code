using UnityEngine;

public class Ladder : MonoBehaviour, IUsableCoolDown, IUsable
{
	public byte Id;

	public SpriteRenderer SpotArea;

	public bool IsTop;

	public Ladder Destination;

	public AudioClip UseSound;

	public SpriteRenderer Image;

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public ImageNames UseIcon => default(ImageNames);

	public float CoolDown { get; set; }

	public float MaxCoolDown => 0f;

	public bool IsCoolingDown()
	{
		return false;
	}

	private void Update()
	{
	}

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

	public void SetDestinationCooldown()
	{
	}
}
