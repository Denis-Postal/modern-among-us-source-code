using System;
using AmongUs.GameOptions;
using UnityEngine;

public abstract class OptionBehaviour : MonoBehaviour
{
	public SpriteRenderer LabelBackground;

	public StringNames Title;

	public Action<OptionBehaviour> OnValueChanged;

	public RoleTypes AssociatedRole;

	protected BaseGameSetting data;

	private PassiveButton[] buttons;

	public BaseGameSetting Data => data;

	public virtual float GetFloat()
	{
		return 0f;
	}

	public virtual int GetInt()
	{
		return 0;
	}

	public virtual bool GetBool()
	{
		return false;
	}

	public void SetAsPlayer()
	{
	}

	public void SetClickMask(Collider2D clickMask)
	{
		if (buttons == null)
		{
			buttons = GetComponentsInChildren<PassiveButton>(true);
		}
		for (int i = 0; buttons != null && i < buttons.Length; i++)
		{
			buttons[i].ClickMask = clickMask;
		}
	}

	public virtual void SetUpFromData(BaseGameSetting data, int maskLayer)
	{
		this.data = data;
		if (data != null)
		{
			Title = data.Title;
		}
	}

	public virtual void Initialize()
	{
	}

	public string GetValueString(float value)
	{
		return data != null ? data.GetValueString(value) : value.ToString();
	}

	protected void SyncTextRenderers()
	{
	}
}
