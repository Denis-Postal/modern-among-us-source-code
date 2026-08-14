using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KillAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public PlayerControl target;

		internal void _003CCoPerformKill_003Eb__0(SpriteRenderer b)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoPerformKill_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl target;

		public PlayerControl source;

		public KillAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		private FollowerCamera _003Ccam_003E5__2;

		private bool _003CisParticipant_003E5__3;

		private PlayerPhysics _003CsourcePhys_003E5__4;

		private DeadBody _003CdeadBody_003E5__5;

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
		public _003CCoPerformKill_003Ed__2(int _003C_003E1__state)
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

	public AnimationClip BlurAnim;

	public Vector3 BodyOffset;

	[IteratorStateMachine(typeof(_003CCoPerformKill_003Ed__2))]
	public IEnumerator CoPerformKill(PlayerControl source, PlayerControl target)
	{
		return null;
	}

	public static void SetMovement(PlayerControl source, bool canMove)
	{
	}
}
