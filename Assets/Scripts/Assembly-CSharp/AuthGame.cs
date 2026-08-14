using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class AuthGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CAnimate_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AuthGame _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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
		public _003CAnimate_003Ed__25(int _003C_003E1__state)
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

	public TextMeshPro TargetText;

	public TextMeshPro NumberText;

	public TextMeshPro OtherStatusText;

	public int number;

	public string numString;

	private bool animating;

	private HqHudSystemType system;

	public SpriteRenderer OurLight;

	public SpriteRenderer TheirLight;

	public SpriteRenderer TimeBar;

	public AudioClip ButtonSound;

	public AudioClip AcceptSound;

	public AudioClip RejectSound;

	private int OtherConsoleId;

	private bool evenColor;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	public void Update()
	{
	}

	public void ClickNumber(int i)
	{
	}

	public void ClearEntry()
	{
	}

	public void Enter()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimate_003Ed__25))]
	private IEnumerator Animate()
	{
		return null;
	}
}
