using System;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class LanguageFilter : ISubFilter
	{
		public uint AcceptedValues;

		public string FilterType { get; }
	}
}
