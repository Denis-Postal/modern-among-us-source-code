using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameCore;
using UnityEngine;

public class SignInUserOnButtonPress : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CContinueToNextScene_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SignInUserOnButtonPress _003C_003E4__this;

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
		public _003CContinueToNextScene_003Ed__9(int _003C_003E1__state)
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

	public Action OnButtonPress;

	public SceneChanger SceneChanger;

	public TextTranslatorTMP Text;

	private bool inviteReceived;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void AddUserWithUI()
	{
	}

	private void AddUserCompleted(UserManager.UserOpResult result)
	{
	}

	[IteratorStateMachine(typeof(_003CContinueToNextScene_003Ed__9))]
	private IEnumerator ContinueToNextScene()
	{
		return null;
	}

	public void HandleInvite(string connectionString)
	{
	}
}
