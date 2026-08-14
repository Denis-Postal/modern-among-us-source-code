using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerAdsData : AbstractSaveDataGroup
	{
		public const ShowAdsState DEFAULT_ADS_STATE = ShowAdsState.NotAccepted;

		public const bool DEFAULT_HAS_PURCHASED_AD_REMOVAL = false;

		public static readonly DateTime DEFAULT_DATE_LAST_AD;

		private const int DEFAULT_ADS_WATCHED = 0;

		[JsonProperty("adsState")]
		private ShowAdsState adsState;

		[JsonProperty("hasPurchasedAdRemoval")]
		private bool hasPurchasedAdRemoval;

		[JsonProperty("DateAdWatched")]
		private DateTime lastDateWatchAd;

		[JsonProperty("AdsWatched")]
		private int adsWatched;

		public int AdsWatched => 0;

		public bool CanWatchAdAgain => false;

		public ShowAdsState AdsState
		{
			get
			{
				return default(ShowAdsState);
			}
			set
			{
			}
		}

		public bool HasPurchasedAdRemoval
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnShowAdsStateChanged
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

		public event Action OnHasPurchasedAdRemovalChanged
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

		public event Action OnAdsWatchedChanged
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

		public event Action OnTimeWatchedAdChanged
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

		public int HoursLeftNewAd()
		{
			return 0;
		}

		public void SetDateAdWatched()
		{
		}
	}
}
