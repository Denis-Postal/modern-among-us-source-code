using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class WeatherControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRun_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherControl _003C_003E4__this;

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
		public _003CRun_003Ed__10(int _003C_003E1__state)
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

	public Sprite backgroundLight;

	public Sprite backgroundDark;

	public Sprite lightOff;

	public Sprite lightOn;

	public SpriteRenderer Background;

	public SpriteRenderer Switch;

	public SpriteRenderer Light;

	public TextMeshPro Label;

	internal void SetInactive()
	{
	}

	public void SetActive()
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__10))]
	private IEnumerator Run()
	{
		return null;
	}
}
