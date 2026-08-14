using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MushroomMixupScreenTint : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoAnimateOpacity_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float startValue;

		public float finalValue;

		public MushroomMixupScreenTint _003C_003E4__this;

		private float _003CcurrentValue_003E5__2;

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
		public _003CCoAnimateOpacity_003Ed__6(int _003C_003E1__state)
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

	private static readonly int Opacity;

	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private float maxOpacity;

	private void Awake()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimateOpacity_003Ed__6))]
	private IEnumerator CoAnimateOpacity(float startValue, float finalValue)
	{
		return null;
	}
}
