using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugCommandArgumentRow_Dropdown : AbstractDebugCommandArgumentRow
	{
		[SerializeField]
		[Header("Dropdown Input")]
		private DebugCommandArgumentRowFieldContainer dropdownFieldContainer;

		[SerializeField]
		private TMP_Dropdown dropdown;

		[SerializeField]
		[Header("Filter Input")]
		private DebugCommandArgumentRowFieldContainer filterFieldContainer;

		[SerializeField]
		private TMP_InputField filterField;

		private List<string> initialDropdownOptions;

		public override DebugCommandArgumentRowFieldContainer TopField => null;

		public override DebugCommandArgumentRowFieldContainer BottomField => null;

		public override string GetValue()
		{
			return null;
		}

		public override void Awake()
		{
		}

		public override void SetNavigation(Selectable above, Selectable below)
		{
		}

		public void SetDropdownOptions(IEnumerable<string> options)
		{
		}

		public void OnFilterChanged(string filter)
		{
		}

		private void ResetFilter()
		{
		}
	}
}
