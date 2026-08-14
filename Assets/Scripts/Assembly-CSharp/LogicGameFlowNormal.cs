using Hazel;

public class LogicGameFlowNormal : LogicGameFlow
{
	public LogicGameFlowNormal(GameManager manager)
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

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}

	protected void EndGameForSabotage()
	{
	}

	public override bool IsGameOverDueToDeath()
	{
		return false;
	}

	public override void CheckEndCriteria()
	{
	}
}
