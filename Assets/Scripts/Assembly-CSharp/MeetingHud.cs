using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using InnerNet;
using TMPro;
using UnityEngine;

public class MeetingHud : InnerNetObject, IDisconnectHandler
{
	public struct VoterState
	{
		public byte VoterId;

		public byte VotedForId;

		public bool AmDead => false;

		public bool SkippedVote => false;

		public static VoterState Deserialize(MessageReader reader)
		{
			return default(VoterState);
		}

		public void Serialize(MessageWriter writer)
		{
		}
	}

	public enum VoteStates
	{
		Animating = 0,
		Discussion = 1,
		NotVoted = 2,
		Voted = 3,
		Results = 4,
		Proceeding = 5
	}

	[CompilerGenerated]
	private sealed class _003CCoIntro_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingHud _003C_003E4__this;

		public NetworkedPlayerInfo reportedBody;

		public NetworkedPlayerInfo reporter;

		public NetworkedPlayerInfo[] deadBodies;

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
		public _003CCoIntro_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CCoStartCutscene_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeetingHud _003C_003E4__this;

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
		public _003CCoStartCutscene_003Ed__54(int _003C_003E1__state)
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

	private const int NumColumns = 3;

	private const float ResultsTime = 5f;

	private const float Depth = 0f;

	public static MeetingHud Instance;

	public SpriteRenderer BlackBackground;

	public SpriteRenderer[] OuterMasks;

	public SpriteRenderer[] PlayerColoredParts;

	public MeetingIntroAnimation MeetingIntro;

	public Transform ButtonParent;

	public TextMeshPro TitleText;

	public Vector3 VoteOrigin;

	public Vector3 VoteButtonOffsets;

	public PlayerVoteArea SkipVoteButton;

	private PlayerVoteArea[] playerStates;

	public PlayerVoteArea PlayerButtonPrefab;

	public SpriteRenderer PlayerVotePrefab;

	public Sprite CrackedGlass;

	public SpriteRenderer Glass;

	public PassiveButton ProceedButton;

	public AbilityButton MeetingAbilityButton;

	public AudioClip VoteSound;

	public AudioClip VoteLockinSound;

	public AudioClip VoteEndingSound;

	[SerializeField]
	private Transform meetingContents;

	private VoteStates state;

	public GameObject SkippedVoting;

	public SpriteRenderer HostIcon;

	private NetworkedPlayerInfo exiledPlayer;

	private bool wasTie;

	public TextMeshPro TimerText;

	public float discussionTimer;

	private byte reporterId;

	private bool amDead;

	private float resultsStartedAt;

	private int lastSecond;

	private readonly Logger logger;

	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected;

	public UiElement ProceedButtonUi;

	public List<UiElement> ControllerSelectable;

	public bool IsPersistent => false;

	public VoteStates CurrentState => default(VoteStates);

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public override void OnDestroy()
	{
	}

	private void SetForegroundForDead()
	{
	}

	public void Update()
	{
	}

	private void UpdateTimerText(StringNames key, int value)
	{
	}

	private void SetMasksEnabled(bool enabled)
	{
	}

	[IteratorStateMachine(typeof(_003CCoIntro_003Ed__53))]
	public IEnumerator CoIntro(NetworkedPlayerInfo reporter, NetworkedPlayerInfo reportedBody, NetworkedPlayerInfo[] deadBodies)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoStartCutscene_003Ed__54))]
	private IEnumerator CoStartCutscene()
	{
		return null;
	}

	public void ServerStart(byte reporter)
	{
	}

	public void Close()
	{
	}

	private void VotingComplete(VoterState[] states, NetworkedPlayerInfo exiled, bool tie)
	{
	}

	public bool Select(int suspectStateIdx)
	{
		return false;
	}

	public void Confirm(byte suspectStateIdx)
	{
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}

	private void ForceSkipAll()
	{
	}

	public void CastVote(byte srcPlayerId, byte suspectPlayerId)
	{
	}

	public void ClearVote()
	{
	}

	private void CheckForEndVoting()
	{
	}

	private Dictionary<byte, int> CalculateVotes()
	{
		return null;
	}

	public void HandleProceed()
	{
	}

	private void SetupProceedButton()
	{
	}

	private void PopulateResults(VoterState[] states)
	{
	}

	private void BloopAVoteIcon(NetworkedPlayerInfo voterPlayer, int index, Transform parent)
	{
	}

	private void UpdateButtons()
	{
	}

	private void PopulateButtons(byte reporter)
	{
	}

	private void SortButtons()
	{
	}

	private PlayerVoteArea CreateButton(NetworkedPlayerInfo playerInfo)
	{
		return null;
	}

	public bool DidVote(byte playerId)
	{
		return false;
	}

	public int GetVotesRemaining()
	{
		return 0;
	}

	public void RpcClose()
	{
	}

	public void CmdCastVote(byte playerId, byte suspectIdx)
	{
	}

	private void RpcVotingComplete(VoterState[] states, NetworkedPlayerInfo exiled, bool tie)
	{
	}

	private void RpcClearVote(int clientId)
	{
	}

	public override void ClearOrDecrementDirt()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
