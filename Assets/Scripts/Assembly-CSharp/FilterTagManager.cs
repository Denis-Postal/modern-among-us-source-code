using System;
using System.Collections.Generic;

public class FilterTagManager : DestroyableSingleton<FilterTagManager>
{
	private static TimeSpan FilterTagRefreshCooldown;

	private Logger logger;

	public void RefreshTags()
	{
	}

	private void HandleRefreshedTags(HashSet<string> tags)
	{
	}
}
