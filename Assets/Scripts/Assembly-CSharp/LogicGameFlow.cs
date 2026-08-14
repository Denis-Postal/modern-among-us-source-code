public abstract class LogicGameFlow : GameLogicComponent
{
	public LogicGameFlow(GameManager manager)
		: base(null)
	{
	}

	public abstract void CheckEndCriteria();

	public abstract bool IsGameOverDueToDeath();

	protected (int, int, int) GetPlayerCounts()
	{
		return default((int, int, int));
	}
}
