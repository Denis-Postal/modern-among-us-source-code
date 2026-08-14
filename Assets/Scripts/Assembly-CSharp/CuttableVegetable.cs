using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CuttableVegetable : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoCutNextPiece_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CuttableVegetable _003C_003E4__this;

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
		public _003CCoCutNextPiece_003Ed__11(int _003C_003E1__state)
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
	private SpriteRenderer[] uncutPieces;

	[SerializeField]
	private SpriteRenderer[] partiallyCutPieces;

	[SerializeField]
	private Sprite[] cutSprites;

	private int cutPieces;

	public int NextPieceIndex => 0;

	public SpriteRenderer NextPiece => null;

	public bool IsFullyCut => false;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CCoCutNextPiece_003Ed__11))]
	public IEnumerator CoCutNextPiece()
	{
		return null;
	}

	private bool CheckComplete(int cutPieces)
	{
		return false;
	}
}
