using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnterCodeMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CAnimate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnterCodeMinigame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private string _003CokStr_003E5__3;

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
		public _003CAnimate_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CCoShowCard_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnterCodeMinigame _003C_003E4__this;

		private Vector3 _003Cpos_003E5__2;

		private Vector3 _003Ctarg_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CCoShowCard_003Ed__18(int _003C_003E1__state)
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

	public TextMeshPro NumberText;

	public TextMeshPro TargetText;

	public SpriteRenderer Card;

	public int number;

	public string numString;

	private bool animating;

	private bool cardOut;

	private bool done;

	private int targetNumber;

	public AudioClip WalletOut;

	public AudioClip NumberSound;

	public AudioClip AcceptSound;

	public AudioClip RejectSound;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void OnDisable()
	{
	}

	public void ShowCard()
	{
	}

	[IteratorStateMachine(typeof(_003CCoShowCard_003Ed__18))]
	private IEnumerator CoShowCard()
	{
		return null;
	}

	public void EnterDigit(int i)
	{
	}

	public void ClearDigits()
	{
	}

	public void AcceptDigits()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimate_003Ed__23))]
	private IEnumerator Animate()
	{
		return null;
	}
}
