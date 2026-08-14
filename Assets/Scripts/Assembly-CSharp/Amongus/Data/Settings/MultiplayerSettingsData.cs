using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using AmongUs.Matchmaking;
using InnerNet;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class MultiplayerSettingsData : AbstractSaveDataGroup
	{
		public const bool DEFAULT_CROSS_PLAY = true;

		public const bool DEFAULT_ALLOW_FRIEND_INVITES = true;

		public const bool DEFAULT_CENSOR_CHAT = true;

		public const QuickChatModes DEFAULT_CHAT_MODE = QuickChatModes.FreeChatOrQuickChat;

		public const GameModes DEFAULT_LAST_PLAYED_GAMEMODE = GameModes.Normal;

		public static readonly StringNames[] DEFAULT_QUICK_CHAT_FAVORITES;

		public static readonly byte[] DEFAULT_RAW_GAME_OPTIONS;

		public static readonly DateTime DEFAULT_FILTER_DATE;

		public static readonly string[] DEFAULT_FILTER_TAGS;

		public static readonly GameFilterOptions DEFAULT_VALID_GAME_FILTER_OPTIONS;

		public static readonly GameFilterOptions DEFAULT_HOST_GAME_FILTER_OPTIONS;

		public static readonly GameFilterOptions DEFAULT_SEARCH_GAME_FILTER_OPTIONS;

		public static readonly Dictionary<string, string> DEFAULT_FILTER_DICTIONARY;

		public static readonly GameFilterSet DEFAULT_GAMEFILTER_SET;

		public static readonly GameFilterSet DEFAULT_HNSFILTER_SET;

		[JsonProperty("crossPlay")]
		private bool crossPlay;

		[JsonProperty("allowFriendInvites")]
		private bool allowFriendInvites;

		[JsonProperty("censorChat")]
		private bool censorChat;

		[JsonProperty("chatMode")]
		private QuickChatModes chatMode;

		[JsonProperty("quickChatFavs")]
		private List<StringNames> quickChatFavorites;

		[JsonProperty("lastPlayedGameMode")]
		private GameModes lastPlayedGameMode;

		[JsonProperty("normalHostOptions")]
		private byte[] rawNormalHostOptions;

		[JsonProperty("normalSearchOptions")]
		private byte[] rawNormalSearchOptions;

		[JsonProperty("hideNSeekHostOptions")]
		private byte[] rawHideNSeekHostOptions;

		[JsonProperty("hideNSeekSearchOptions")]
		private byte[] rawHideNSeekSearchOptions;

		[JsonProperty("gameFilterRefreshDate")]
		private DateTime validGameFilterLastRefreshDate;

		[JsonProperty("gameFilterTags")]
		private string[] validGameFilterTags;

		[JsonProperty("hostFilterTags")]
		private string[] hostGameFilterTags;

		[JsonProperty("searchFilterTags")]
		private string[] searchGameFilterTags;

		[JsonProperty("filterDictionary")]
		private Dictionary<string, string> filterDictionary;

		[JsonProperty("classicFilterSet")]
		private GameFilterSet classicFilterSet;

		[JsonProperty("hnsFilterSet")]
		private GameFilterSet hnsFilterSet;

		private GameFilterOptions validGameFilterOptions;

		private GameFilterOptions hostGameFilterOptions;

		private GameFilterOptions searchGameFilterOptions;

		public bool CrossPlay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AllowFriendInvites
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CensorChat
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public QuickChatModes ChatMode
		{
			get
			{
				return default(QuickChatModes);
			}
			set
			{
			}
		}

		public GameModes LastPlayedGameMode
		{
			get
			{
				return default(GameModes);
			}
			set
			{
			}
		}

		public byte[] RawNormalHostOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] RawNormalSearchOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] RawHideNSeekHostOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] RawHideNSeekSearchOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameFilterOptions ValidGameFilterOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameFilterOptions HostGameFilterOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameFilterOptions SearchGameFilterOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameFilterSet ClassicFilterSet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameFilterSet HnSFilterSet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action OnCrossPlayChanged
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

		public event Action OnAllowFriendInvitesChanged
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

		public event Action OnCensorChatChanged
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

		public event Action OnChatModeChanged
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

		public event Action OnQuickChatFavoritesChanged
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

		public event Action OnLastPlayedGameModeChanged
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

		public event Action OnNormalHostOptionsChanged
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

		public event Action OnNormalSearchOptionsChanged
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

		public event Action OnHideNSeekHostOptionsChanged
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

		public event Action OnHideNSeekSearchOptionsChanged
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

		public event Action OnValidGameFilterOptionsChanged
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

		public event Action OnHostGameFilterOptionsChanged
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

		public event Action OnSearchGameFilterOptionsChanged
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

		public event Action OnGameFilterChanged
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

		protected override void OnSaveStart()
		{
		}

		protected override void OnLoadComplete()
		{
		}

		public bool HasQuickChatFavorite(StringNames key)
		{
			return false;
		}

		public void AddQuickChatFavorite(StringNames key)
		{
		}

		public void RemoveQuickChatFavorite(StringNames key)
		{
		}

		public void ValidateFilterTags()
		{
		}
	}
}
