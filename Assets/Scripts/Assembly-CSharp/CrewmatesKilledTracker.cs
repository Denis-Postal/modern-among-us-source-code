using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CrewmatesKilledTracker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoRefreshDelay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrewmatesKilledTracker _003C_003E4__this;

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
		public _003CCoRefreshDelay_003Ed__9(int _003C_003E1__state)
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
	private MultiPrefabInstantiator crewmates;

	[SerializeField]
	private float crewmateSpacing;

	[SerializeField]
	private Vector3 crewmateScale;

	[SerializeField]
	private List<CrewmateTrackerAnim> slashAnimations;

	private PseudoRandomList<CrewmateTrackerAnim> animList;

	private List<CrewmateTrackerEntry> crewmateSprites;

	private void Awake()
	{
	}

	public void OnCrewmateKilled()
	{
	}

	public void OnCrewmateDisconnect()
	{
	}

	[IteratorStateMachine(typeof(_003CCoRefreshDelay_003Ed__9))]
	private IEnumerator CoRefreshDelay()
	{
		return null;
	}

	private void Start()
	{
	}
}
