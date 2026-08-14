public abstract class LogicUsables : GameLogicComponent
{
	public LogicUsables(GameManager manager)
		: base(null)
	{
	}

	public abstract bool CanUse(IUsable usable, PlayerControl player);
}
