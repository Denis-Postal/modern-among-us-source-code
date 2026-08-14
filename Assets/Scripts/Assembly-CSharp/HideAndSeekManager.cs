using Amongus.GameModes.HideAndSeek;
using TMPro;
using UnityEngine;

public class HideAndSeekManager : GameManager
{
	public LogicHnSMusic LogicMusic;

	public LogicGameFlowHnS LogicFlowHnS;

	public LogicOptionsHnS LogicOptionsHnS;

	public LogicHnSDangerLevel LogicDangerLevel;

	public LogicPingsHnS LogicPing;

	public LogicHnSDeathPopup LogicDeathPopup;

	public AudioClip FinalHideAlertSFX;

	public AudioClip FinalHideCountdownSFX;

	[SerializeField]
	private HideAndSeekTimerBar TimerBarPrefab;

	[SerializeField]
	private HideAndSeekDeathPopup DeathPopupPrefab;

	[SerializeField]
	private HideAndSeekMusicCollection MusicCollection;

	[SerializeField]
	private AudioClip TaskFinishedSound;

	[SerializeField]
	private ObjectPoolBehavior PingPool;

	[SerializeField]
	private Sprite BrokenEmergencyButton;

	[SerializeField]
	private DeadBody horseBody;

	private TextMeshPro someoneJustDiedText;

	private NetworkedPlayerInfo.PlayerOutfit horseWranglerOutfit;

	public override void InitComponents()
	{
	}

	public override void StartGame()
	{
	}

	public override PlayerBodyTypes GetBodyType(PlayerControl player)
	{
		return default(PlayerBodyTypes);
	}

	public override void OnPlayerDeath(PlayerControl player, bool assignGhostRole)
	{
	}

	protected override void FixedUpdate()
	{
	}

	protected override void OnPlayerDisconnect(PlayerControl pc)
	{
	}

	public override void FinishTask(PlayerTask task)
	{
	}

	public override void EndGame()
	{
	}

	public override void OnDestroy()
	{
	}

	public override bool DidHumansWin(GameOverReason reason)
	{
		return false;
	}

	public override bool DidImpostorsWin(GameOverReason reason)
	{
		return false;
	}

	public override MapOptions GetMapOptions()
	{
		return null;
	}

	private void CheckUpdateSurvivedStat()
	{
	}

	private void CheckUpdateGameTimeStats()
	{
	}

	public override bool CanReportBodies()
	{
		return false;
	}

	public override bool SabotagesEnabled()
	{
		return false;
	}

	public override bool IsHideAndSeek()
	{
		return false;
	}

	public override void SetSpecialCosmetics(PlayerControl p)
	{
	}

	public override DeadBody GetDeadBody(RoleBehaviour impostorRole)
	{
		return null;
	}
}
