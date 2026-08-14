using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TagAmbientSoundPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRun_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TagAmbientSoundPlayer _003C_003E4__this;

		private ContactFilter2D _003Cfilter_003E5__2;

		private Collider2D[] _003Cbuffer_003E5__3;

		private WaitForSeconds _003Cwait_003E5__4;

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
		public _003CRun_003Ed__7(int _003C_003E1__state)
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

	public AudioClip AmbientSound;

	public float MaxVolume;

	public string TargetTag;

	private float targetVolume;

	public void Start()
	{
	}

	private void Dynamics(AudioSource source, float dt)
	{
	}

	public void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__7))]
	private IEnumerator Run()
	{
		return null;
	}
}
