using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerAgeData : AbstractSaveDataGroup
	{
		public static readonly DateTime DEFAULT_DATE_OF_BIRTH;

		public static readonly DateTime DEFAULT_LATEST_SET_DATE;

		[JsonProperty("dateOfBirth")]
		private DateTime dateOfBirth;

		[JsonProperty("latestSetDate")]
		private DateTime latestSetDate;

		public DateTime DateOfBirth
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public DateTime LatestSetDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public event Action OnDateOfBirthChanged
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

		public event Action OnLatestSetDateChanged
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
