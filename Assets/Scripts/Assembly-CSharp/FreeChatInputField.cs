using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FreeChatInputField : AbstractChatInputField
{
	[Space(10f)]
	[SerializeField]
	private TextBoxTMP textArea;

	[SerializeField]
	private PassiveButton fieldButton;

	[SerializeField]
	private TextMeshPro charCountText;

	public string Text => null;

	public event Action OnChangedEvent
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

	protected override void Awake()
	{
	}

	public override void SetVisible(bool visible)
	{
	}

	public override void Clear()
	{
	}

	private void OnFieldChanged()
	{
	}

	protected override void OnTextFieldTransformChanged(Vector3 position, Vector2 size)
	{
	}

	protected override void Submit()
	{
	}

	public void Focus()
	{
	}

	public void Unfocus()
	{
	}

	public void ForceKeyboardClose()
	{
	}

	private void OnFieldPressed()
	{
	}

	private void OnFieldSubmit()
	{
	}

	public void UpdateCharCount()
	{
	}

	private void UpdateState()
	{
	}
}
