using System;
using UnityEngine;

namespace AmongUs.QuickChat
{
	[Serializable]
	public class QuickChatMapRules : AbstractQuickChatPhraseRuleGroup
	{
		[SerializeField]
		private MapNames[] maps;

		public QuickChatMapRules(params MapNames[] maps)
		{
		}

		public override bool Evaluate(QuickChatContext context)
		{
			return false;
		}
	}
}
