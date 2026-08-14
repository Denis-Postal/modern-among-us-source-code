public class MeetingRoomManager : IDisconnectHandler
{
	public static readonly MeetingRoomManager Instance;

	private PlayerControl reporter;

	private NetworkedPlayerInfo target;

	public bool IsPersistent => false;

	public void AssignSelf(PlayerControl reporter, NetworkedPlayerInfo target)
	{
	}

	public void RemoveSelf()
	{
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}
}
