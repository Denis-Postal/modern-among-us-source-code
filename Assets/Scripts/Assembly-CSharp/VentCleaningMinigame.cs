using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VentCleaningMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoOpenVent_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VentCleaningMinigame _003C_003E4__this;

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
		public _003CCoOpenVent_003Ed__24(int _003C_003E1__state)
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

	public FloatRange XSpan;

	public FloatRange YSpan;

	public ObjectPoolBehavior dirtPool;

	public GameObject ventLidClosed;

	public GameObject ventLidOpened;

	public UiElement backButton;

	public AudioClip VentOpenSound;

	public AudioClip ImpostorDiscoveredSound;

	public AudioClip CleanedSound;

	public SpriteRenderer[] SpiderWebs;

	public float cleaningDistanceThreshold;

	public Transform selectorObject;

	public SpriteRenderer selectorHand;

	private int numberOfDirts;

	private int numberOfDirtsCleanedUp;

	private bool ventOpen;

	private VentilationSystem ventSystem;

	private int VentId => 0;

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	public void OpenVent()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleJoystick()
	{
	}

	[IteratorStateMachine(typeof(_003CCoOpenVent_003Ed__24))]
	private IEnumerator CoOpenVent()
	{
		return null;
	}

	private void CleanUp(VentDirt ventDirt)
	{
	}

	private void SpawnDirt()
	{
	}
}
