using System;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class ChatModeGameFilter : ISubFilter
	{
		public byte AcceptedValues;

		public string FilterType { get; }
	}
}
