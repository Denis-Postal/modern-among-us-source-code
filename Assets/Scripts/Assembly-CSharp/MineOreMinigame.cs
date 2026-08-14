using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class MineOreMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoWaitBreakAnimations_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MineOreMinigame _003C_003E4__this;

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
		public _003CCoWaitBreakAnimations_003Ed__35(int _003C_003E1__state)
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

	private const string BAR_FILL_SFX = "mineOrePowerBarLoop";

	private const int ORE_NUMBER = 3;

	private const int MAX_GOOD_ROCKS = 2;

	private const int MAX_PERFECT_ROCKS = 4;

	[SerializeField]
	[Tooltip("Speed of power meter when breaking rocks")]
	private float powerBarSpeed;

	[SerializeField]
	[Tooltip("angle of pickaxe while animating breaking a rock")]
	private float pikeaxeFirstAngle;

	[SerializeField]
	[Tooltip("angle of pickaxe while animating breaking a rock")]
	private float pikeaxeSecondAngle;

	[Tooltip("time of pickeaxe animation in seconds")]
	[SerializeField]
	private float pikeaxeAnimTime;

	[Tooltip("Good Zone percentage max value")]
	[SerializeField]
	private float goodPercentage;

	[Tooltip("Great Zone percentage max value")]
	[SerializeField]
	private float greatPercentage;

	[SerializeField]
	private Collider2D pickaxe;

	[SerializeField]
	private GameObject pickaxeSprite;

	[SerializeField]
	private GameObject pickControllerHelper;

	[SerializeField]
	private PowerBarMining powerBarMining;

	[SerializeField]
	private List<CollectableOre> ores;

	[Header("Audio Files")]
	[SerializeField]
	private AudioClip[] rockHitWeak;

	[SerializeField]
	private AudioClip[] rockHitStrong;

	[SerializeField]
	private AudioClip[] rockRelease;

	[SerializeField]
	private AudioClip pickaxeSwing;

	[SerializeField]
	private AudioClip powerBarLoop;

	private AudioSource powerBarAudioSource;

	private int currentOreCount;

	private CollectableOre currentOre;

	private Controller controller;

	private bool isMining;

	private Player gamepad;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	private void OnInputChanged()
	{
	}

	private void SpawnRocksAndOres()
	{
	}

	private void OreCollected()
	{
	}

	private void CallPowerMeter(CollectableOre ore, Vector3 clickPos)
	{
	}

	private void UpdateAudioPitch(float power)
	{
	}

	private void HitRock(float power, Vector3 clickPos)
	{
	}

	[IteratorStateMachine(typeof(_003CCoWaitBreakAnimations_003Ed__35))]
	private IEnumerator CoWaitBreakAnimations()
	{
		return null;
	}

	private List<BreakableRock> GetRocks(Vector3 startPoint, int numRocks)
	{
		return null;
	}

	private BreakableRock GetClosestRock(Vector3 startPoint, List<BreakableRock> potentialRocks)
	{
		return null;
	}

	private bool IsUsingController()
	{
		return false;
	}

	private void SetRockOreInput(bool isEnabled)
	{
	}

	private void RockReleaseAudio()
	{
	}
}
