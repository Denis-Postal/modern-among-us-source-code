using System;
using System.Collections.Generic;
using AmongUs.GameOptions;

namespace AmongUs.Matchmaking
{
	[Serializable]
	public class GameFilterSet
	{
		public GameModes GameMode;

		public List<GameFilter> Filters;

		public GameFilterSet(GameModes mode)
		{
		}

		public GameFilterSet()
		{
		}
	}
}
