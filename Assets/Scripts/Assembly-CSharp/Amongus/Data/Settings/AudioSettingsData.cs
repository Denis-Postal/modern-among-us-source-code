using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class AudioSettingsData : AbstractSaveDataGroup
	{
		public const float DEFAULT_MUSIC_VOLUME = 0.6f;

		public const float DEFAULT_AMBIENCE_VOLUME = 0.6f;

		public const float DEFAULT_SFX_VOLUME = 0.6f;

		[JsonProperty("musicVolume")]
		private float musicVolume;

		[JsonProperty("ambienceVolume")]
		private float ambienceVolume;

		[JsonProperty("sfxVolume")]
		private float sfxVolume;

		public float MusicVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AmbienceVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SfxVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event Action OnMusicVolumeChanged
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

		public event Action OnAmbienceVolumeChanged
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

		public event Action OnSfxVolumeChanged
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
