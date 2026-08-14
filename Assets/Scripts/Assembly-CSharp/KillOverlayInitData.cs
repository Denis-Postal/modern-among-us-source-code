public class KillOverlayInitData
{
	public NetworkedPlayerInfo.PlayerOutfit killerOutfit;

	public PlayerBodyTypes killerBodyType;

	public NetworkedPlayerInfo.PlayerOutfit victimOutfit;

	public PlayerBodyTypes victimBodyType;

	public KillOverlayInitData(NetworkedPlayerInfo.PlayerOutfit killerOutfit, PlayerBodyTypes killerBodyType, NetworkedPlayerInfo.PlayerOutfit victimOutfit, PlayerBodyTypes victimBodyType)
	{
	}

	public KillOverlayInitData(NetworkedPlayerInfo killer, NetworkedPlayerInfo victim)
	{
	}
}
