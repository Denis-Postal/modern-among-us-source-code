using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectableShell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoCollectShellAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectableShell _003C_003E4__this;

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
		public _003CCoCollectShellAnimation_003Ed__13(int _003C_003E1__state)
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
	private SpriteRenderer shellSprite;

	[SerializeField]
	private PassiveButton[] sands;

	[SerializeField]
	private AudioClip[] shellSounds;

	private Action onSandCleared;

	private SpriteRenderer[] sandSprites;

	private bool isCollected;

	public IReadOnlyList<PassiveButton> SandButtons => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public SpriteRenderer GetSandSprite(int index)
	{
		return null;
	}

	public void SetOnSandClearedAction(Action pOnSandCleared)
	{
	}

	public void CheckIfAllSandCleared()
	{
	}

	[IteratorStateMachine(typeof(_003CCoCollectShellAnimation_003Ed__13))]
	private IEnumerator CoCollectShellAnimation()
	{
		return null;
	}
}
