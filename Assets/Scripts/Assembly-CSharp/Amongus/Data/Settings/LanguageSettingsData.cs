using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class LanguageSettingsData : AbstractSaveDataGroup
	{
		public const string DEFAULT_LANGUAGE = "none";

		public const SupportedLangs DEFAULT_CACHED_LANGUAGE = (SupportedLangs)(-1);

		[JsonProperty("currentLanguage")]
		private string language;

		private SupportedLangs cachedLanguage;

		public SupportedLangs CurrentLanguage
		{
			get
			{
				return default(SupportedLangs);
			}
			set
			{
			}
		}

		public event Action OnLanguageChanged
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
	}
}
