using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugCommandOverlayPage : DebugToolOverlayPage
	{
		[Header("List")]
		[SerializeField]
		private DebugCommandButton commandButtonPrefab;

		[SerializeField]
		private Transform commandButtonParent;

		[SerializeField]
		private ScrollRect commandScrollList;

		[SerializeField]
		[Header("Details")]
		private GameObject detailsParent;

		[SerializeField]
		private TextMeshProUGUI basePath;

		[SerializeField]
		private TextMeshProUGUI commandName;

		[SerializeField]
		private TextMeshProUGUI commandDescription;

		[SerializeField]
		private Transform argumentsParent;

		[SerializeField]
		private Button executeButton;

		[Header("Argument Field Types")]
		[SerializeField]
		private DebugCommandArgumentRow_TextField argumentTextFieldPrefab;

		[SerializeField]
		private DebugCommandArgumentRow_Dropdown argumentDropdownPrefab;

		[Header("Debug")]
		[SerializeField]
		private GameObject debugContainer;

		[SerializeField]
		private Image debugIcon;

		[SerializeField]
		private TextMeshProUGUI debugText;

		[Space(10f)]
		[SerializeField]
		private Color debugInfoColor;

		[SerializeField]
		private Color debugSuccessColor;

		[SerializeField]
		private Color debugWarningColor;

		[SerializeField]
		private Color debugErrorColor;

		[Space(10f)]
		[SerializeField]
		private Sprite debugInfoIcon;

		[SerializeField]
		private Sprite debugSuccessIcon;

		[SerializeField]
		private Sprite debugWarningIcon;

		[SerializeField]
		private Sprite debugErrorIcon;

		private List<DebugCommandButton> allCommandButtons;

		private Dictionary<string, List<DebugCommandButton>> directoryContents;

		private Dictionary<string, DebugCommand> commands;

		private int selectedCommandIndex;

		private List<AbstractDebugCommandArgumentRow> commandInputs;

		private DebugCommandArgumentRowFieldContainer selectedFieldContainer;

		public override string Name => null;

		public override bool ConsumingNavActions => false;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void UpdateSelectedCommandIfScrolling(IDebugToolInputProvider inputProvider)
		{
		}

		public override void Show()
		{
		}

		public override void OnBackButtonPressed()
		{
		}

		private DebugCommandButton CreateDirectory(string directoryName, string parentDirectoryPath, string directoryPath, int index)
		{
			return null;
		}

		private void OnButtonClick(DebugCommandButton btn)
		{
		}

		private void OnCommandClicked(DebugCommandButton btn)
		{
		}

		private void OnFieldRowContainerSelected(DebugCommandArgumentRowFieldContainer container)
		{
		}

		private AbstractDebugCommandArgumentRow InstantiateInputFieldRow(DebugCommand command, int argIndex, ParameterInfo paramInfo)
		{
			return null;
		}

		private void OnDirectoryClicked(DebugCommandButton btn)
		{
		}

		private void ExecuteCommandWithParameters(DebugCommand command)
		{
		}

		private void ResetAndHideDetails()
		{
		}

		private void HighlightButton(int highlightedIndex)
		{
		}

		private void ClearCommandLog()
		{
		}

		private void SetCommandLog(string message, DebugCommandMessageType type)
		{
		}
	}
}
