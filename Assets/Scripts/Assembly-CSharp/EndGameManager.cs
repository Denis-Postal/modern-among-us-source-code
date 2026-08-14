using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoBegin_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndGameManager _003C_003E4__this;

		private Color _003Cc_003E5__2;

		private Color _003Cfade_003E5__3;

		private Vector3 _003CtitlePos_003E5__4;

		private float _003Ctimer_003E5__5;

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
		public _003CCoBegin_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CWaitWithTimeout_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> success;

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
		public _003CWaitWithTimeout_003Ed__19(int _003C_003E1__state)
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

	public TextMeshPro WinText;

	public MeshRenderer BackgroundBar;

	public MeshRenderer Foreground;

	public FloatRange ForegroundRadius;

	public SpriteRenderer FrontMost;

	public PoolablePlayer PlayerPrefab;

	public Sprite GhostSprite;

	public AudioClip DisconnectStinger;

	public AudioClip CrewStinger;

	public AudioClip ImpostorStinger;

	public EndGameNavigation Navigation;

	private const float ScaleAll = 0.9f;

	private const float OffsetWidth = 1f;

	private float stingerTime;

	public void Start()
	{
	}

	private void ShowButtons()
	{
	}

	private void SetEverythingUp()
	{
	}

	private void GetStingerVol(AudioSource source, float dt)
	{
	}

	[IteratorStateMachine(typeof(_003CCoBegin_003Ed__18))]
	private IEnumerator CoBegin()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitWithTimeout_003Ed__19))]
	public static IEnumerator WaitWithTimeout(Func<bool> success)
	{
		return null;
	}
}
