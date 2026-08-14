using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BoardPassGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoFlipPass_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardPassGame _003C_003E4__this;

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
		public _003CCoFlipPass_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CCoPullPass_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardPassGame _003C_003E4__this;

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
		public _003CCoPullPass_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CCoRunBlinky_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardPassGame _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CCoRunBlinky_003Ed__29(int _003C_003E1__state)
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

	private static Color[] BgColors;

	public SpriteRenderer renderer;

	public SpriteRenderer pass;

	public Sprite passBack;

	public TextMeshPro NameText;

	public SpriteRenderer ImageBg;

	public SpriteRenderer Image;

	public Sprite[] Photos;

	public PassiveButton pullButton;

	public PassiveButton flipButton;

	public SpriteRenderer Scanner;

	public Sprite ScannerAccept;

	public Sprite ScannerScanning;

	public Sprite ScannerWaiting;

	public Collider2D Sensor;

	public Collider2D BarCode;

	public AudioClip slideinSound;

	public AudioClip flipSound;

	public AudioClip scanStartSound;

	public AudioClip scanSound;

	private Coroutine blinky;

	private Controller controller;

	private TouchpadBehavior touchpad;

	private bool prevHadInput;

	private float rotateAngle;

	private Vector2 prevStickDir;

	private bool enableControllerPassMovement;

	private bool grabbed;

	public void Start()
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CCoRunBlinky_003Ed__29))]
	private IEnumerator CoRunBlinky()
	{
		return null;
	}

	public void PullPass()
	{
	}

	[IteratorStateMachine(typeof(_003CCoPullPass_003Ed__31))]
	private IEnumerator CoPullPass()
	{
		return null;
	}

	public void Grab()
	{
	}

	public void FlipPass()
	{
	}

	[IteratorStateMachine(typeof(_003CCoFlipPass_003Ed__35))]
	private IEnumerator CoFlipPass()
	{
		return null;
	}
}
