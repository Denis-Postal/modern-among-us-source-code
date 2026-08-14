using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class GameFilter
	{
		public const string FILTER_TYPE_BOOL = "bool";

		public const string FILTER_TYPE_INT = "int";

		public const string FILTER_TYPE_CATEGORIZED = "cat";

		public const string FILTER_TYPE_MAP = "map";

		public const string FILTER_TYPE_PLATFORM = "platform";

		public const string FILTER_TYPE_CHAT = "chat";

		public const string FILTER_TYPE_LANG = "languages";

		public string OptionType;

		public string Key;

		public string SubFilterString;

		[JsonIgnore]
		public ISubFilter SubFilter { get; private set; }

		public GameFilter(string key, ISubFilter subFilter)
		{
		}

		public void ModifySubFilter(ISubFilter subFilter)
		{
		}

		[JsonConstructor]
		private GameFilter(string optionType, string key, string subFilterString)
		{
		}

		[OnSerializing]
		internal void OnSerializing(StreamingContext context)
		{
		}

		[OnDeserialized]
		internal void OnDeserialized(StreamingContext context)
		{
		}

		private ISubFilter ResolveSubFilter(string type, string filterString)
		{
			return null;
		}
	}
}
