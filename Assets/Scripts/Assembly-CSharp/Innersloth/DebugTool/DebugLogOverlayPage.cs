using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PolyAndCode.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugLogOverlayPage : DebugToolOverlayPage, IRecyclableScrollRectDataSource
	{
		[CompilerGenerated]
		private sealed class _003CCoScrollToBottom_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DebugLogOverlayPage _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoScrollToBottom_003Ed__31(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly Dictionary<LogType, DebugLogFilterButton> logButtons;

		[SerializeField]
		private RecyclableScrollRect logScrollList;

		[SerializeField]
		private RectTransform idealLogPosition;

		[SerializeField]
		private DebugLogOverlayPageListSelector listSelector;

		[Header("Bottom Section")]
		[SerializeField]
		private Button clearButton;

		[SerializeField]
		private Button copyButton;

		[SerializeField]
		private DebugLogFilterButton logsButton;

		[SerializeField]
		private DebugLogFilterButton warningsButton;

		[SerializeField]
		private DebugLogFilterButton errorsButton;

		[Header("Log Details")]
		[SerializeField]
		private GameObject detailParent;

		[SerializeField]
		private TextMeshProUGUI detailsText;

		[SerializeField]
		private GameObject notListeningWarning;

		private string detailsToCopy;

		private readonly List<DebugLogMessage> logMessageList;

		private bool initialized;

		private int selectedLogIndex;

		public override string Name => null;

		public override bool ConsumingNavActions => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateScrollRectPosition(int originalSelectedIndex, int newlySelectedIndex)
		{
		}

		private void OnListSelected()
		{
		}

		private void OnListDeselected()
		{
		}

		public override void Show()
		{
		}

		public override void OnBackButtonPressed()
		{
		}

		public int GetItemCount()
		{
			return 0;
		}

		public void SetCell(ICell cell, int index)
		{
		}

		private void HideDetails()
		{
		}

		[IteratorStateMachine(typeof(_003CCoScrollToBottom_003Ed__31))]
		private IEnumerator CoScrollToBottom()
		{
			return null;
		}

		private void RefreshLogList()
		{
		}

		private void SetFilterButtonCounts(Dictionary<LogType, int> logTypeCounts)
		{
		}

		private void Filter(LogType logType)
		{
		}

		private void CopyLogOrLogs()
		{
		}

		private void ClearLogs()
		{
		}

		private void ShowLogDetails(DebugLogMessage debugLogMsg)
		{
		}

		private void UnhighlightLog()
		{
		}

		private void HighlightLog(int i)
		{
		}

		private void FadeOtherLogs(int index)
		{
		}

		private DebugLogMessageLine FindLogObject(int index)
		{
			return null;
		}

		private void UnfadeLogs()
		{
		}
	}
}
