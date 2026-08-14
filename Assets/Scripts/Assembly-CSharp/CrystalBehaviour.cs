using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CrystalBehaviour : UiElement
{
	[CompilerGenerated]
	private sealed class _003CFlash_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CrystalBehaviour c;

		private Color _003Ccol_003E5__2;

		private float _003Ctime_003E5__3;

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
		public _003CFlash_003Ed__12(int _003C_003E1__state)
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

	public Transform TargetPosition;

	public SpriteRenderer Renderer;

	public BoxCollider2D Collider;

	public bool CanMove;

	public FloatRange Padding;

	private const float Speed = 15f;

	public float XFloatMag;

	private const float FloatMag = 0.05f;

	private const float FloatSpeed = 0.35f;

	public float PieceIndex;

	private void Update()
	{
	}

	public void Flash(float delay = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003CFlash_003Ed__12))]
	private static IEnumerator Flash(CrystalBehaviour c, float delay)
	{
		return null;
	}
}
