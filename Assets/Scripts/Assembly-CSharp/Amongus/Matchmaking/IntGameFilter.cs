using System;
using System.Collections.Generic;
using AmongUs.GameOptions;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class IntGameFilter : ISubFilter
	{
		public List<int> AcceptedValues;

		public Int32OptionNames OptionEnum;

		public string FilterType { get; }
	}
}
