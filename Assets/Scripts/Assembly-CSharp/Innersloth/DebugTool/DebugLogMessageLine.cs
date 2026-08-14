using System;
using PolyAndCode.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugLogMessageLine : MonoBehaviour, ICell
	{
		[SerializeField]
		private Button expandButton;

		[SerializeField]
		private Image fader;

		[SerializeField]
		private TextMeshProUGUI logLine;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Image warningLogIcon;

		[SerializeField]
		private Image regularLogIcon;

		[SerializeField]
		private Image errorLogIcon;

		[SerializeField]
		private Color fadeColor;

		[SerializeField]
		private Color evenColor;

		[SerializeField]
		private Color oddColor;

		[SerializeField]
		private Color highlightColor;

		public int Index { get; private set; }

		public void Initialize(DebugLogMessage debugLog, Action<int, DebugLogMessage> onClick, int index)
		{
		}

		public void ToggleFade(bool faded)
		{
		}

		public void ToggleHighlight(bool highlighted)
		{
		}
	}
}
