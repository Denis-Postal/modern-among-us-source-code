using Hazel;

public class LogicHnSDeathPopup : GameLogicComponent
{
	private HideAndSeekDeathPopup prefab;

	private int deadPlayerCount;

	public LogicHnSDeathPopup(HideAndSeekManager manager, HideAndSeekDeathPopup deathPopupPrefab)
		: base(null)
	{
	}

	public override void OnGameStart()
	{
	}

	public override void OnGameEnd()
	{
	}

	public override void FixedUpdate()
	{
	}

	public override void OnDestroy()
	{
	}

	public void OnPlayerDeath(PlayerControl player)
	{
	}

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}
}
