using System;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class MapGameFilter : ISubFilter
	{
		public byte AcceptedValues;

		public string FilterType { get; }
	}
}
