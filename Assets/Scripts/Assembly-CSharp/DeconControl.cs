using UnityEngine;
using UnityEngine.UI;

public class DeconControl : MonoBehaviour, IUsable
{
	public DeconSystem System;

	public float usableDistance;

	public SpriteRenderer Image;

	public AudioClip UseSound;

	public Button.ButtonClickedEvent OnUse;

	private const float CooldownDuration = 6f;

	private float cooldown;

	public ImageNames UseIcon => default(ImageNames);

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public void Update()
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
