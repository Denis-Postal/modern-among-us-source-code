using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class AccessibilitySettingsData : AbstractSaveDataGroup
	{
		public const bool DEFAULT_COLOR_BLIND_MODE = false;

		[JsonProperty("colorBlindMode")]
		private bool colorBlindMode;

		public bool ColorBlindMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnColorBlindModeChanged
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
	}
}
