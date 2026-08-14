using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BanButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoSetVotes_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int oldNum;

		public int newNum;

		public BanButton _003C_003E4__this;

		private float _003Cend_003E5__2;

		private float _003Ctimer_003E5__3;

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
		public _003CCoSetVotes_003Ed__12(int _003C_003E1__state)
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

	public TextMeshPro NameText;

	public SpriteRenderer Background;

	public int TargetClientId;

	public int numVotes;

	public BanMenu Parent { get; set; }

	public void Start()
	{
	}

	public void Select()
	{
	}

	public void Unselect()
	{
	}

	public void SetVotes(int newVotes)
	{
	}

	[IteratorStateMachine(typeof(_003CCoSetVotes_003Ed__12))]
	private IEnumerator CoSetVotes(int oldNum, int newNum)
	{
		return null;
	}
}
