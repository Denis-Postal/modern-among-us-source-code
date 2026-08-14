using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugCommandArgumentRow_TextField : AbstractDebugCommandArgumentRow
	{
		[SerializeField]
		[Header("Text Input")]
		private DebugCommandArgumentRowFieldContainer fieldContainer;

		[SerializeField]
		private TMP_InputField inputField;

		[SerializeField]
		private TextMeshProUGUI placeholderText;

		public override DebugCommandArgumentRowFieldContainer TopField => null;

		public override DebugCommandArgumentRowFieldContainer BottomField => null;

		public override string GetValue()
		{
			return null;
		}

		public override void SetNavigation(Selectable above, Selectable below)
		{
		}

		public void SetPlaceholder(string placeholder)
		{
		}
	}
}
