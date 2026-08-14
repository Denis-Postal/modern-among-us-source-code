using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.InnerNet;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerAnnouncementData : AbstractSaveDataGroup
	{
		[JsonProperty("announcementsRead")]
		private List<int> ids;

		[JsonProperty("latestAnnouncementNumber")]
		private int latestAnnouncementNumber;

		private List<Announcement> allAnnouncements;

		public List<int> AnnouncementsRead
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LatestAnnouncementNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Announcement> AllAnnouncements => null;

		public event Action OnReadAnnouncement
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

		public event Action OnNewAnnouncement
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

		public event Action OnAddAnnouncement
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

		public void AddAnnouncement(Announcement a)
		{
		}

		public void SetAnnouncements(Announcement[] aRange)
		{
		}
	}
}
