using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class DeleteAccountRequest : MonoBehaviour, ITranslatedText
{
	[CompilerGenerated]
	private sealed class _003CAddDeleteRequest_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DeleteAccountRequest _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CAddDeleteRequest_003Ed__11(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRemoveDeleteRequest_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DeleteAccountRequest _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CRemoveDeleteRequest_003Ed__12(int _003C_003E1__state)
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

	public TextMeshPro buttonText;

	public DeleteAccountPopupBox popupConfirmation;

	public InfoTextBox popupConfirmationUndelete;

	public InfoTextBox somethingWentWrong;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowConfirmationScreen()
	{
	}

	public void ResetText()
	{
	}

	private void SomethingWentWrong(string error)
	{
	}

	private void DeleteAccount()
	{
	}

	private void UnDeleteAccount()
	{
	}

	[IteratorStateMachine(typeof(_003CAddDeleteRequest_003Ed__11))]
	private IEnumerator AddDeleteRequest()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRemoveDeleteRequest_003Ed__12))]
	private IEnumerator RemoveDeleteRequest()
	{
		return null;
	}

	private void UpdateText()
	{
	}
}
