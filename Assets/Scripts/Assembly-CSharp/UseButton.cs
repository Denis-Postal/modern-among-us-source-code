using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UseButton : ActionButton
{
	private static readonly Color DisabledColor = new Color(1f, 1f, 1f, 0.3f);

	private static readonly Color EnabledColor = Color.white;

	public UseButtonSettings[] UseSettings;

	private Dictionary<ImageNames, UseButtonSettings> fastUseSettings;

	private IUsable currentTarget;

	public void Awake()
	{
		fastUseSettings = new Dictionary<ImageNames, UseButtonSettings>();
		if (UseSettings != null)
		{
			for (int i = 0; i < UseSettings.Length; i++)
			{
				UseButtonSettings useButtonSettings = UseSettings[i];
				if ((bool)useButtonSettings)
				{
					fastUseSettings[useButtonSettings.ButtonType] = useButtonSettings;
				}
			}
		}
		SetTarget(null);
	}

	private void FixedUpdate()
	{
		if (!PlayerControl.LocalPlayer || !PlayerControl.LocalPlayer.CanMove)
		{
			SetTarget(null);
			return;
		}
		SetTarget(FindClosestUsable());
	}

	public void SetTarget(IUsable target)
	{
		NetworkedPlayerInfo playerInfo = PlayerControl.LocalPlayer ? PlayerControl.LocalPlayer.Data : null;
		bool canUse = false;
		bool couldUse = false;
		if (target != null)
		{
			target.CanUse(playerInfo, out canUse, out couldUse);
			if (!canUse)
			{
				target.SetOutline(false, false);
				target = null;
			}
		}
		if (currentTarget != null && currentTarget != target)
		{
			currentTarget.SetOutline(false, false);
		}
		currentTarget = target;
		if (currentTarget != null)
		{
			currentTarget.SetOutline(true, true);
			SetFromSettings(GetSettings(currentTarget.UseIcon));
			SetButtonAlpha(EnabledColor);
			SetCooldownFill(currentTarget.PercentCool);
		}
		else
		{
			SetFromSettings(GetSettings(ImageNames.UseButton));
			SetButtonAlpha(DisabledColor);
			SetCooldownFill(0f);
		}
	}

	public override void DoClick()
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (currentTarget == null)
		{
			SetTarget(FindClosestUsable());
		}
		if (currentTarget != null)
		{
			currentTarget.Use();
			SetTarget(null);
		}
	}

	public void Refresh()
	{
		SetTarget(currentTarget);
	}

	private void SetFromSettings(UseButtonSettings settings)
	{
		if (!(bool)settings)
		{
			return;
		}
		if ((bool)graphic && (bool)settings.Image)
		{
			graphic.sprite = settings.Image;
		}
		if ((bool)buttonLabelText)
		{
			buttonLabelText.text = DestroyableSingleton<TranslationController>.Instance ? DestroyableSingleton<TranslationController>.Instance.GetString(settings.Text) : settings.Text.ToString();
			if ((bool)settings.FontMaterial)
			{
				buttonLabelText.fontSharedMaterial = settings.FontMaterial;
			}
		}
	}

	private UseButtonSettings GetSettings(ImageNames imageName)
	{
		if (fastUseSettings == null)
		{
			Awake();
		}
		UseButtonSettings value;
		if (fastUseSettings != null && fastUseSettings.TryGetValue(imageName, out value))
		{
			return value;
		}
		if (fastUseSettings != null && fastUseSettings.TryGetValue(ImageNames.UseButton, out value))
		{
			return value;
		}
		return null;
	}

	private void SetButtonAlpha(Color color)
	{
		ApplyColor(graphic, color);
		ApplyColor(usesRemainingSprite, color);
		ApplyColor(usesRemainingText, color);
		ApplyColor(buttonLabelText, color);
		ApplyColor(cooldownTimerText, color);
	}

	private static void ApplyColor(SpriteRenderer renderer, Color color)
	{
		if ((bool)renderer)
		{
			Color current = renderer.color;
			current.a = color.a;
			renderer.color = current;
		}
	}

	private static void ApplyColor(TMP_Text text, Color color)
	{
		if ((bool)text)
		{
			Color current = text.color;
			current.a = color.a;
			text.color = current;
		}
	}

	private IUsable FindClosestUsable()
	{
		PlayerControl localPlayer = PlayerControl.LocalPlayer;
		if (!localPlayer)
		{
			return null;
		}
		NetworkedPlayerInfo playerInfo = localPlayer.Data;
		Vector2 truePosition = localPlayer.GetTruePosition();
		Collider2D[] colliders = Physics2D.OverlapCircleAll(truePosition, 3f);
		IUsable bestTarget = null;
		float bestDistance = float.MaxValue;
		for (int i = 0; i < colliders.Length; i++)
		{
			if (!colliders[i])
			{
				continue;
			}
			IUsable[] usables = colliders[i].GetComponents<IUsable>();
			if (usables == null || usables.Length == 0)
			{
				usables = colliders[i].GetComponentsInParent<IUsable>();
			}
			for (int j = 0; j < usables.Length; j++)
			{
				IUsable usable = usables[j];
				if (usable == null)
				{
					continue;
				}
				bool canUse;
				bool couldUse;
				usable.CanUse(playerInfo, out canUse, out couldUse);
				if (!canUse)
				{
					continue;
				}
				MonoBehaviour monoBehaviour = usable as MonoBehaviour;
				float distance = monoBehaviour ? Vector2.Distance(truePosition, monoBehaviour.transform.position) : 0f;
				if (distance <= usable.UsableDistance && distance < bestDistance)
				{
					bestDistance = distance;
					bestTarget = usable;
				}
			}
		}
		return bestTarget;
	}
}
