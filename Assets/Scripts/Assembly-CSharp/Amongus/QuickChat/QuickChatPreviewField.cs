using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatPreviewField : AbstractChatInputField
	{
		[Space(10f)]
		[SerializeField]
		private ChatInputFieldButton clearButton;

		[SerializeField]
		private ChatInputFieldButton undoButton;

		[SerializeField]
		private TextMeshPro warningText;

		[SerializeField]
		private TextMeshPro text;

		[SerializeField]
		private TextMeshPro placeholderText;

		public event Action OnClearPressedEvent
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

		public event Action OnUndoPressedEvent
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

		public override void Clear()
		{
		}

		public void UpdatePreview(QuickChatPhraseBuilder builder)
		{
		}

		public void AnimateInvalidSend()
		{
		}

		protected override void OnTextFieldTransformChanged(Vector3 position, Vector2 size)
		{
		}

		private void OnClearButtonPressed()
		{
		}

		private void OnClearButtonSizeChanged()
		{
		}

		private void UpdateClearButtonTransform()
		{
		}

		private void OnUndoButtonPressed()
		{
		}

		private void OnUndoButtonSizeChanged()
		{
		}

		private void UpdateUndoButtonTransform()
		{
		}

		private string GetQuickChatChatWarningStr()
		{
			return null;
		}
	}
}
