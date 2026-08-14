using System;
using System.Collections.Generic;
using Hazel;

namespace InnerNet
{
	public class GameFilterOptions
	{
		public DateTime LastRefreshTime;

		public HashSet<string> FilterTags;

		public void ResetToDefaults(DateTime lastRefreshTime)
		{
		}

		public void Serialize(MessageWriter writer)
		{
		}

		public void Deserialize(MessageReader reader)
		{
		}
	}
}
