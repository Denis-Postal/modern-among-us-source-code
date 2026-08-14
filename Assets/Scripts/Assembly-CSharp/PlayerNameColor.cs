using TMPro;
using UnityEngine;

public static class PlayerNameColor
{
	public static Color Get(NetworkedPlayerInfo pc)
	{
		return default(Color);
	}

	public static void Set(PlayerControl pc)
	{
	}

	public static void Set(NetworkedPlayerInfo playerInfo, TextMeshPro name)
	{
	}

	public static void SetForRoleDirectly(PlayerControl player, RoleBehaviour role)
	{
	}

	private static Color Get(RoleBehaviour otherPlayerRole)
	{
		return default(Color);
	}

	private static void Set(PlayerControl otherPlayer, RoleBehaviour otherPlayerRole)
	{
	}

	private static void Set(TextMeshPro nameText, RoleBehaviour otherPlayerRole)
	{
	}
}
