using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class MeetingIntroAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoRun_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingIntroAnimation _003C_003E4__this;

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
		public _003CCoRun_003Ed__17(int _003C_003E1__state)
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

	public Transform VoteButtonParent;

	public Transform OverlayParent;

	public Transform DeadParent;

	public GameObject ProtectedRecently;

	public TextMeshPro DeadBodiesText;

	public SpriteRenderer BloodSplat;

	public Vector3 VoteButtonParentPos;

	public Vector3 ReporterPos;

	public SpriteRenderer background;

	public AnimationCurve SlamCurve;

	public PlayerVoteArea VoteAreaPrefab;

	public AudioClip PlayerDeadSound;

	public AudioClip ProtectedRecentlySound;

	private List<PlayerVoteArea> deadCards;

	public SpriteRenderer[] OutsideMasks;

	public void Start()
	{
	}

	public void Init(NetworkedPlayerInfo reporter, NetworkedPlayerInfo[] deadBodies)
	{
	}

	[IteratorStateMachine(typeof(_003CCoRun_003Ed__17))]
	public IEnumerator CoRun()
	{
		return null;
	}
}
