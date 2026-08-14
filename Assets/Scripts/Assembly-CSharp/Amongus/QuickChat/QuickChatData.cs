using System.Collections.Generic;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatData : ScriptableObject
	{
		[SerializeField]
		private QuickChatTagAssets tags;

		[SerializeField]
		private QuickChatPhraseAssets phrases;

		private Dictionary<QuickChatTag, IQuickChatPhraseCollector> phraseCollectors;

		public QuickChatTagAssets Tags => null;

		public QuickChatPhraseAssets Phrases => null;

		public QuickChatTag[] GetVisibleTags()
		{
			return null;
		}

		public QuickChatPhrase[] GetPhrases(QuickChatContext context, params QuickChatTag[] tags)
		{
			return null;
		}

		private void RegisterCollectorMethods()
		{
		}

		private void CollectPhrasesFromTag(QuickChatTag tag, QuickChatContext context, List<QuickChatPhrase> output)
		{
		}
	}
}
