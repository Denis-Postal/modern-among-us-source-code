using UnityEngine;

public class OptionsConsole : MonoBehaviour, IUsable
{
	private const float DefaultUsableDistance = 1f;

	public Vector3 CustomPosition;

	public bool HostOnly;

	public GameObject MenuPrefab;

	public SpriteRenderer Outline;

	public ImageNames CustomUseIcon;

	public ImageNames UseIcon => CustomUseIcon != 0 ? CustomUseIcon : ImageNames.OptionsButton;

	public float UsableDistance => DefaultUsableDistance;

	public float PercentCool => 0f;

	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse)
	{
		float distance = float.MaxValue;
		PlayerControl playerControl = pc != null ? pc.Object : PlayerControl.LocalPlayer;
		bool isDead = pc != null && pc.IsDead;
		couldUse = playerControl != null && playerControl.CanMove && !isDead;
		if (HostOnly)
		{
			couldUse &= AmongUsClient.Instance == null || AmongUsClient.Instance.AmHost;
		}
		canUse = couldUse;
		if (canUse)
		{
			distance = Vector2.Distance(playerControl.GetTruePosition(), GetUsablePosition());
			canUse &= distance <= UsableDistance;
		}
		return distance;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
		if ((bool)Outline && (bool)Outline.material)
		{
			Outline.material.SetFloat("_Outline", on ? 1 : 0);
			Outline.material.SetColor("_OutlineColor", Color.white);
			Outline.material.SetColor("_AddColor", mainTarget ? Color.white : Color.clear);
		}
	}

	public void Use()
	{
		if (!PlayerControl.LocalPlayer)
		{
			return;
		}
		bool canUse;
		bool couldUse;
		CanUse(PlayerControl.LocalPlayer.Data, out canUse, out couldUse);
		if (!canUse)
		{
			return;
		}
		if (!MenuPrefab)
		{
			Debug.LogWarning("OptionsConsole has no MenuPrefab: " + base.name);
			return;
		}
		if ((bool)PlayerControl.LocalPlayer.NetTransform)
		{
			PlayerControl.LocalPlayer.NetTransform.Halt();
		}
		PlayerControl.LocalPlayer.moveable = false;
		GameObject gameObject = Object.Instantiate(MenuPrefab);
		if ((bool)Camera.main)
		{
			gameObject.transform.SetParent(Camera.main.transform, worldPositionStays: false);
		}
		gameObject.transform.localPosition = CustomPosition != Vector3.zero ? CustomPosition : new Vector3(0f, 0f, -20f);
	}

	private Vector2 GetUsablePosition()
	{
		Collider2D collider = GetComponent<Collider2D>();
		if ((bool)collider)
		{
			return collider.transform.TransformPoint(collider.offset);
		}
		return base.transform.position;
	}
}
