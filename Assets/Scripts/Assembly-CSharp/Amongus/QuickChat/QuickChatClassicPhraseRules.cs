using System;
using UnityEngine;

namespace AmongUs.QuickChat
{
	[Serializable]
	public class QuickChatClassicPhraseRules : AbstractQuickChatPhraseRuleGroup
	{
		[SerializeField]
		private int minDeadCrew;

		[SerializeField]
		private int minMeetingCount;

		[SerializeField]
		private QuickChatPhaseRules phases;

		[SerializeField]
		private QuickChatMapRules maps;

		[SerializeField]
		private QuickChatRoleRules roles;

		public QuickChatClassicPhraseRules(QuickChatPhaseRules phase, QuickChatMapRules map, QuickChatRoleRules roles, int deadCrewCount, int meetingCount)
		{
		}

		public override bool Evaluate(QuickChatContext context)
		{
			return false;
		}
	}
}
