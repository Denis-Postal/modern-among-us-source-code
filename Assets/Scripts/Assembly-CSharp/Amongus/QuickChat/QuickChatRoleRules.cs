using System;
using AmongUs.GameOptions;
using UnityEngine;

namespace AmongUs.QuickChat
{
	[Serializable]
	public class QuickChatRoleRules : AbstractQuickChatPhraseRuleGroup
	{
		[SerializeField]
		private RoleTypes[] requiredRoles;

		public QuickChatRoleRules(params RoleTypes[] roles)
		{
		}

		public override bool Evaluate(QuickChatContext context)
		{
			return false;
		}
	}
}
