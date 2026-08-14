using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RoomTracker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoSlideIn_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomTracker _003C_003E4__this;

		public SystemTypes newRoom;

		private Vector3 _003CtempPos_003E5__2;

		private Color _003CtempColor_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CCoSlideIn_003Ed__13(int _003C_003E1__state)
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
	private sealed class _003CSlideOut_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomTracker _003C_003E4__this;

		private Vector3 _003CtempPos_003E5__2;

		private Color _003CtempColor_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CSlideOut_003Ed__14(int _003C_003E1__state)
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

	public static RoomTracker Instance;

	public TextMeshPro text;

	public float SourceY;

	public float TargetY;

	private Collider2D playerCollider;

	private ContactFilter2D filter;

	private Collider2D[] buffer;

	private Collider2D[] detectiveBuffer;

	public PlainShipRoom LastRoom;

	private Coroutine slideInRoutine;

	public void Awake()
	{
	}

	public void OnDisable()
	{
	}

	public void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CCoSlideIn_003Ed__13))]
	private IEnumerator CoSlideIn(SystemTypes newRoom)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSlideOut_003Ed__14))]
	private IEnumerator SlideOut()
	{
		return null;
	}

	private static bool CheckHitsForPlayer(Collider2D[] buffer, int hitCount, PlayerControl playerToCheck = null)
	{
		return false;
	}

	public string GetRoomForPlayer(NetworkedPlayerInfo player)
	{
		return null;
	}
}
