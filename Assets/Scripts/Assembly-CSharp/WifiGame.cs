using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class WifiGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoBlinkLight_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer light;

		public WifiGame _003C_003E4__this;

		public float delay;

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
		public _003CCoBlinkLight_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CRunLights_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool finishing;

		public WifiGame _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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
		public _003CRunLights_003Ed__15(int _003C_003E1__state)
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

	private const int WaitDuration = 60;

	public SlideBar Slider;

	public TextMeshPro StatusText;

	public SpriteRenderer[] Lights;

	public Sprite LightOn;

	public Sprite LightOff;

	public AudioClip SliderClick;

	private bool WifiOff;

	private TouchpadBehavior touchpad;

	private float initialSlider;

	private Controller controller;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	private void TurnOn(bool first = false)
	{
	}

	private void TurnOff(bool first = false)
	{
	}

	[IteratorStateMachine(typeof(_003CRunLights_003Ed__15))]
	private IEnumerator RunLights(bool finishing)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoBlinkLight_003Ed__16))]
	private IEnumerator CoBlinkLight(SpriteRenderer light, float delay)
	{
		return null;
	}
}
