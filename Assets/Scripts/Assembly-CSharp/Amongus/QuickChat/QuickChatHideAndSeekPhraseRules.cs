using System;
using UnityEngine;

namespace AmongUs.QuickChat
{
	[Serializable]
	public class QuickChatHideAndSeekPhraseRules : AbstractQuickChatPhraseRuleGroup
	{
		[SerializeField]
		private QuickChatPhaseRules phases;

		[SerializeField]
		private QuickChatMapRules maps;

		public QuickChatHideAndSeekPhraseRules(QuickChatPhaseRules phase, QuickChatMapRules map)
		{
		}

		public override bool Evaluate(QuickChatContext context)
		{
			return false;
		}
	}
}
