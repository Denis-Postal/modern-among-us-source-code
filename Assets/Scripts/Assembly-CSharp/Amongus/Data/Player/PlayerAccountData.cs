using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerAccountData : AbstractSaveDataGroup
	{
		public const EOSManager.AccountLoginStatus DEFAULT_LOGIN_STATUS = EOSManager.AccountLoginStatus.Offline;

		public const string DEFAULT_GUARDIAN_EMAIL = "";

		public const bool DEFAULT_DELETE_DEVICE_ID_FAILED = false;

		[JsonProperty("loginStatus")]
		private EOSManager.AccountLoginStatus loginStatus;

		[JsonProperty("guardianEmail")]
		private string guardianEmail;

		[JsonProperty("deleteDeviceIDFailed")]
		private bool deleteDeviceIDFailed;

		public EOSManager.AccountLoginStatus LoginStatus
		{
			get
			{
				return default(EOSManager.AccountLoginStatus);
			}
			set
			{
			}
		}

		public string GuardianEmail
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool DeleteDeviceIDFailed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnLoginStatusChanged
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

		public event Action OnGuardianEmailChanged
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

		public event Action OnDeleteDeviceIDFailedChanged
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
