using System;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class PlatformGameFilter : ISubFilter
	{
		public uint AcceptedValues;

		public string FilterType { get; }
	}
}
