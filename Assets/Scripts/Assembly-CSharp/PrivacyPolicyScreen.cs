using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class PrivacyPolicyScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShow_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PrivacyPolicyScreen _003C_003E4__this;

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
		public _003CShow_003Ed__12(int _003C_003E1__state)
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

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement ManageDataButton;

	public UiElement AcceptButton;

	public OpenHyperlinks DefaultHyperlinkText;

	public OpenHyperlinks PlayStationHyperlinkText;

	public TextMeshPro PlayStationEULAText;

	private List<ITextPart> textConstituents;

	private List<SelectableHyperLink> selectableHyperLinks;

	public OpenHyperlinks HyperLinkText => null;

	public void Start()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CShow_003Ed__12))]
	public IEnumerator Show()
	{
		return null;
	}

	private void DestroyGOs(ControllerUiElementsState menu)
	{
	}

	private void DecomposePrivacyPolicyText(string text)
	{
	}

	private void OnNewSelection()
	{
	}

	public void RecomposePrivacyPolicyText()
	{
	}

	public void OnTextUpdated()
	{
	}

	public void Close()
	{
	}
}
