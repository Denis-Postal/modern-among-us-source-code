using System.Collections.Generic;
using Amongus.GameModes.HideAndSeek;
using Hazel;
using UnityEngine;

public class LogicHnSMusic : GameLogicComponent
{
	public enum HideAndSeekMusicTrack
	{
		None = 0,
		Normal = 1,
		Task = 2,
		DangerLevel1 = 3,
		DangerLevel2 = 4
	}

	private HideAndSeekMusicCollection musicCollection;

	private float lastMusicSyncTime;

	private bool isDoingTask;

	private float normalVolume;

	private float taskVolume;

	private float dangerLevel1Volume;

	private float dangerLevel2Volume;

	private AudioSource normalSource;

	private AudioSource taskSource;

	private AudioSource dangerLevel1Source;

	private AudioSource dangerLevel2Source;

	private float musicLerpSpeed;

	private readonly Dictionary<HideAndSeekMusicTrack, string> musicNames;

	public LogicHnSMusic(HideAndSeekManager manager, HideAndSeekMusicCollection music)
		: base(null)
	{
	}

	public override void OnGameStart()
	{
	}

	public override void OnGameEnd()
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

	private void InitMusic()
	{
	}

	public void StartMusicWithIntro()
	{
	}

	public void SetTaskState(bool isDoingTask)
	{
	}

	public override void FixedUpdate()
	{
	}

	private void SyncMusic()
	{
	}

	public void ResetMusic()
	{
	}

	public void SetMusicCrossfadeSpeed(float lerpSpeed)
	{
	}

	public void SetMusicValues(float dangerLevel1, float dangerLevel2)
	{
	}
}
