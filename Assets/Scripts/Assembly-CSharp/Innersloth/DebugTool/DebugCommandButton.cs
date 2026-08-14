using System;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugCommandButton : MonoBehaviour
	{
		private const int INDENT_SIZE = 50;

		[SerializeField]
		private TextMeshProUGUI buttonLabel;

		[SerializeField]
		private HorizontalLayoutGroup layoutGroup;

		[SerializeField]
		private Button button;

		[SerializeField]
		private Image background;

		[SerializeField]
		private Image expandCollapseImage;

		[SerializeField]
		private Sprite expandedIcon;

		[SerializeField]
		private Sprite collapsedIcon;

		[SerializeField]
		private Color evenColor;

		[SerializeField]
		private Color oddColor;

		[SerializeField]
		private Color highlightColor;

		private int index;

		private int initialLeftPadding;

		public bool IsDirectory { get; private set; }

		public string Path { get; private set; }

		public bool Expanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void Initialize(string label, string path, ParameterInfo[] parameters, Action action, int index)
		{
		}

		public void ToggleDirectory(bool directory)
		{
		}

		public void SetIndentLevel(int indentLevel)
		{
		}

		public void ToggleHighlight(bool highlighted)
		{
		}
	}
}
