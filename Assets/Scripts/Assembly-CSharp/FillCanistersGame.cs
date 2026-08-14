using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class FillCanistersGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CRun_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FillCanistersGame _003C_003E4__this;

		private AudioSource _003CfillSound_003E5__2;

		private Player _003Cplayer_003E5__3;

		private float _003CstickInput_003E5__4;

		private bool _003ChasNoRemoveInput_003E5__5;

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
		public _003CRun_003Ed__17(int _003C_003E1__state)
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

	private Vector3 CanisterAppearPosition;

	private Vector3 CanisterStartPosition;

	private Vector3 CanisterDragPosition;

	private Vector3 CanisterSnapPosition;

	private Vector3 CanisterAwayPosition;

	public float FillTime;

	public CanisterBehaviour Canister;

	private Controller controller;

	public AudioClip FillLoop;

	public AudioClip DropSound;

	public AudioClip GrabSound;

	public AudioClip PlugInSound;

	public AudioClip PlugOutSound;

	private TouchpadBehavior touchpad;

	private bool prevHadInput;

	public void Start()
	{
	}

	public override void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__17))]
	private IEnumerator Run()
	{
		return null;
	}
}
