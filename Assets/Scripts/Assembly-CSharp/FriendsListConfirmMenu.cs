using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FriendsListConfirmMenu : MonoBehaviour
{
	private enum ConfirmationStatus
	{
		Waiting = 0,
		Yes = 1,
		No = 2
	}

	public enum ActionType
	{
		Friend = 0,
		Block = 1,
		Lobby = 2,
		Unfriend = 3,
		Unblock = 4
	}

	[CompilerGenerated]
	private sealed class _003CWaitForConfirm_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActionType type;

		public FriendsListConfirmMenu _003C_003E4__this;

		public string recipientFriendCode;

		public Action cb;

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
		public _003CWaitForConfirm_003Ed__7(int _003C_003E1__state)
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

	public TextMeshPro PopUpText;

	private ConfirmationStatus confirmStatus;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	[IteratorStateMachine(typeof(_003CWaitForConfirm_003Ed__7))]
	public IEnumerator WaitForConfirm(Action cb, ActionType type, string recipientFriendCode)
	{
		return null;
	}

	public void Confirm()
	{
	}

	public void Cancel()
	{
	}

	public virtual void OnDisable()
	{
	}
}
