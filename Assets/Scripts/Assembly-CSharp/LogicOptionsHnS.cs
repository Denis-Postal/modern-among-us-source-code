using System.Collections.Generic;
using AmongUs.GameOptions;

public class LogicOptionsHnS : LogicOptions
{
	private const float CommonShortTaskTime = 5f;

	private const float LongTaskTime = 10f;

	private const float TaskTimePlayerDelta = 1f;

	private HideNSeekGameOptionsV10 GameOptions;

	private HideAndSeekManager HnSManager;

	public float PlayerSpeedBase => 0f;

	protected override IGameOptions currentGameOptions => null;

	public LogicOptionsHnS(HideAndSeekManager manager)
		: base(null)
	{
	}

	public override float GetPlayerSpeedMod(PlayerControl pc)
	{
		return 0f;
	}

	public override float GetKillDistance()
	{
		return 0f;
	}

	public override float GetEngineerCooldown()
	{
		return 0f;
	}

	public override float GetEngineerInVentTime()
	{
		return 0f;
	}

	public int GetCrewmateLeadTime()
	{
		return 0;
	}

	public float GetEscapeTime()
	{
		return 0f;
	}

	public float GetFinalCountdownTime()
	{
		return 0f;
	}

	public int GetCrewmateVentUses()
	{
		return 0;
	}

	public float GetScaryMusicDistance()
	{
		return 0f;
	}

	public float GetVeryScaryMusicDistance()
	{
		return 0f;
	}

	public float GetCrewmateInVentTime()
	{
		return 0f;
	}

	public float GetCrewmateVentCooldown()
	{
		return 0f;
	}

	public float GetCommonTaskTimeValue()
	{
		return 0f;
	}

	public float GetShortTaskTimeValue()
	{
		return 0f;
	}

	public float GetLongTaskTimeValue()
	{
		return 0f;
	}

	public bool GetSeekerFinalMap()
	{
		return false;
	}

	public int ImpostorPlayerID()
	{
		return 0;
	}

	public bool HasImpostorPlayerID()
	{
		return false;
	}

	public bool ValidateImpostorPlayerID(List<NetworkedPlayerInfo> players)
	{
		return false;
	}

	public bool GetSeekerPings()
	{
		return false;
	}

	public float GetMaxPingTime()
	{
		return 0f;
	}

	public float GetShowPingTime()
	{
		return 0f;
	}

	public override bool GetShowCrewmateNames()
	{
		return false;
	}

	public override TaskBarMode GetTaskBarMode()
	{
		return default(TaskBarMode);
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

	public override bool GetGhostsDoTasks()
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

	protected override void SetGameOptions(IGameOptions newOptions)
	{
	}
}
