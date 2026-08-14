using System;
using UnityEngine;

namespace AmongUs.QuickChat
{
	[Serializable]
	public class QuickChatPhaseRules : AbstractQuickChatPhraseRuleGroup
	{
		[SerializeField]
		private bool inLobby;

		[SerializeField]
		private bool inGame;

		public QuickChatPhaseRules(bool inLobby, bool inGame)
		{
		}

		public override bool Evaluate(QuickChatContext context)
		{
			return false;
		}
	}
}
