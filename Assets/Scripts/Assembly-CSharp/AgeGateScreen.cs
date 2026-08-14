using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class AgeGateScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShow_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AgeGateScreen _003C_003E4__this;

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
		public _003CShow_003Ed__22(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject EnterDateScreen;

	[SerializeField]
	private GameObject MoreInfoScreen;

	[SerializeField]
	private GameObject VerifyScreen;

	[SerializeField]
	private Color DefaultColor;

	[SerializeField]
	private Color FilledColor;

	[SerializeField]
	private TextMeshPro privacyInfoText;

	[SerializeField]
	private TextMeshPro monthText;

	[SerializeField]
	private TextMeshPro dayText;

	[SerializeField]
	private TextMeshPro yearText;

	[SerializeField]
	private TextMeshPro fullDateText;

	private List<SelectableHyperLink> selectableHyperLinks;

	private string defaultMonthText;

	private string defaultDayText;

	private string defaultYearText;

	public int Day;

	public int Month;

	public int Year;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultSelection;

	public List<UiElement> selectableObjects;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CShow_003Ed__22))]
	public IEnumerator Show()
	{
		return null;
	}

	public bool IsDefaultDayText(string text)
	{
		return false;
	}

	private void Update()
	{
	}

	public void Close()
	{
	}

	public void GoToVerify()
	{
	}

	public void GoBackToEdit()
	{
	}

	public void ToggleMoreInfo()
	{
	}

	public bool ShakeIfInvalid()
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
