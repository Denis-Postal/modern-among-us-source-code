using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class AbstractChatInputField : MonoBehaviour
{
	protected const float BUTTON_MARGIN = 0.1f;

	private const float TEXT_FIELD_MARGIN = 0.12f;

	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	private ChatInputFieldButton submitButton;

	private bool visible;

	private bool canSubmit;

	public SpriteRenderer Background => null;

	public bool Visible => false;

	public bool CanSubmit => false;

	public event Action OnSubmitEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	private void OnSubmitButtonPressed()
	{
	}

	private void OnSubmitButtonSizeChanged()
	{
	}

	private void UpdateElements()
	{
	}

	protected virtual void OnTextFieldTransformChanged(Vector3 position, Vector2 size)
	{
	}

	protected Bounds GetBounds()
	{
		return default(Bounds);
	}

	public virtual void SetVisible(bool visible)
	{
	}

	public void SetCanSubmit(bool canSubmit)
	{
	}

	protected virtual void SetButtonsEnabled(bool enabled)
	{
	}

	public virtual void Clear()
	{
	}

	protected virtual void Submit()
	{
	}
}
