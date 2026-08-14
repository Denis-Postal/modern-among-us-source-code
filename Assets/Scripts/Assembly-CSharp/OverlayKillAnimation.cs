using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class OverlayKillAnimation : OverlayAnimation
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public KillOverlay parent;

		internal void _003CCoShow_003Eb__0(float t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoShow_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillOverlay parent;

		public OverlayKillAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

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
		public _003CCoShow_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CWaitForFinish_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverlayKillAnimation _003C_003E4__this;

		private SpriteAnim[] _003Canims_003E5__2;

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
		public _003CWaitForFinish_003Ed__19(int _003C_003E1__state)
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
	private KillAnimType KillType;

	[SerializeField]
	protected PoolablePlayer killerParts;

	[SerializeField]
	private Vector3 KillerPetPosition;

	[SerializeField]
	protected PoolablePlayer victimParts;

	[SerializeField]
	private Vector3 VictimPetPosition;

	[SerializeField]
	private AudioClip Stinger;

	[SerializeField]
	private AudioClip Sfx;

	[SerializeField]
	private float StingerVolume;

	protected KillOverlayInitData initData;

	[SerializeField]
	private bool leftFacingVictim;

	private string victimHat;

	private HashSet<GameObject> petObjects;

	public bool LeftFacingVictim => false;

	public virtual void Initialize(KillOverlayInitData initData)
	{
	}

	public void SetHatFloor()
	{
	}

	public void SetVisorFloor()
	{
	}

	public void PlayKillSound()
	{
	}

	[IteratorStateMachine(typeof(_003CCoShow_003Ed__18))]
	public override IEnumerator CoShow(KillOverlay parent)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForFinish_003Ed__19))]
	private IEnumerator WaitForFinish()
	{
		return null;
	}

	private void LoadVictimSkin(NetworkedPlayerInfo.PlayerOutfit outfit)
	{
	}

	private void LoadKillerSkin(NetworkedPlayerInfo.PlayerOutfit outfit)
	{
	}

	private void LoadKillerPet(NetworkedPlayerInfo.PlayerOutfit outfit)
	{
	}

	private void LoadVictimPet(NetworkedPlayerInfo.PlayerOutfit outfit)
	{
	}

	private void OnDestroy()
	{
	}
}
