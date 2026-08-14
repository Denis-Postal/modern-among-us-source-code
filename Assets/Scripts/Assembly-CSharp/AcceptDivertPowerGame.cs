using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AcceptDivertPowerGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoDoSwitch_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AcceptDivertPowerGame _003C_003E4__this;

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
		public _003CCoDoSwitch_003Ed__9(int _003C_003E1__state)
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

	private LineRenderer[] LeftWires;

	private LineRenderer[] RightWires;

	public GameObject RightWireParent;

	public GameObject LeftWireParent;

	public SpriteRenderer Switch;

	public AudioClip SwitchSound;

	private bool done;

	private bool prevHadInput;

	private float rotateAngle;

	private Vector2 prevStickDir;

	public void Start()
	{
	}

	public void DoSwitch()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDoSwitch_003Ed__9))]
	private IEnumerator CoDoSwitch()
	{
		return null;
	}

	public void Update()
	{
	}
}
