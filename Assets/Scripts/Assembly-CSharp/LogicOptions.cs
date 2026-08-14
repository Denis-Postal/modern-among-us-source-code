using AmongUs.GameOptions;
using Hazel;

public abstract class LogicOptions : GameLogicComponent
{
	private readonly GameOptionsFactory gameOptionsFactory;

	protected abstract IGameOptions currentGameOptions { get; }

	public byte MapId => 0;

	public int MaxPlayers => 0;

	public int NumImpostors => 0;

	public bool IsDefaults => false;

	public LogicOptions(GameManager manager)
		: base(null)
	{
	}

	public virtual int GetAdjustedNumImpostors(int playerCount)
	{
		return 0;
	}

	public virtual void SetRecommendations(int numPlayers, NetworkModes networkMode)
	{
	}

	public void SyncOptions()
	{
	}

	protected abstract void SetGameOptions(IGameOptions newOptions);

	public virtual bool GetGhostsDoTasks()
	{
		return false;
	}

	public virtual float GetKillCooldown()
	{
		return 0f;
	}

	public virtual float GetKillDistance()
	{
		return 0f;
	}

	public virtual float GetPlayerSpeedMod(PlayerControl pc)
	{
		return 0f;
	}

	public virtual bool GetConfirmImpostor()
	{
		return false;
	}

	public virtual int GetEmergencyCooldown()
	{
		return 0;
	}

	public virtual int GetNumEmergencyMeetings()
	{
		return 0;
	}

	public virtual bool GetVisualTasks()
	{
		return false;
	}

	public virtual bool GetAnonymousVotes()
	{
		return false;
	}

	public virtual TaskBarMode GetTaskBarMode()
	{
		return default(TaskBarMode);
	}

	public virtual float GetEngineerCooldown()
	{
		return 0f;
	}

	public virtual float GetEngineerInVentTime()
	{
		return 0f;
	}

	public bool GetRoleBool(BoolOptionNames roleBoolName)
	{
		return false;
	}

	public float GetRoleFloat(FloatOptionNames roleFloatName)
	{
		return 0f;
	}

	public virtual bool GetShowCrewmateNames()
	{
		return false;
	}

	public override bool Serialize(MessageWriter writer)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader)
	{
	}
}
