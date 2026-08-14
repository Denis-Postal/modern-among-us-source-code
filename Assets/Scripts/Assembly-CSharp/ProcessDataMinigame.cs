using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using PowerTools;
using TMPro;
using UnityEngine;

public class ProcessDataMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoDoAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProcessDataMinigame _003C_003E4__this;

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
		public _003CCoDoAnimation_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CDoText_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProcessDataMinigame _003C_003E4__this;

		private StringBuilder _003Ctxt_003E5__2;

		private int _003Clen_003E5__3;

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
		public _003CDoText_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CTransition_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProcessDataMinigame _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CTransition_003Ed__23(int _003C_003E1__state)
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

	private string[] DocTopics;

	private string[] DocTypes;

	private string[] DocExtensions;

	public float Duration;

	public ParallaxController scenery;

	public PassiveButton StartButton;

	public TextMeshPro EstimatedText;

	public TextMeshPro PercentText;

	public SpriteAnim LeftFolder;

	public SpriteAnim RightFolder;

	public AnimationClip OpenFolderClip;

	public AnimationClip CloseFolderClip;

	public GameObject Status;

	public SpriteRenderer Runner;

	public HorizontalGauge Gauge;

	private bool running;

	public FloatRange SceneRange;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void StartStopFill()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDoAnimation_003Ed__22))]
	private IEnumerator CoDoAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTransition_003Ed__23))]
	private IEnumerator Transition()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoText_003Ed__24))]
	private IEnumerator DoText()
	{
		return null;
	}
}
