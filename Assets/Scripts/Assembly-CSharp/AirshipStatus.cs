using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AirshipStatus : ShipStatus
{
	[CompilerGenerated]
	private sealed class _003CPrespawnStep_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AirshipStatus _003C_003E4__this;

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
		public _003CPrespawnStep_003Ed__10(int _003C_003E1__state)
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

	public SpawnInMinigame SpawnInGame;

	public MovingPlatformBehaviour GapPlatform;

	public ParticleSystem ShowerParticles;

	public LightAffector[] LightAffectors;

	public GameObject outOfOrderPlat;

	protected override void OnEnable()
	{
	}

	public override void RepairCriticalSabotages()
	{
	}

	public override float CalculateLightRadius(NetworkedPlayerInfo player)
	{
		return 0f;
	}

	public override void OnMeetingCalled()
	{
	}

	public override void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
	}

	[IteratorStateMachine(typeof(_003CPrespawnStep_003Ed__10))]
	public override IEnumerator PrespawnStep()
	{
		return null;
	}
}
