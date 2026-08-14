using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerStoreData : AbstractSaveDataGroup
	{
		public const string DEFAULT_ACTIVE_COSMICUBE = "";

		public static readonly DateTime DEFAULT_LAST_VIEW_DATE;

		[JsonProperty("activeCosmicube")]
		private string activeCosmicube;

		[JsonProperty("bundlesViewDate")]
		private DateTime bundlesViewDate;

		[JsonProperty("hatsViewDate")]
		private DateTime hatsViewDate;

		[JsonProperty("outfitsViewDate")]
		private DateTime outfitsViewDate;

		[JsonProperty("visorsViewDate")]
		private DateTime visorsViewDate;

		[JsonProperty("petsViewDate")]
		private DateTime petsViewDate;

		[JsonProperty("nameplatesViewDate")]
		private DateTime nameplatesViewDate;

		[JsonProperty("cosmicubeViewDate")]
		private DateTime cosmicubeViewDate;

		[JsonProperty("legacyPurchases")]
		private List<string> legacyPurchases;

		public const string LEGACY_PURCHASE_GEOFF_HAT = "hat_geoff";

		public const string LEGACY_PURCHASE_TEST_PET = "pet_test";

		public const string LEGACY_PURCHASE_PURPLE_TRAFFIC_HAT = "hat_traffic_purple";

		public const string LEGACY_PURCHASE_NEW_YEARS_2018_HAT = "hats_newyears2018";

		public const string LEGACY_PURCHASE_HOLIDAY_2018_HAT = "hat_holiday2018";

		public const string LEGACY_PURCHASE_HALLOWEEN_HAT_2019 = "hats_halloween2019";

		public static readonly string[] LEGACY_PURCHASE_KEYS;

		public string ActiveCosmicube
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime LastBundlesViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LastHatsViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LastOutfitsViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LastVisorsViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LastPetsViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LastNameplatesViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LastCosmicubeViewDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public event Action OnActiveCosmicubeChanged
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

		public event Action OnBundlesViewDateChanged
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

		public event Action OnHatsViewDateChanged
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

		public event Action OnOutfitsViewDateChanged
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

		public event Action OnVisorsViewDateChanged
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

		public event Action OnPetsViewDateChanged
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

		public event Action OnNameplatesViewDateChanged
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

		public event Action OnCosmicubeViewDateChanged
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

		public event Action OnHasGeoffHatDropChanged
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

		public event Action OnHasTestPetDropChanged
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

		public event Action OnHasTrafficPurpleHatDropChanged
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

		public event Action OnCachedPurchasedBundlesChanged
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

		public DateTime GetStoreTabViewDate(StoreTab tab)
		{
			return default(DateTime);
		}

		public void SetStoreTabViewDate(StoreTab tab, DateTime val)
		{
		}

		public void MigrateLegacyPurchases()
		{
		}

		private void TryMigrateLegacyUnlock(string key)
		{
		}

		public bool HasLegacyPurchase(string key)
		{
			return false;
		}

		public string[] GetLegacyPurchases()
		{
			return null;
		}

		public void AddLegacyPurchases(params string[] keys)
		{
		}
	}
}
