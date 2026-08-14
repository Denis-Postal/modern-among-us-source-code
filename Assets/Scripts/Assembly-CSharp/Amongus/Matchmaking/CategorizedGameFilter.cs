using System;
using System.Collections.Generic;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class CategorizedGameFilter : ISubFilter
	{
		public List<int> AcceptedValues;

		public CategorizedOptionNames OptionEnum;

		public string FilterType { get; }
	}
}
