using System.Collections.Generic;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatPhraseAssets : ScriptableObject
	{
		[SerializeField]
		private QuickChatPhraseAsset[] phraseAssets;

		public void GetAssetPhrases(QuickChatTag tag, QuickChatContext context, List<QuickChatPhrase> output)
		{
		}

		public QuickChatPhraseAsset GetAssetByName(string name)
		{
			return null;
		}
	}
}
