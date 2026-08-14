using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class Vent : MonoBehaviour, IUsable
{
	[CompilerGenerated]
	private sealed class _003CExitVent_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl pc;

		public Vent _003C_003E4__this;

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
		public _003CExitVent_003Ed__40(int _003C_003E1__state)
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

	private const float VIBRATION_INTENSITY = 0.4f;

	private const float VIBRATION_FALLOFF_DISTANCE = 3.5f;

	private const float VIBRATION_DURATION = 0.2f;

	public static Vent currentVent;

	public int Id;

	public Vent Left;

	public Vent Right;

	public Vent Center;

	public ButtonBehavior[] Buttons;

	public GameObject[] CleaningIndicators;

	public AnimationClip EnterVentAnim;

	public AnimationClip ExitVentAnim;

	public Vector3 Offset;

	public float spreadAmount;

	public float spreadShift;

	[SerializeField]
	private SpriteRenderer myRend;

	[SerializeField]
	private SpriteAnim myAnim;

	[SerializeField]
	private int numFramesUntilPlayerDisappearsOnEnter;

	[SerializeField]
	private int numFramesUntilPlayerReappearsOnExit;

	[SerializeField]
	private GameObject additionalExitAnimation;

	public ImageNames UseIcon => default(ImageNames);

	public float UsableDistance => 0f;

	public float PercentCool => 0f;

	public int NumFramesUntilPlayerDisappears => 0;

	private Vent[] NearbyVents => null;

	private void Start()
	{
	}

	public void SetButtons(bool enabled)
	{
	}

	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse)
	{
		canUse = default(bool);
		couldUse = default(bool);
		return 0f;
	}

	public void SetOutline(bool on, bool mainTarget)
	{
	}

	public void ClickRight()
	{
	}

	public void ClickLeft()
	{
	}

	public void ClickCenter()
	{
	}

	public void Use()
	{
	}

	public void UpdateArrows(VentilationSystem ventSystem)
	{
	}

	internal void EnterVent(PlayerControl pc)
	{
	}

	[IteratorStateMachine(typeof(_003CExitVent_003Ed__40))]
	internal IEnumerator ExitVent(PlayerControl pc)
	{
		return null;
	}

	private bool TryMoveToVent(Vent otherVent, out string error)
	{
		error = null;
		return false;
	}

	private void ToggleNeighborVentBeingCleaned(bool ventBeingCleaned, ButtonBehavior b, GameObject c)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
