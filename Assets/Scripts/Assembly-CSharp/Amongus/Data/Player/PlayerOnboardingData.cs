using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerOnboardingData : AbstractSaveDataGroup
	{
		public const int DEFAULT_PRIVACY_POLICY_VERSION = 0;

		public const bool DEFAULT_VIEWED_ONLINE_HELP_MESSAGE = false;

		public const bool DEFAULT_VIEWED_MIN_PLAYER_WARNING = false;

		public const bool DEFAULT_ALWAYS_SHOW_MIN_PLAYER_WARNING = true;

		public const bool DEFAULT_VIEWED_HIDEANDSEEK_HOWTOPLAY = false;

		[JsonProperty("privacyPolicyVersion")]
		private int privacyPolicyVersion;

		[JsonProperty("viewedOnlineHelpMessage")]
		private bool viewedOnlineHelpMessage;

		[JsonProperty("viewedMinPlayerWarning")]
		private bool viewedMinPlayerWarning;

		[JsonProperty("alwaysShowMinPlayerWarning")]
		private bool alwaysShowMinPlayerWarning;

		[JsonProperty("viewedHideAndSeekHowToPlay")]
		private bool viewedHideAndSeekHowToPlay;

		public int LastAcceptedPrivacyPolicyVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool ViewedOnlineHelpMessage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ViewedMinPlayerWarning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AlwaysShowMinPlayerWarning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ViewedHideAndSeekHowToPlay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnLastAcceptedPrivacyPolicyVersionChanged
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

		public event Action OnViewedOnlineHelpMessageChanged
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

		public event Action OnViewedMinPlayerWarningChanged
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

		public event Action OnAlwaysShowMinPlayerWarningChanged
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

		public event Action OnViewedHideAndSeekHowToPlay
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
