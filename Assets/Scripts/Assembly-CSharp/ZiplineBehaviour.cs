using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ZiplineBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoAlightPlayerFromZipline_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl player;

		public ZiplineBehaviour _003C_003E4__this;

		public Vector3 landingPosition;

		public bool fromTop;

		public HandZiplinePoolable hand;

		private float _003CziplineTime_003E5__2;

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
		public _003CCoAlightPlayerFromZipline_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CCoAnimatePlayerJumpingOnToZipline_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HandZiplinePoolable hand;

		public PlayerControl player;

		public bool fromTop;

		public ZiplineBehaviour _003C_003E4__this;

		private float _003CziplineTime_003E5__2;

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
		public _003CCoAnimatePlayerJumpingOnToZipline_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CCoAnimateZiplineAndPlayer_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool fromTop;

		public ZiplineBehaviour _003C_003E4__this;

		public Vector3 handleEndPosition;

		public PlayerControl player;

		public HandZiplinePoolable hand;

		private float _003CtravelSeconds_003E5__2;

		private Vector3 _003CstartPos_003E5__3;

		private Vector3 _003ChandOffset_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003CCoAnimateZiplineAndPlayer_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CCoDownSound_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ZiplineBehaviour _003C_003E4__this;

		public PlayerControl player;

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
		public _003CCoDownSound_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CCoTogglePetVisibility_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delaySeconds;

		public PlayerControl player;

		public bool shouldMakeVisible;

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
		public _003CCoTogglePetVisibility_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CCoUseZipline_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ZiplineBehaviour _003C_003E4__this;

		public PlayerControl player;

		public Transform start;

		public bool fromTop;

		public Transform end;

		public Transform landing;

		private float _003CziplineTime_003E5__2;

		private float _003CtotalTime_003E5__3;

		private int _003CsuperAbort_003E5__4;

		private HandZiplinePoolable _003CcurrentHand_003E5__5;

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
		public _003CCoUseZipline_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CCoWalkPlayerToZipline_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl player;

		public ZiplineBehaviour _003C_003E4__this;

		public Vector3 handleStartPosition;

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
		public _003CCoWalkPlayerToZipline_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CCoWalkPlayerToZiplineWhileWaiting_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl player;

		public ZiplineBehaviour _003C_003E4__this;

		public Vector3 handleStartPosition;

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
		public _003CCoWalkPlayerToZiplineWhileWaiting_003Ed__44(int _003C_003E1__state)
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

	public const float MAX_USE_DISTANCE = 3f;

	private const string SFX_NAME = "ZiplineTravel_";

	private const float PET_HIDE_SPEED = 2f;

	private const float TOGGLE_PET_INVISIBLE_SECONDS = 0.5f;

	private const float TOGGLE_PET_VISIBLE_SECONDS = 0f;

	[SerializeField]
	[Header("Positions")]
	private Transform handleTop;

	[SerializeField]
	private Transform handleBottom;

	[SerializeField]
	private Transform landingPositionBottom;

	[SerializeField]
	private Transform landingPositionTop;

	[SerializeField]
	private Transform dropPositionBottom;

	[SerializeField]
	private Transform dropPositionTop;

	[Header("Travel time")]
	[SerializeField]
	private float upTravelTime;

	[SerializeField]
	private float downTravelTime;

	[SerializeField]
	[Header("Animation Settings")]
	private float timeJump;

	[SerializeField]
	private AnimationCurve jumpZiplineCurve;

	[SerializeField]
	private AnimationCurve jumpZiplineCurveBottom;

	[SerializeField]
	private AnimationCurve jumpZiplineHandCurve;

	[Header("Hand Settings")]
	[SerializeField]
	private ObjectPoolBehavior handPool;

	[SerializeField]
	private Transform upHandPosition;

	[SerializeField]
	private Transform downHandPosition;

	[SerializeField]
	[Header("Audio")]
	private AudioClip attachSound;

	[SerializeField]
	private AudioClip detachSound;

	[SerializeField]
	private AudioClip upSound;

	[SerializeField]
	private AudioClip downSound;

	[SerializeField]
	private AudioClip downLoopSound;

	private readonly Logger logger;

	private Dictionary<byte, Coroutine> playerIdWalkCoroutines;

	private Dictionary<byte, Coroutine> playerIdUseZiplineCoroutines;

	private Dictionary<byte, HandZiplinePoolable> playerIdHands;

	private Dictionary<byte, IEnumerator> soundLoopCoroutines;

	private ZiplineConsole lastUsedConsole;

	private void Awake()
	{
	}

	public void Use(bool fromTop, ZiplineConsole console)
	{
	}

	public void OnMeetingCalled()
	{
	}

	public void Use(PlayerControl player, bool fromTop)
	{
	}

	public Vector3 GetHandlePos(bool fromTop)
	{
		return default(Vector3);
	}

	public void CancelZiplineUseForPlayer(PlayerControl player)
	{
	}

	private void StopAllCoroutinesForPlayer(PlayerControl player)
	{
	}

	private void PreUseZipline(PlayerControl player, bool fromTop)
	{
	}

	[IteratorStateMachine(typeof(_003CCoUseZipline_003Ed__39))]
	private IEnumerator CoUseZipline(PlayerControl player, Transform start, Transform end, Transform landing, bool fromTop)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoAnimatePlayerJumpingOnToZipline_003Ed__40))]
	private IEnumerator CoAnimatePlayerJumpingOnToZipline(PlayerControl player, bool fromTop, HandZiplinePoolable hand)
	{
		return null;
	}

	private void PreparePlayerForZipline(PlayerControl player, bool gotPermission)
	{
	}

	[IteratorStateMachine(typeof(_003CCoTogglePetVisibility_003Ed__42))]
	private IEnumerator CoTogglePetVisibility(PlayerControl player, float delaySeconds, bool shouldMakeVisible)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoWalkPlayerToZipline_003Ed__43))]
	private IEnumerator CoWalkPlayerToZipline(PlayerControl player, Vector3 handleStartPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoWalkPlayerToZiplineWhileWaiting_003Ed__44))]
	private IEnumerator CoWalkPlayerToZiplineWhileWaiting(PlayerControl player, Vector3 handleStartPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoAnimateZiplineAndPlayer_003Ed__45))]
	private IEnumerator CoAnimateZiplineAndPlayer(PlayerControl player, Vector3 handleEndPosition, bool fromTop, HandZiplinePoolable hand)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoAlightPlayerFromZipline_003Ed__46))]
	private IEnumerator CoAlightPlayerFromZipline(PlayerControl player, Vector3 landingPosition, bool fromTop, HandZiplinePoolable hand)
	{
		return null;
	}

	private void StartSound(PlayerControl player, bool fromTop)
	{
	}

	private void StopZiplineSound(PlayerControl player)
	{
	}

	private void StopAllZiplineSounds()
	{
	}

	[IteratorStateMachine(typeof(_003CCoDownSound_003Ed__50))]
	private IEnumerator CoDownSound(PlayerControl player)
	{
		return null;
	}

	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	private bool ShouldPlaySound()
	{
		return false;
	}

	private void PlaySound(AudioClip sound, Vector2 soundPosition, PlayerControl player)
	{
	}

	private Vector2 GetClosestPointOnLine(Vector2 lineStart, Vector2 lineEnd, Vector2 position)
	{
		return default(Vector2);
	}

	private void ResetZipline()
	{
	}

	private void ResetZiplineMeeting()
	{
	}

	private void ResetTarget(PlayerControl player)
	{
	}

	private HandZiplinePoolable GetHand()
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
