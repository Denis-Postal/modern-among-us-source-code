using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.InnerNet;
using Steamworks;
using UnityEngine;
using UnityEngine.Networking;

public class FriendsListManager : DestroyableSingleton<FriendsListManager>
{
	public class PlatformFriend
	{
		public string Username;

		public ulong GUID;

		public CSteamID CSteamID;

		public PlatformFriend(string name, CSteamID CSteamID)
		{
		}
	}

	public class RecentPlayedWithPlayer
	{
		public readonly string PlayerName;

		public readonly string Puid;

		public readonly string FriendCode;

		public RecentPlayedWithPlayer(NetworkedPlayerInfo player)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public FriendsListManager _003C_003E4__this;

		public bool gotBlocks;

		public bool gotFriends;

		internal void _003CRefreshFriendsList_003Eb__0(ResponseState cb, Response<ResponseBlockedWrapper> response)
		{
		}

		internal void _003CRefreshFriendsList_003Eb__1(ResponseState cb, Response<ResponseFriendWrapper> response)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public float pollingInterval;

		public FriendsListManager _003C_003E4__this;

		internal void _003CPollForRequests_003Eb__1(ResponseState cb, Response<ResponseGameInvites> response)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckFriendCodeOnLogin_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FriendsListManager _003C_003E4__this;

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
		public _003CCheckFriendCodeOnLogin_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CCoJoinGameViaFriendInvite_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FriendsListManager _003C_003E4__this;

		public string roomCode;

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
		public _003CCoJoinGameViaFriendInvite_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CDelete_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string endpoint;

		public FriendsListManager _003C_003E4__this;

		public Action<ResponseState, string> resultCallback;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CDelete_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CGet_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string endpoint;

		public FriendsListManager _003C_003E4__this;

		public Action<ResponseState, string> resultCallback;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CGet_003Ed__63(int _003C_003E1__state)
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
	private sealed class _003CGetFriendCode_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<ResponseState, Response<ResponseFriendCode>> resultCallback;

		public FriendsListManager _003C_003E4__this;

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
		public _003CGetFriendCode_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CPollForRequests_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FriendsListManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass50_0 _003C_003E8__1;

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
		public _003CPollForRequests_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CPopulatePlatformFriendList_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FriendsListManager _003C_003E4__this;

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
		public _003CPopulatePlatformFriendList_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CPost_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string endpoint;

		public string jsonContent;

		public FriendsListManager _003C_003E4__this;

		public Action<ResponseState, string> resultCallback;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CPost_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003CRefreshFriendsList_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FriendsListManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		public Action cb;

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
		public _003CRefreshFriendsList_003Ed__35(int _003C_003E1__state)
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

	public JoinGameButton joinGameButton;

	public List<ResponseFriends> Friends;

	public List<PlatformFriend> PlatformFriends;

	public List<ResponseBlockedPlayer> BlockedPlayers;

	public List<ResponseBlockedBy> BlockedByPlayers;

	public List<ResponseReceivedFriendRequest> ReceivedRequests;

	public List<LobbyInvite> ReceivedLobbyInvites;

	public List<RecentPlayedWithPlayer> RecentlyPlayedWith;

	public FriendListNotification FriendListNotification;

	public FriendsListConfirmMenu ConfirmationScreen;

	public FriendsListUI Ui;

	public FriendsListButton FriendsListButton;

	public SpriteRenderer LoadScreen;

	public bool FriendCodeHidden;

	public Sprite GlobalPlayerIcon;

	[HideInInspector]
	public Dictionary<int, StringNames> ErrorCodes;

	private readonly Logger logger;

	private Coroutine pollingRoutine;

	private bool gotFriendRequests;

	private bool gotLobbyInvites;

	[SerializeField]
	private FriendsListConfirmMenu ConfirmationScreenPrefab;

	[SerializeField]
	private FriendsListUI UiPrefab;

	[SerializeField]
	private FriendsListButton FriendsListButtonPrefab;

	public static CSteamID myId;

	private Callback<GameRichPresenceJoinRequested_t> m_GameRichPresenceJoinRequested;

	public override void Awake()
	{
	}

	public override void OnDestroy()
	{
	}

	private void OnAllowFriendInvitesChanged()
	{
	}

	private bool SetRequestHeaders(UnityWebRequest request)
	{
		return false;
	}

	public void OnSignIn()
	{
	}

	public bool HasPlayerBlockedMeUsername(string friendcode)
	{
		return false;
	}

	public bool HasPlayerBlockedMe(string puid)
	{
		return false;
	}

	public bool IsPlayerBlocked(string puid)
	{
		return false;
	}

	public bool IsPlayerFriend(string puid)
	{
		return false;
	}

	public bool IsPlayerBlockedUsername(string friendcode)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CRefreshFriendsList_003Ed__35))]
	public IEnumerator RefreshFriendsList(Action cb, bool checkPSNBlocked = true)
	{
		return null;
	}

	public void OnSignOut()
	{
	}

	private void StartPolling()
	{
	}

	private void StopPolling()
	{
	}

	public void SetRecentlyPlayed(List<NetworkedPlayerInfo> players)
	{
	}

	public void UpdateFriendsDataWithPlayers(List<NetworkedPlayerInfo> players)
	{
	}

	public void ReparentUI()
	{
	}

	public void OpenUi()
	{
	}

	public void CloseUI()
	{
	}

	public void JoinGameViaFriendInvite(string roomCode)
	{
	}

	[IteratorStateMachine(typeof(_003CCoJoinGameViaFriendInvite_003Ed__45))]
	private IEnumerator CoJoinGameViaFriendInvite(string roomCode)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckFriendCodeOnLogin_003Ed__46))]
	public IEnumerator CheckFriendCodeOnLogin()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetFriendCode_003Ed__47))]
	public IEnumerator GetFriendCode(Action<ResponseState, Response<ResponseFriendCode>> resultCallback)
	{
		return null;
	}

	public void SetFriendCode(string username, Action<ResponseState, Response<ResponseFriendCode>> resultCallback)
	{
	}

	public void OpenConfirmationScreen(Action confirm, FriendsListConfirmMenu.ActionType type, string recipientFriendCode)
	{
	}

	[IteratorStateMachine(typeof(_003CPollForRequests_003Ed__50))]
	private IEnumerator PollForRequests()
	{
		return null;
	}

	public void GetFriends(Action<ResponseState, Response<ResponseFriendWrapper>> resultCallback)
	{
	}

	public void GetReceivedFriendRequests(Action<ResponseState, Response<ResponseReceivedFriendRequestWrapper>> resultCallback)
	{
	}

	public void SendFriendRequest(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void SendFriendRequestByUsername(string username, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void DenyFriendRequest(string puid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void RemoveFriend(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void BlockPlayer(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void UnblockPlayer(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void GetBlockedPlayers(Action<ResponseState, Response<ResponseBlockedWrapper>> resultCallback)
	{
	}

	public void SendGameInvite(string recipientPuid, string roomCode, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	public void GetLobbyInvites(Action<ResponseState, Response<ResponseGameInvites>> resultCallback)
	{
	}

	public void DenyLobbyInvite(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CGet_003Ed__63))]
	private IEnumerator Get(string endpoint, Action<ResponseState, string> resultCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelete_003Ed__64))]
	private IEnumerator Delete(string endpoint, Action<ResponseState, string> resultCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPost_003Ed__65))]
	private IEnumerator Post(string endpoint, string jsonContent, Action<ResponseState, string> resultCallback)
	{
		return null;
	}

	public void SetFriendButtonColor(bool isGrayedOut)
	{
	}

	private void OnAwake()
	{
	}

	private void HandleGameInvite(GameRichPresenceJoinRequested_t param)
	{
	}

	[IteratorStateMachine(typeof(_003CPopulatePlatformFriendList_003Ed__71))]
	public IEnumerator PopulatePlatformFriendList()
	{
		return null;
	}
}
