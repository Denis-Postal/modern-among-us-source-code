using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BreakableRock : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFallRockAnim_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BreakableRock _003C_003E4__this;

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
		public _003CFallRockAnim_003Ed__19(int _003C_003E1__state)
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

	private const float FALL_DURATION = 0.3f;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Sprite[] rockSprites;

	[SerializeField]
	private PassiveButton passiveButton;

	[SerializeField]
	private AnimationCurve animCurve;

	[SerializeField]
	private CollectableOre myOre;

	[SerializeField]
	private Collider2D col;

	private Action<CollectableOre, Vector3> powerMeterAction;

	private Controller controller;

	public bool CanInteract { get; private set; }

	private void Update()
	{
	}

	public void Initialize(Action<CollectableOre, Vector3> powerAction, Controller control)
	{
	}

	private void TouchRock()
	{
	}

	public CollectableOre GetOre()
	{
		return null;
	}

	public void SendPower()
	{
	}

	public void SetInput(bool isEnabled)
	{
	}

	[IteratorStateMachine(typeof(_003CFallRockAnim_003Ed__19))]
	private IEnumerator FallRockAnim()
	{
		return null;
	}

	private bool IsUsingController()
	{
		return false;
	}
}
