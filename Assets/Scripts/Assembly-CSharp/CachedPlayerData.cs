using AmongUs.GameOptions;

public class CachedPlayerData
{
	public readonly string PlayerName;

	public readonly NetworkedPlayerInfo.PlayerOutfit Outfit;

	public readonly bool IsYou;

	public readonly bool IsImpostor;

	public readonly bool IsDead;

	public readonly RoleTypes RoleWhenAlive;

	public int ColorId => 0;

	public string SkinId => null;

	public string PetId => null;

	public string HatId => null;

	public string VisorId => null;

	public string NamePlateId => null;

	public CachedPlayerData(NetworkedPlayerInfo player)
	{
	}
}
