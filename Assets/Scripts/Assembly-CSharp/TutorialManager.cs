using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialManager : DestroyableSingleton<TutorialManager>
{
	[CompilerGenerated]
	private sealed class _003CRunTutorial_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialManager _003C_003E4__this;

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
		public _003CRunTutorial_003Ed__8(int _003C_003E1__state)
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

	public PlayerControl PlayerPrefab;

	[SerializeField]
	private GameObject skeldDetectiveLocationsPrefab;

	[SerializeField]
	private GameObject miraDetectiveLocationsPrefab;

	[SerializeField]
	private GameObject polusDetectiveLocationsPrefab;

	[SerializeField]
	private GameObject airshipDetectiveLocationsPrefab;

	[SerializeField]
	private GameObject fungleDetectiveLocationsPrefab;

	public override void Awake()
	{
	}

	public override void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CRunTutorial_003Ed__8))]
	private IEnumerator RunTutorial()
	{
		return null;
	}
}
