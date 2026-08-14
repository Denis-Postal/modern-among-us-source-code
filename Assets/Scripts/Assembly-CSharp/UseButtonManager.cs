using UnityEngine;

public class UseButtonManager : MonoBehaviour
{
	private static readonly Color DisabledColor = new Color(1f, 1f, 1f, 0.3f);

	private static readonly Color EnabledColor = new Color(1f, 1f, 1f, 1f);

	public SpriteRenderer UseButton;

	public Sprite UseImage;

	public Sprite SabotageImage;

	public Sprite VentImage;

	public Sprite AdminMapImage;

	public Sprite SecurityImage;

	public Sprite OptionsImage;

	private IUsable previousTarget;

	public void SetTarget(IUsable target)
	{
		NetworkedPlayerInfo localPlayerData = PlayerControl.LocalPlayer ? PlayerControl.LocalPlayer.Data : null;
		bool canUse = false;
		bool couldUse = false;
		if (target != null)
		{
			target.CanUse(localPlayerData, out canUse, out couldUse);
			if (!canUse)
			{
				target = null;
			}
		}
		if (target != null && previousTarget != null && previousTarget != target && IsBetterTarget(previousTarget, target))
		{
			return;
		}
		if (previousTarget != null && previousTarget != target)
		{
			previousTarget.SetOutline(false, false);
			previousTarget = null;
		}
		if (target != null)
		{
			SetTargetSprite(target);
			UseButton.SetCooldownNormalizedUvs();
			target.SetOutline(true, true);
			previousTarget = target;
			if (UseButton.material)
			{
				UseButton.material.SetFloat("_Percent", target.PercentCool);
			}
			UseButton.color = EnabledColor;
		}
		else if (IsImpostor(localPlayerData) && !localPlayerData.IsDead && PlayerControl.LocalPlayer && PlayerControl.LocalPlayer.CanMove)
		{
			SetSprite(SabotageImage, UseImage);
			UseButton.SetCooldownNormalizedUvs();
			UseButton.color = EnabledColor;
		}
		else
		{
			SetSprite(UseImage, null);
			UseButton.color = DisabledColor;
		}
	}

	public void DoClick()
	{
		if (!base.isActiveAndEnabled || !PlayerControl.LocalPlayer)
		{
			return;
		}
		IUsable target = FindBestUsableTarget();
		if (target != null)
		{
			target.Use();
		}
		else
		{
			SetTarget(null);
		}
	}

	internal void Refresh()
	{
		SetTarget(previousTarget);
	}

	private void SetTargetSprite(IUsable target)
	{
		ImageNames icon = target.UseIcon;
		switch (icon)
		{
		case ImageNames.VentButton:
			SetSprite(VentImage, UseImage);
			return;
		case ImageNames.AdminMapButton:
		case ImageNames.MIRAAdminButton:
		case ImageNames.PolusAdminButton:
		case ImageNames.AirshipAdminButton:
			SetSprite(AdminMapImage, UseImage);
			return;
		case ImageNames.CamsButton:
			SetSprite(SecurityImage, UseImage);
			return;
		case ImageNames.OptionsButton:
		case ImageNames.WardrobeButton:
			SetSprite(OptionsImage, UseImage);
			return;
		}
		if (target is Vent)
		{
			SetSprite(VentImage, UseImage);
		}
		else if (target is MapConsole)
		{
			SetSprite(AdminMapImage, UseImage);
		}
		else if (target is OptionsConsole)
		{
			SetSprite(OptionsImage, UseImage);
		}
		else if (target is SystemConsole)
		{
			SystemConsole systemConsole = (SystemConsole)target;
			if (systemConsole.name.StartsWith("Surv"))
			{
				SetSprite(SecurityImage, UseImage);
			}
			else if (systemConsole.name.StartsWith("TaskAdd"))
			{
				SetSprite(OptionsImage, UseImage);
			}
			else
			{
				SetSprite(UseImage, null);
			}
		}
		else
		{
			SetSprite(UseImage, null);
		}
	}

	private void SetSprite(Sprite sprite, Sprite fallback)
	{
		if (!UseButton)
		{
			return;
		}
		UseButton.sprite = sprite ? sprite : fallback;
	}

	private bool IsImpostor(NetworkedPlayerInfo playerInfo)
	{
		return playerInfo != null && playerInfo.Role != null && playerInfo.Role.TeamType == RoleTeamTypes.Impostor;
	}

	private bool IsBetterTarget(IUsable currentTarget, IUsable newTarget)
	{
		NetworkedPlayerInfo localPlayerData = PlayerControl.LocalPlayer ? PlayerControl.LocalPlayer.Data : null;
		PlayerControl localPlayer = PlayerControl.LocalPlayer;
		MonoBehaviour currentBehaviour = currentTarget as MonoBehaviour;
		MonoBehaviour newBehaviour = newTarget as MonoBehaviour;
		bool canUse;
		bool couldUse;
		if (!localPlayer || !currentBehaviour || !newBehaviour)
		{
			return false;
		}
		currentTarget.CanUse(localPlayerData, out canUse, out couldUse);
		if (!canUse)
		{
			return false;
		}
		float currentDistance = GetUsableDistance(currentBehaviour, localPlayer);
		if (currentDistance > currentTarget.UsableDistance)
		{
			return false;
		}
		int currentPriority = GetTargetPriority(currentTarget);
		int newPriority = GetTargetPriority(newTarget);
		if (currentPriority != newPriority)
		{
			return currentPriority > newPriority;
		}
		float newDistance = GetUsableDistance(newBehaviour, localPlayer);
		return currentDistance <= newDistance;
	}

	private int GetTargetPriority(IUsable target)
	{
		SystemConsole systemConsole = target as SystemConsole;
		if (systemConsole != null && systemConsole.MinigamePrefab is EmergencyMinigame)
		{
			return 100;
		}
		if (systemConsole != null && systemConsole.MinigamePrefab is TaskAdderGame)
		{
			return 10;
		}
		if (target.UseIcon == ImageNames.WardrobeButton || target.UseIcon == ImageNames.OptionsButton)
		{
			return 10;
		}
		return 50;
	}

	private IUsable FindBestUsableTarget()
	{
		NetworkedPlayerInfo localPlayerData = PlayerControl.LocalPlayer ? PlayerControl.LocalPlayer.Data : null;
		PlayerControl localPlayer = PlayerControl.LocalPlayer;
		if (!localPlayer)
		{
			return null;
		}
		MonoBehaviour[] behaviours = Object.FindObjectsOfType<MonoBehaviour>();
		IUsable bestTarget = null;
		int bestPriority = int.MinValue;
		float bestDistance = float.MaxValue;
		for (int i = 0; i < behaviours.Length; i++)
		{
			MonoBehaviour behaviour = behaviours[i];
			IUsable usable = behaviour as IUsable;
			if (usable == null)
			{
				continue;
			}
			bool canUse;
			bool couldUse;
			usable.CanUse(localPlayerData, out canUse, out couldUse);
			if (!canUse)
			{
				continue;
			}
			float distance = GetUsableDistance(behaviour, localPlayer);
			if (distance > usable.UsableDistance)
			{
				continue;
			}
			int priority = GetTargetPriority(usable);
			if (priority > bestPriority || (priority == bestPriority && distance < bestDistance))
			{
				bestTarget = usable;
				bestPriority = priority;
				bestDistance = distance;
			}
		}
		return bestTarget;
	}

	private static Vector2 GetUsablePosition(MonoBehaviour behaviour)
	{
		Collider2D collider = behaviour.GetComponent<Collider2D>();
		if (collider)
		{
			return collider.transform.TransformPoint(collider.offset);
		}
		return behaviour.transform.position;
	}

	private static float GetUsableDistance(MonoBehaviour behaviour, PlayerControl localPlayer)
	{
		return Vector2.Distance(localPlayer.GetTruePosition(), GetUsablePosition(behaviour));
	}
}
