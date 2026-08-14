using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class VideoSettingsData : AbstractSaveDataGroup
	{
		public const bool DEFAULT_VSYNC = false;

		[JsonProperty("vsync")]
		private bool vsync;

		public bool VSync
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnVSyncChanged
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
