using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ChatInputFieldButton : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro text;

	[SerializeField]
	private TextTranslatorTMP translator;

	[SerializeField]
	private PassiveButton button;

	[SerializeField]
	private BoxCollider2D collider;

	[SerializeField]
	private Transform inputGlyph;

	[SerializeField]
	private SpriteRenderer[] backgroundSprites;

	[SerializeField]
	private SpriteRenderer[] iconSprites;

	public Vector2 Size => default(Vector2);

	public event Action OnPressed
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

	public event Action OnSizeChanged
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

	private void Awake()
	{
	}

	public void SetButtonEnabled(bool enabled)
	{
	}

	private void OnButtonClicked()
	{
	}

	private void OnTextTranslationChanged()
	{
	}

	private void UpdateSize()
	{
	}
}
