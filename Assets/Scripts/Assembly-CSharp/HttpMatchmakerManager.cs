using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using AmongUs.HTTP;
using AmongUs.Matchmaking;
using InnerNet;
using Newtonsoft.Json;

public class HttpMatchmakerManager : DestroyableSingleton<HttpMatchmakerManager>
{
	public class MatchmakerResponse
	{
		public MatchmakerError[] Errors;
	}

	public class MatchmakerError
	{
		public DisconnectReasons Reason;

		public SanctionReasons SanctionReason;

		public DateTimeOffset EndsAt;
	}

	public class UserTokenRequestData
	{
		public string Puid { get; set; }

		public string Username { get; set; }

		public int ClientVersion { get; set; }

		public SupportedLangs Language { get; set; }
	}

	public class HostServer
	{
		public readonly string Ip;

		public readonly ushort Port;

		public HostServer(long ip, ushort port)
		{
		}
	}

	public class MatchmakerFailure
	{
		public DisconnectReasons Reason { get; set; }

		public string CustomDisconnect { get; set; }

		public MatchmakerError MatchmakerError { get; set; }

		public bool ShouldGoOffline { get; set; }
	}

	[Serializable]
	public class Error
	{
		public DisconnectReasons Reason;
	}

	[Serializable]
	public class FindGameByCodeResponse
	{
		public List<Error> Errors;

		public GameListing Game;

		public StringNames Region;

		public string UntranslatedRegion;
	}

	[Serializable]
	public class FindGamesListFilteredResponse
	{
		[JsonProperty("games")]
		public List<GameListing> Games;

		[JsonProperty("metadata")]
		public GamesListMetadata Metadata;
	}

	[Serializable]
	public class GamesListMetadata
	{
		[JsonProperty("allGamesCount")]
		public int AllGamesCount;

		[JsonProperty("matchingGamesCount")]
		public int MatchingGamesCount;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string matchmakerToken;

		public Action<HostServer, string> onGameHost;

		public HttpMatchmakerManager _003C_003E4__this;

		internal void _003CCoFindGameCode_003Eb__0(string token)
		{
		}

		internal void _003CCoFindGameCode_003Eb__1(string server)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public HttpMatchmakerManager _003C_003E4__this;

		public Action<FindGameByCodeResponse, string> onGameInfo;

		public bool foundGame;

		public IRegionInfo initialRegion;

		public Action<MatchmakerFailure> _003C_003E9__2;

		internal void _003CCoFindGameInfo_003Eb__2(MatchmakerFailure failure)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public string matchmakerToken;

		public IRegionInfo region;

		public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals1;

		internal void _003CCoFindGameInfo_003Eb__0(string token)
		{
		}

		internal void _003CCoFindGameInfo_003Eb__1(string response)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string matchmakerToken;

		public Action<HostServer, string> onGameHost;

		public HttpMatchmakerManager _003C_003E4__this;

		internal void _003CCoFindHostServer_003Eb__0(string token)
		{
		}

		internal void _003CCoFindHostServer_003Eb__1(string server)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string matchmakerToken;

		public Action<InnerNetClient.TotalGameData, FindGamesListFilteredResponse> onGameList;

		public HttpMatchmakerManager _003C_003E4__this;

		internal void _003CCoRequestGameListFiltered_003Eb__0(string token)
		{
		}

		internal void _003CCoRequestGameListFiltered_003Eb__1(string gamesResponse)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string matchmakerToken;

		public Action<HashSet<string>> onTags;

		public HttpMatchmakerManager _003C_003E4__this;

		internal void _003CCoRefreshTags_003Eb__0(string token)
		{
		}

		internal void _003CCoRefreshTags_003Eb__1(string tags)
		{
		}

		internal void _003CCoRefreshTags_003Eb__2(MatchmakerFailure failure)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string matchmakerToken;

		public Action<PermittedFilters> onRefreshFilters;

		public HttpMatchmakerManager _003C_003E4__this;

		internal void _003CCoRefreshFilters_003Eb__0(string token)
		{
		}

		internal void _003CCoRefreshFilters_003Eb__1(string filtersString)
		{
		}

		internal void _003CCoRefreshFilters_003Eb__2(MatchmakerFailure failure)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string context;

		public HttpMatchmakerManager _003C_003E4__this;

		public RetryableWebRequest request;

		internal void _003CCoSendRequest_003Eb__0(RetryableWebRequest r)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_1
	{
		public bool didRefreshToken;

		public _003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals1;

		internal void _003CCoSendRequest_003Eb__1(string token)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoFindGameCode_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<HostServer, string> onGameHost;

		public HttpMatchmakerManager _003C_003E4__this;

		public int gameId;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		private string _003Curi_003E5__2;

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
		public _003CCoFindGameCode_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CCoFindGameInfo_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HttpMatchmakerManager _003C_003E4__this;

		public Action<FindGameByCodeResponse, string> onGameInfo;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		public int gameId;

		private _003C_003Ec__DisplayClass18_1 _003C_003E8__2;

		private List<IRegionInfo> _003Cregions_003E5__2;

		private int _003Ci_003E5__3;

		private string _003Curi_003E5__4;

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
		public _003CCoFindGameInfo_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CCoFindHostServer_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<HostServer, string> onGameHost;

		public HttpMatchmakerManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		private string _003Curi_003E5__2;

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
		public _003CCoFindHostServer_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CCoGetOrRefreshToken_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HttpMatchmakerManager _003C_003E4__this;

		public Action<string> onGetToken;

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
		public _003CCoGetOrRefreshToken_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CCoRefreshFilters_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<PermittedFilters> onRefreshFilters;

		public HttpMatchmakerManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

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
		public _003CCoRefreshFilters_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CCoRefreshTags_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<HashSet<string>> onTags;

		public HttpMatchmakerManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

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
		public _003CCoRefreshTags_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CCoRefreshTokenInternal_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HttpMatchmakerManager _003C_003E4__this;

		public Action<string> onGetToken;

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
		public _003CCoRefreshTokenInternal_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CCoRequestGameListFiltered_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<InnerNetClient.TotalGameData, FindGamesListFilteredResponse> onGameList;

		public HttpMatchmakerManager _003C_003E4__this;

		public IGameOptions gameSearchOptions;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private string _003Curi_003E5__2;

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
		public _003CCoRequestGameListFiltered_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CCoSendRequest_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string context;

		public HttpMatchmakerManager _003C_003E4__this;

		public RetryableWebRequest request;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		public Action<MatchmakerFailure> onFailure;

		private _003C_003Ec__DisplayClass24_1 _003C_003E8__2;

		public int maxRetries;

		private float _003CretryIntervalSeconds_003E5__2;

		private int _003CretryBackoffFactor_003E5__3;

		private int _003Cretries_003E5__4;

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
		public _003CCoSendRequest_003Ed__24(int _003C_003E1__state)
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

	private const string CONTEXT_AUTHENTICATE = "authenticate";

	private const string CONTEXT_REQUEST_GAME_CODE = "request gamecode server";

	private const string CONTEXT_FIND_HOST_SERVER = "find host server";

	private const string CONTEXT_REQUEST_GAMES_LIST = "request games list";

	private const string CONTEXT_GET_FILTER_TAGS = "get filter tags";

	private const string CONTEXT_GET_PERMITTED_FILTERS = "get permitted filters";

	private readonly Logger logger;

	private readonly GameOptionsFactory optionsFactory;

	private JsonSerializerSettings jsonSettings;

	private static readonly Dictionary<string, StringNames> ContextMessages;

	private static readonly Dictionary<long, StringNames> ErrorMessages;

	private MatchmakerToken token;

	private string base64Token;

	public override void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CCoGetOrRefreshToken_003Ed__14))]
	public IEnumerator CoGetOrRefreshToken(Action<string> onGetToken)
	{
		return null;
	}

	private bool TryReadCachedToken(out string matchmakerToken)
	{
		matchmakerToken = null;
		return false;
	}

	[IteratorStateMachine(typeof(_003CCoRefreshTokenInternal_003Ed__16))]
	private IEnumerator CoRefreshTokenInternal(Action<string> onGetToken)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoFindGameCode_003Ed__17))]
	public IEnumerator CoFindGameCode(int gameId, Action<HostServer, string> onGameHost)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoFindGameInfo_003Ed__18))]
	public IEnumerator CoFindGameInfo(int gameId, Action<FindGameByCodeResponse, string> onGameInfo)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoFindHostServer_003Ed__19))]
	public IEnumerator CoFindHostServer(Action<HostServer, string> onGameHost)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoRequestGameListFiltered_003Ed__20))]
	public IEnumerator CoRequestGameListFiltered(IGameOptions gameSearchOptions, GameFilterOptions filterOpts, Action<InnerNetClient.TotalGameData, FindGamesListFilteredResponse> onGameList)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoRefreshTags_003Ed__21))]
	public IEnumerator CoRefreshTags(Action<HashSet<string>> onTags)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoRefreshFilters_003Ed__22))]
	public IEnumerator CoRefreshFilters(Action<PermittedFilters> onRefreshFilters)
	{
		return null;
	}

	private IEnumerator CoSendRequest(RetryableWebRequest request, string context)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoSendRequest_003Ed__24))]
	private IEnumerator CoSendRequest(RetryableWebRequest request, string context, int maxRetries, Action<MatchmakerFailure> onFailure)
	{
		return null;
	}

	private MatchmakerFailure BundleFailureInfo(RetryableWebRequest request, string context)
	{
		return null;
	}

	private void SetDisconnectInfoAndShowPopup(MatchmakerFailure failure)
	{
	}
}
