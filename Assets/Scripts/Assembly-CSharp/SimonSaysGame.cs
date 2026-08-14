using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SimonSaysGame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CCoAnimateNewLeftSide_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

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
		public _003CCoAnimateNewLeftSide_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CCoAnimateOldLeftSide_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

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
		public _003CCoAnimateOldLeftSide_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CCoRun_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimonSaysGame _003C_003E4__this;

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
		public _003CCoRun_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CFlashButton_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int id;

		public SimonSaysGame _003C_003E4__this;

		public SpriteRenderer butt;

		public float flashTime;

		private Color _003Cc_003E5__2;

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
		public _003CFlashButton_003Ed__35(int _003C_003E1__state)
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

	private Queue<int> operations;

	private const int FlashOp = 256;

	private const int AnimateOp = 128;

	private const int ReAnimateOp = 32;

	private const int FailOp = 64;

	private Color gray;

	private Color blue;

	private Color red;

	private Color green;

	public SpriteRenderer[] LeftSide;

	public SpriteRenderer[] Buttons;

	public SpriteRenderer[] LeftLights;

	public SpriteRenderer[] RightLights;

	private float flashTime;

	private float userButtonFlashTime;

	public AudioClip ButtonPressSound;

	public AudioClip FailSound;

	public Transform selectorHighlightObject;

	public float diagonalRoundingWidth;

	public float inputAngleIndex;

	public int roundDownIndex;

	public int roundUpIndex;

	private int[] orderedButtonIndices;

	private int IndexCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private byte this[int idx]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void HitButton(int bIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CCoRun_003Ed__31))]
	private IEnumerator CoRun()
	{
		return null;
	}

	private void AddIndex(int idxToAdd)
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimateNewLeftSide_003Ed__33))]
	private IEnumerator CoAnimateNewLeftSide()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoAnimateOldLeftSide_003Ed__34))]
	private IEnumerator CoAnimateOldLeftSide()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFlashButton_003Ed__35))]
	private IEnumerator FlashButton(int id, SpriteRenderer butt, float flashTime)
	{
		return null;
	}

	private void SetLights(SpriteRenderer[] lights, int num)
	{
	}

	private void SetAllColor(Color color)
	{
	}

	private void SetButtonColor(int i, Color color)
	{
	}
}
