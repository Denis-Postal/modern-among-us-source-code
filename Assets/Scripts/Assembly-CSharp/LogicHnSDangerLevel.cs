using System.Collections.Generic;
using Hazel;

public class LogicHnSDangerLevel : GameLogicComponent
{
	private DangerMeter dangerMeter;

	private List<PlayerControl> impostors;

	private float scaryMusicDistance;

	private float veryScaryMusicDistance;

	private float dangerLevel1;

	private float dangerLevel2;

	private HideAndSeekManager hnsManager;

	private bool firstMusicActivation;

	private float firstCrossfadeCountdown;

	public LogicHnSDangerLevel(HideAndSeekManager manager)
		: base(null)
	{
	}

	public override void OnGameStart()
	{
	}

	public override void OnPlayerDisconnect(PlayerControl pc)
	{
	}

	public override void OnGameEnd()
	{
	}

	public override void FixedUpdate()
	{
	}

	private void UpdateDangerMusic()
	{
	}

	private void UpdateDangerMeter()
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
