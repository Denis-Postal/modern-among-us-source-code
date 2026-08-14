using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Hazel;
using UnityEngine;

public class PhantomRole : ImpostorRole
{
	[CompilerGenerated]
	private sealed class _003CCoAppearClients_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

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
		public _003CCoAppearClients_003Ed__23(int _003C_003E1__state)
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
	private AudioClip appearSound;

	private const string SFX_VANISH_NAME = "PhantomVanish";

	private const string SFX_APPEAR_NAME = "PhantomAppear";

	private float cooldownSecondsRemaining;

	private float durationSecondsRemaining;

	private bool isInvisible;

	private bool fading;

	private bool serverApproved;

	public bool IsInvisible => false;

	private bool IsCoolingDown => false;

	private static float RoleCooldownValue => 0f;

	public bool IsFading => false;

	public bool ServerApproved => false;

	public bool SetFading(bool isFading)
	{
		return false;
	}

	public bool SetServerApproval(bool approved)
	{
		return false;
	}

	public override void UseAbility()
	{
	}

	public void SetInvisible(bool invisibility)
	{
	}

	public void AppearClients(Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CCoAppearClients_003Ed__23))]
	private IEnumerator CoAppearClients(Action callback)
	{
		return null;
	}

	private void MakePlayerVisible(bool shouldAnimate = true, bool setCooldown = true)
	{
	}

	protected override bool IsValidTarget(NetworkedPlayerInfo target)
	{
		return false;
	}

	private bool ShouldUpdateCancelTimer()
	{
		return false;
	}

	public override void OnVotingComplete()
	{
	}

	public override void SetCooldown()
	{
	}

	public void StartDuration()
	{
	}

	private void FixedUpdate()
	{
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}

	public override bool CanUse(IUsable usable)
	{
		return false;
	}

	public void PlayPhantomVanishSound()
	{
	}

	public void PlayPhantomAppearSound()
	{
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	public override void HandleRoleRpc(byte callId, MessageReader reader)
	{
	}
}
