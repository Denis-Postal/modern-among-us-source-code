using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class SampleMinigame : Minigame
{
	public enum States : byte
	{
		PrepareSample = 0,
		Complete = 0x10,
		AwaitingStart = 0x20,
		Selection = 0x40,
		Processing = 0x80
	}

	[CompilerGenerated]
	private sealed class _003CBringPanelDown_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		private WaitForFixedUpdate _003Cwait_003E5__2;

		private Vector3 _003Cpos_003E5__3;

		private float _003Ci_003E5__4;

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
		public _003CBringPanelDown_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CBringPanelUp_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		public bool isBeginning;

		private WaitForFixedUpdate _003Cwait_003E5__2;

		private Vector3 _003Cpos_003E5__3;

		private float _003Ci_003E5__4;

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
		public _003CBringPanelUp_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CCoSelectTube_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int selectedTube;

		public int correctTube;

		public SampleMinigame _003C_003E4__this;

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
		public _003CCoSelectTube_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CCoStartProcessing_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

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
		public _003CCoStartProcessing_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CDropLiquid_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		private WaitForSeconds _003CdropWait_003E5__2;

		private WaitForFixedUpdate _003Cwait_003E5__3;

		private Vector3 _003Cpos_003E5__4;

		private Vector2 _003CvPositionDelta_003E5__5;

		private Vector2 _003CvPosition_003E5__6;

		private int _003Cstep_003E5__7;

		private float _003Cstart_003E5__8;

		private float _003CxTarg_003E5__9;

		private float _003Ci_003E5__10;

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
		public _003CDropLiquid_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CDropTube_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SampleMinigame _003C_003E4__this;

		public int id;

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
		public _003CDropTube_003Ed__37(int _003C_003E1__state)
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

	private static StringNames[] ProcessingStrings;

	private const float PanelMoveDuration = 0.75f;

	private const byte TubeMask = 15;

	public TextMeshPro UpperText;

	public TextMeshPro LowerText;

	public float TimePerStep;

	public FloatRange platformY;

	public FloatRange dropperX;

	public SpriteRenderer CenterPanel;

	public SpriteRenderer Dropper;

	public SpriteRenderer[] Tubes;

	public SpriteRenderer[] Buttons;

	public SpriteRenderer[] LowerButtons;

	public AudioClip ButtonSound;

	public AudioClip PanelMoveSound;

	public AudioClip FailSound;

	public AudioClip[] DropSounds;

	private RandomFill<AudioClip> dropSounds;

	public Transform whichButtonSelector;

	public int whichButtonSelected;

	[SerializeField]
	private GameObject phase1_controllerGlyph;

	private float selectMoveCooldown;

	private States State
	{
		get
		{
			return default(States);
		}
		set
		{
		}
	}

	private int AnomalyId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void SetPlatformBottom()
	{
	}

	private void SetPlatformTop()
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CBringPanelUp_003Ed__35))]
	public IEnumerator BringPanelUp(bool isBeginning)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBringPanelDown_003Ed__36))]
	public IEnumerator BringPanelDown()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDropTube_003Ed__37))]
	private IEnumerator DropTube(int id)
	{
		return null;
	}

	public void SelectTube(int tubeId)
	{
	}

	[IteratorStateMachine(typeof(_003CCoSelectTube_003Ed__39))]
	private IEnumerator CoSelectTube(int correctTube, int selectedTube)
	{
		return null;
	}

	public void NextStep()
	{
	}

	[IteratorStateMachine(typeof(_003CCoStartProcessing_003Ed__41))]
	private IEnumerator CoStartProcessing()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDropLiquid_003Ed__42))]
	private IEnumerator DropLiquid()
	{
		return null;
	}
}
