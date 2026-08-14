using System;
using UnityEngine;

public class FreeplayPopoverButton : MonoBehaviour
{
	[SerializeField]
	private MapNames map;

	[SerializeField]
	private BoxCollider2D collider;

	[SerializeField]
	private PassiveButton button;

	public MapNames Map => map;

	public UiElement Button => button;

	public Vector2 Size
	{
		get
		{
			if (collider != null)
			{
				return collider.size;
			}
			return Vector2.zero;
		}
	}

	public event Action<FreeplayPopoverButton> OnPressEvent;

	public bool ContainsPoint(Vector2 point)
	{
		EnsureButtonHook();
		return collider != null && collider.isActiveAndEnabled && collider.OverlapPoint(point);
	}

	private void Awake()
	{
		EnsureButtonHook();
	}

	private void OnEnable()
	{
		EnsureButtonHook();
	}

	private void EnsureButtonHook()
	{
		if (button == null)
		{
			button = GetComponent<PassiveButton>();
		}
		if (collider == null)
		{
			collider = GetComponent<BoxCollider2D>();
		}
		if (button != null)
		{
			if (collider != null)
			{
				button.Colliders = new Collider2D[1] { collider };
			}
			button.OnClick.RemoveListener(OnPressed);
			button.OnClick.AddListener(OnPressed);
			if (DestroyableSingleton<PassiveButtonManager>.InstanceExists)
			{
				DestroyableSingleton<PassiveButtonManager>.Instance.RegisterOne(button);
			}
		}
	}

	private void OnMouseUpAsButton()
	{
		if (isActiveAndEnabled)
		{
			OnPressed();
		}
	}

	private void OnPressed()
	{
		Action<FreeplayPopoverButton> pressEvent = OnPressEvent;
		if (pressEvent != null)
		{
			pressEvent(this);
			return;
		}
		FreeplayPopover popover = GetComponentInParent<FreeplayPopover>(true);
		if (popover != null)
		{
			popover.PlayMap(map);
		}
	}
}
