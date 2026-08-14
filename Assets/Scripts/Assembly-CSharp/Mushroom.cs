using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoReleaseSpores_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Mushroom _003C_003E4__this;

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
		public _003CCoReleaseSpores_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CWaitForSpores_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Mushroom _003C_003E4__this;

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
		public _003CWaitForSpores_003Ed__35(int _003C_003E1__state)
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

	private const float TRIGGER_WAIT_TIME = 0.5f;

	private const string SFX_ACTIVATE_NAME = "SporeActivate";

	private const string SFX_SPAWN_NAME = "MushroomSpawn";

	private const float VIBRATION_INTENSITY = 0.5f;

	private const float VIBRATION_FALLOFF_DISTANCE = 3.5f;

	private const float VIBRATION_DURATION = 0.25f;

	private static readonly Collider2D[] Hits;

	[SerializeField]
	private Collider2D mushroomCollider;

	[SerializeField]
	private SpriteRenderer mushroom;

	[SerializeField]
	private SpriteRenderer spores;

	[SerializeField]
	private GameObject sporeMask;

	[SerializeField]
	[Tooltip("Use Fix Mushroom IDs to auto-set this value for all mushrooms on the map.")]
	[Header("Metadata")]
	private int id;

	[SerializeField]
	[Header("Mushroom Animations")]
	private SpriteAnim mushroomAnimator;

	[SerializeField]
	private AnimationClip mushroomIdle;

	[SerializeField]
	private AnimationClip mushroomAppear;

	[SerializeField]
	private AnimationClip mushroomSteppedOn;

	[SerializeField]
	[Header("Spore Cloud Animations")]
	private SpriteAnim sporeCloudAnimator;

	[SerializeField]
	private SpriteAnim sporeCloudMaskAnimator;

	[SerializeField]
	private AnimationClip sporeCloudIdle;

	[SerializeField]
	private AnimationClip sporeCloudAppear;

	[SerializeField]
	private AnimationClip sporeCloudDisappear;

	[Header("Timings")]
	[SerializeField]
	private float secondsBetweenSporeReleases;

	[SerializeField]
	private float secondsSporeIsActive;

	[SerializeField]
	private float secondsSporeReappearsFor;

	[SerializeField]
	private float secondsSporeFade;

	[Header("Audio")]
	[SerializeField]
	private AudioClip spawnSound;

	[SerializeField]
	private AudioClip activateSporeSound;

	private ContactFilter2D filter;

	private Vector3 origPosition;

	public int Id => 0;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void StartSporeTrigger(PlayerControl player)
	{
	}

	public void TriggerSpores()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForSpores_003Ed__35))]
	private IEnumerator WaitForSpores()
	{
		return null;
	}

	private void ResetState()
	{
	}

	[IteratorStateMachine(typeof(_003CCoReleaseSpores_003Ed__37))]
	private IEnumerator CoReleaseSpores()
	{
		return null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}
}
