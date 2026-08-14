using AmongUs.GameOptions;

public class LogicOptionsNormal : LogicOptions
{
	private NormalGameOptionsV10 GameOptions;

	protected override IGameOptions currentGameOptions => null;

	public LogicOptionsNormal(GameManager manager)
		: base(null)
	{
	}

	public int GetDiscussionTime()
	{
		return 0;
	}

	public int GetVotingTime()
	{
		return 0;
	}

	public override int GetEmergencyCooldown()
	{
		return 0;
	}

	public override int GetNumEmergencyMeetings()
	{
		return 0;
	}

	public override bool GetVisualTasks()
	{
		return false;
	}

	public override bool GetAnonymousVotes()
	{
		return false;
	}

	public override bool GetConfirmImpostor()
	{
		return false;
	}

	public override TaskBarMode GetTaskBarMode()
	{
		return default(TaskBarMode);
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

	protected override void SetGameOptions(IGameOptions newOptions)
	{
	}
}
