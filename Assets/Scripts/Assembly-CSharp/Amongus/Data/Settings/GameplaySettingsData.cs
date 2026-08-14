using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class GameplaySettingsData : AbstractSaveDataGroup
	{
		public const bool DEFAULT_SCREEN_SHAKE = true;

		public const bool DEFAULT_STREAMER_MODE = false;

		[JsonProperty("screenShake")]
		private bool screenShake;

		[JsonProperty("streamerMode")]
		private bool streamerMode;

		public bool ScreenShake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool StreamerMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnScreenShakeChanged
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

		public event Action OnStreamerModeChanged
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
