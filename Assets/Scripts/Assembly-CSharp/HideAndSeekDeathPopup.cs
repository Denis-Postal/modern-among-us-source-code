using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class HideAndSeekDeathPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HideAndSeekDeathPopup _003C_003E4__this;

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
		public _003CAnimateCoroutine_003Ed__6(int _003C_003E1__state)
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
	private HideAndSeekDeathPopupNameplate nameplate;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private AudioClip sfx;

	[SerializeField]
	private TextMeshPro text;

	public void Show(PlayerControl player, int deathIndex)
	{
	}

	private void AnimEvent_PlaySound()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateCoroutine_003Ed__6))]
	private IEnumerator AnimateCoroutine()
	{
		return null;
	}
}
