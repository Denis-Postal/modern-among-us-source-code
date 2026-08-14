using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SecurityLogger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBlinkSensor_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SecurityLogger _003C_003E4__this;

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
		public _003CBlinkSensor_003Ed__10(int _003C_003E1__state)
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

	private static Collider2D[] hits;

	public SecurityLogBehaviour LogParent;

	public SecurityLogBehaviour.SecurityLogLocations MyLocation;

	public float Cooldown;

	public SpriteRenderer Image;

	public BoxCollider2D Sensor;

	private float[] Timers;

	private ContactFilter2D filter;

	private void Awake()
	{
	}

	public void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CBlinkSensor_003Ed__10))]
	private IEnumerator BlinkSensor()
	{
		return null;
	}
}
