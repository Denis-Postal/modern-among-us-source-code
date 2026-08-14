using System.Collections.Generic;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerFriendData : AbstractSaveDataGroup
	{
		[JsonObject(MemberSerialization.OptIn)]
		public class CachedName
		{
			[JsonProperty("id")]
			private string puid;

			[JsonProperty("name")]
			private string name;

			public string PUID => null;

			public string Name => null;

			public CachedName(string puid, string name)
			{
			}

			public void ChangeName(string newName)
			{
			}
		}

		[JsonProperty("names")]
		private List<CachedName> cachedNames;

		public string GetCachedName(string puid)
		{
			return null;
		}

		public void UpdateCachedName(string puid, string name)
		{
		}
	}
}
