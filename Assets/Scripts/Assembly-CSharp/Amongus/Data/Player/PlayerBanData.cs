using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerBanData : AbstractSaveDataGroup
	{
		private const int POINTS_UNTIL_BAN_STARTS = 2;

		private const int MINUTES_PER_BAN_POINT = 5;

		[JsonProperty("banPoints")]
		private float banPoints;

		[JsonProperty("previousGameStartDate")]
		private long previousGameStartDate;

		public float BanPoints
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public DateTime PreviousGameStartDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public bool IsBanned => false;

		public float BanMinutes => 0f;

		public int BanMinutesLeft => 0;

		public event Action OnBanPointsChanged
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

		public event Action OnPreviousGameStartedDateChanged
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
