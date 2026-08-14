using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugCommandArgumentRowFieldContainer : Selectable
	{
		[SerializeField]
		[Header("Selectable Field")]
		private Selectable field;

		private bool isFieldSelected;

		public Selectable Selectable => null;

		public bool IsSelected => false;

		public bool IsFieldSelected => false;

		public event Action<DebugCommandArgumentRowFieldContainer> OnSelected
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

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public void Deselect()
		{
		}

		public void SetNavigationAbove(Selectable selectable)
		{
		}

		public void SetNavigationBelow(Selectable selectable)
		{
		}

		public void Confirm()
		{
		}

		public void Cancel()
		{
		}
	}
}
