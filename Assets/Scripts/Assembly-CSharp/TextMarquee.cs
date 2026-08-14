using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TextMarquee : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Vector4 temp;

		public Action<MeshRenderer> _003C_003E9__1;

		internal void _003CRun_003Eb__0(MeshRenderer render)
		{
		}

		internal void _003CRun_003Eb__1(MeshRenderer render)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRun_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextMarquee _003C_003E4__this;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

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
		public _003CRun_003Ed__11(int _003C_003E1__state)
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

	public TextMeshPro Target;

	private MeshRenderer[] allRenderers;

	private int lastChildCount;

	private string targetText;

	public float ScrollSpeed;

	public float PauseTime;

	public float AreaWidth;

	public bool IgnoreTextChanges;

	public void Start()
	{
	}

	private void UpdateRendererList()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CRun_003Ed__11))]
	private IEnumerator Run()
	{
		return null;
	}
}
