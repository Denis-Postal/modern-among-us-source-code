using UnityEngine;

public class ZiplineConsole : MonoBehaviour, IUsableCoolDown, IUsable
{
	[SerializeField]
	private float usableDistance;

	[SerializeField]
	private SpriteRenderer image;

	[SerializeField]
	private ZiplineBehaviour zipline;

	[SerializeField]
	private bool atTop;

	[SerializeField]
	private ZiplineConsole destination;

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

	public void SetDestinationCooldown()
	{
	}
}
