using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public abstract class ExileController : MonoBehaviour
{
	public class InitProperties
	{
		public NetworkedPlayerInfo.PlayerOutfit outfit;

		public NetworkedPlayerInfo networkedPlayer;

		public bool voteTie;

		public bool isImpostor;

		public bool confirmImpostor;

		public int totalImpostorCount;

		public int remainingImpostorCount;
	}

	[CompilerGenerated]
	private sealed class _003CHandleText_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float firstWaitTime;

		public float animDuration;

		public ExileController _003C_003E4__this;

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
		public _003CHandleText_003Ed__19(int _003C_003E1__state)
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

	public static ExileController Instance;

	public TextMeshPro ImpostorText;

	public TextMeshPro Text;

	public PoolablePlayer Player;

	public AnimationCurve LerpCurve;

	public float Duration;

	public AudioClip TextSound;

	public AudioClip EjectSound;

	[SerializeField]
	private bool useIdleAnim;

	[SerializeField]
	private Vector3 exileHatPosition;

	[SerializeField]
	private Vector3 exileVisorPosition;

	protected string completeString;

	protected InitProperties initData;

	private SpecialInputHandler specialInputHandler;

	public event Action OnCompleteEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	protected abstract IEnumerator Animate();

	[IteratorStateMachine(typeof(_003CHandleText_003Ed__19))]
	protected virtual IEnumerator HandleText(float firstWaitTime, float animDuration)
	{
		return null;
	}

	public void BeginForTesting(NetworkedPlayerInfo.PlayerOutfit outfit, bool voteTie = false, bool isImpostor = true, bool confirmImpostor = true, int totalImpostorCount = 1, int remainingImpostorCount = 0)
	{
	}

	public void BeginForGameplay(NetworkedPlayerInfo player, bool voteTie)
	{
	}

	private void Begin(InitProperties init)
	{
	}

	protected void WrapUp()
	{
	}

	protected void ReEnableGameplay()
	{
	}
}
