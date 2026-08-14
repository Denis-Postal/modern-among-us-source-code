using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using TMPro;
using UnityEngine;

public class PlayerVoteArea : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoAnimateOverlay_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerVoteArea _003C_003E4__this;

		private float _003Cduration_003E5__2;

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
		public _003CCoAnimateOverlay_003Ed__45(int _003C_003E1__state)
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

	public byte TargetPlayerId;

	public const byte HasNotVoted = byte.MaxValue;

	public const byte MissedVote = 254;

	public const byte SkippedVote = 253;

	public const byte DeadVote = 252;

	public GameObject Buttons;

	public UiElement ConfirmButton;

	public UiElement CancelButton;

	public UiElement PlayerButton;

	public SpriteRenderer Background;

	public SpriteRenderer MaskArea;

	public SpriteRenderer Flag;

	public SpriteRenderer Megaphone;

	public SpriteRenderer Overlay;

	public SpriteRenderer XMark;

	public SpriteRenderer GAIcon;

	public SpriteRenderer ThumbsDown;

	public SpriteRenderer HighlightedFX;

	public TextMeshPro NameText;

	public TextMeshPro LevelNumberText;

	public TextMeshPro ColorBlindName;

	public bool AnimateButtonsFromLeft;

	public bool AmDead;

	public bool DidReport;

	public byte VotedFor;

	public bool voteComplete;

	public bool resultsShowing;

	[SerializeField]
	private PoolablePlayer PlayerIcon;

	public MeetingHud Parent { get; set; }

	public bool DidVote => false;

	public int MaskLayer { get; private set; }

	private void Start()
	{
	}

	public void SetTargetPlayerId(byte targetId)
	{
	}

	public void SetMaskLayer(int maskLayer)
	{
	}

	public void SetDead(bool didReport, bool isDead, bool isGuardian = false)
	{
	}

	public void SetDisabled()
	{
	}

	public void SetEnabled()
	{
	}

	public void UpdateOverlay()
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimateOverlay_003Ed__45))]
	public IEnumerator CoAnimateOverlay()
	{
		return null;
	}

	private static float TriangleWave(float t)
	{
		return 0f;
	}

	internal void SetVote(byte suspectIdx)
	{
	}

	public void UnsetVote()
	{
	}

	public void ClearButtons()
	{
	}

	public void ClearForResults()
	{
	}

	public void VoteForMe()
	{
	}

	private bool canBeHighlighted()
	{
		return false;
	}

	public void SetHighlighted(bool value)
	{
	}

	public void Select()
	{
	}

	public void Cancel()
	{
	}

	public void Serialize(MessageWriter writer)
	{
	}

	public void Deserialize(MessageReader reader)
	{
	}

	public void SetCosmetics(NetworkedPlayerInfo playerInfo)
	{
	}

	public void PreviewNameplate(string plateID)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetColorblindText()
	{
	}
}
