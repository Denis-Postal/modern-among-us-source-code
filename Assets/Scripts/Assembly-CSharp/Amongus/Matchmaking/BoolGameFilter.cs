using System;
using System.Collections.Generic;
using AmongUs.GameOptions;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class BoolGameFilter : ISubFilter
	{
		public List<bool> AcceptedValues;

		public BoolOptionNames OptionEnum;

		public string FilterType { get; }
	}
}
