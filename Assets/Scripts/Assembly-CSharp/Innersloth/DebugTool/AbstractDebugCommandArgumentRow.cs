using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public abstract class AbstractDebugCommandArgumentRow : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI typeText;

		private DebugCommandArgumentRowFieldContainer[] fieldContainers;

		public abstract DebugCommandArgumentRowFieldContainer TopField { get; }

		public abstract DebugCommandArgumentRowFieldContainer BottomField { get; }

		public event Action<DebugCommandArgumentRowFieldContainer> OnFieldContainerSelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public abstract string GetValue();

		public abstract void SetNavigation(Selectable above, Selectable below);

		public virtual void Awake()
		{
		}

		public void SetInfo(string name, string type)
		{
		}

		private void OnChildFieldContainerSelected(DebugCommandArgumentRowFieldContainer selection)
		{
		}
	}
}
