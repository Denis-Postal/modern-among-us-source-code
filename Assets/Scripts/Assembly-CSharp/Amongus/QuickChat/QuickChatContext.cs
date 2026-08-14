using AmongUs.GameOptions;

namespace AmongUs.QuickChat
{
	public class QuickChatContext
	{
		private static readonly StringNames[] TASKS_TO_IGNORE;

		private static readonly RoleTypes[] ROLES_TO_IGNORE;

		private QuickChatData data;

		private PlayerControl localPlayer;

		private PlayerControl[] players;

		private PlayerControl[] deadPlayers;

		private StringNames[] locations;

		private StringNames[] roles;

		private StringNames[] systems;

		private StringNames[] tasks;

		private QuickChatContextPhase phase;

		private GameModes gameMode;

		private MapNames map;

		private int meetingCount;

		public QuickChatData Data => null;

		public PlayerControl[] Players => null;

		public PlayerControl[] DeadPlayers => null;

		public StringNames[] Locations => null;

		public StringNames[] Roles => null;

		public StringNames[] Systems => null;

		public StringNames[] Tasks => null;

		public QuickChatContextPhase Phase => default(QuickChatContextPhase);

		public GameModes GameMode => default(GameModes);

		public MapNames Map => default(MapNames);

		public int MeetingCount => 0;

		public static QuickChatContext Current(QuickChatData data)
		{
			return null;
		}

		public QuickChatContext(QuickChatData data)
		{
		}

		private void UpdateToCurrent()
		{
		}

		private void UpdateWithCurrentLobby()
		{
		}

		private void UpdateWithCurrentMap()
		{
		}

		private MapNames GetCurrentMapID(ShipStatus ship)
		{
			return default(MapNames);
		}

		public bool HasPlayersWithRole(RoleTypes role)
		{
			return false;
		}
	}
}
