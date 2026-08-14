using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EmergencyMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoAnimateOpen_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EmergencyMinigame _003C_003E4__this;

		private Vector3 _003CmeetingPos_003E5__2;

		private float _003Ctimer_003E5__3;

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
		public _003CCoAnimateOpen_003Ed__16(int _003C_003E1__state)
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

	public SpriteRenderer ClosedLid;

	public SpriteRenderer OpenLid;

	public Transform meetingButton;

	public TextMeshPro StatusText;

	public TextMeshPro NumberText;

	public bool ButtonActive;

	public AudioClip ButtonSound;

	private int state;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public const int MinEmergencyTime = 15;

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	public void CallMeeting()
	{
	}

	private float easeOutElastic(float t)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CCoAnimateOpen_003Ed__16))]
	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}
}
