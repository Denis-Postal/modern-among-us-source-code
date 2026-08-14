using System.Collections.Generic;

public class Win10Manager : DestroyableSingleton<Win10Manager>
{
	private Dictionary<string, ulong> puid2xuid;

	private List<KeyValuePair<string, ulong>> xUIDsToCheckIfBlocked;

	private HashSet<string> nonXuids;
}
