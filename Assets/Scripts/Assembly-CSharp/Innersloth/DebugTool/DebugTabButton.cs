using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugTabButton : MonoBehaviour
	{
		private static readonly Color COLOR_NORMAL;

		private static readonly Color COLOR_SELECTED;

		[SerializeField]
		private string pageName;

		[SerializeField]
		private TextMeshProUGUI buttonLabel;

		[SerializeField]
		private Button button;

		public string PageName => null;

		private void Awake()
		{
		}

		public void ToggleSelect(bool selected)
		{
		}
	}
}
