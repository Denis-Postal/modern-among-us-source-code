using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class WaterPlantsGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoGrowPlant_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterPlantsGame _003C_003E4__this;

		public int num;

		private SpriteRenderer _003Cplant_003E5__2;

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
		public _003CCoGrowPlant_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CCoPickWaterCan_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterPlantsGame _003C_003E4__this;

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
		public _003CCoPickWaterCan_003Ed__23(int _003C_003E1__state)
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

	public GameObject stage1;

	public GameObject stage2;

	public AudioClip CanGrabSound;

	public PassiveButton WaterCan;

	public SpriteRenderer[] Plants;

	public AudioClip WaterPlantSound;

	public AudioClip[] PlantGrowSounds;

	public AudioClip[] PlantFinishedSounds;

	public TextMeshPro FloatText;

	public Transform[] Locations;

	public Transform selectorObject;

	public GameObject grabCanSubObject;

	public GameObject holdingCanSubObject;

	public GameObject waterPlantsSubObject;

	private Controller c;

	public SpriteRenderer[] playerHandObjects;

	public ParticleSystem waterParticles;

	public GameObject greenDot;

	private bool Watered(int x)
	{
		return false;
	}

	private void Watered(int x, bool b)
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}

	public void PickWaterCan()
	{
	}

	[IteratorStateMachine(typeof(_003CCoPickWaterCan_003Ed__23))]
	private IEnumerator CoPickWaterCan()
	{
		return null;
	}

	public void WaterPlant(int num)
	{
	}

	[IteratorStateMachine(typeof(_003CCoGrowPlant_003Ed__25))]
	private IEnumerator CoGrowPlant(int num)
	{
		return null;
	}
}
