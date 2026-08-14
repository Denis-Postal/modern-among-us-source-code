using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AmongUs.QuickChat
{
	public class QuickChatPhraseBuilder
	{
		public delegate void ChangeHandler(QuickChatPhraseBuilder builder);

		private QuickChatPhrase rootPhrase;

		private List<QuickChatPhrase> subPhrases;

		public bool IsEmpty => false;

		public event ChangeHandler OnChangedEvent
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

		public void Reset()
		{
		}

		public void Start(QuickChatPhrase rootPhrase)
		{
		}

		public bool CanAddAsNextPhrase(QuickChatPhrase phrase)
		{
			return false;
		}

		public void AddNextPhrase(QuickChatPhrase phrase)
		{
		}

		public void Undo()
		{
		}

		public QuickChatTag[] GetNextExpectedInput()
		{
			return null;
		}

		private void NotifyChange()
		{
		}

		public bool IsComplete()
		{
			return false;
		}

		private bool CheckSimplePhraseComplete()
		{
			return false;
		}

		private bool CheckComplexPhraseComplete()
		{
			return false;
		}

		public QuickChatPhraseBuilderResult Build()
		{
			return null;
		}

		public void ToLogString(StringBuilder output)
		{
		}

		public QuickChatPhrase[] ToPreviewData()
		{
			return null;
		}
	}
}
