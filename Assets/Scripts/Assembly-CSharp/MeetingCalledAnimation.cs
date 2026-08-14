using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MeetingCalledAnimation : OverlayAnimation
{
	[CompilerGenerated]
	private sealed class _003CCoShow_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingCalledAnimation _003C_003E4__this;

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
		public _003CCoShow_003Ed__6(int _003C_003E1__state)
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

	public AspectPosition emergencyText;

	public PoolablePlayer playerParts;

	public AudioClip Stinger;

	public float StingerVolume;

	public AnimationCurve CrewmateSlide;

	public void Initialize(NetworkedPlayerInfo.PlayerOutfit outfit)
	{
	}

	[IteratorStateMachine(typeof(_003CCoShow_003Ed__6))]
	public override IEnumerator CoShow(KillOverlay parent)
	{
		return null;
	}
}
