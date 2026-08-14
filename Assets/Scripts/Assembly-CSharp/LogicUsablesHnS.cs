using Hazel;

public class LogicUsablesHnS : LogicUsables
{
	private HideAndSeekManager HnSManager;

	public LogicUsablesHnS(HideAndSeekManager manager)
		: base(null)
	{
	}

	public override bool CanUse(IUsable usable, PlayerControl player)
	{
		return false;
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

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}
}
