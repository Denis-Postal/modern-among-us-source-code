using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class RewiredCategoryEnabler : MonoBehaviour
{
	[Serializable]
	public class RewiredCategoryState
	{
		public string name;

		public bool enabled;
	}

	[CompilerGenerated]
	private sealed class _003CCoApplyDefaultMapState_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RewiredCategoryEnabler _003C_003E4__this;

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
		public _003CCoApplyDefaultMapState_003Ed__5(int _003C_003E1__state)
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

	public bool applyDefaultMapState;

	public RewiredCategoryState[] defaultStates;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ReInput_ControllerConnectedEvent(ControllerStatusChangedEventArgs obj)
	{
	}

	[IteratorStateMachine(typeof(_003CCoApplyDefaultMapState_003Ed__5))]
	private IEnumerator CoApplyDefaultMapState()
	{
		return null;
	}

	public void ApplyDefaultMapState()
	{
	}
}
