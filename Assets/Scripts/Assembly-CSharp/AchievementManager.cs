using System;
using System.Collections.Generic;
using AmongUs.GameOptions;
using Epic.OnlineServices;

public class AchievementManager : DestroyableSingleton<AchievementManager>
{
	private struct AchievementProgressValue
	{
		public string name;

		public int maxProgress;

		public AchievementProgressValue(string achievementName, int achievementMaxProgress)
		{
			name = null;
			maxProgress = 0;
		}
	}

	private const string TasksCompleteEasyKey = "task_complete_easy";

	private const int TasksCompleteEasy = 10;

	private const string TasksCompleteMediumKey = "task_complete_medium";

	private const int TasksCompleteMedium = 100;

	private const string TasksCompleteHardKey = "task_complete_hard";

	private const int TasksCompleteHard = 500;

	private const string CardSwipeFirstTryKey = "card_first_try";

	private const string KillDuringLightsKey = "kill_during_lights";

	private const string NoVentsImpostorWinKey = "no_vents_impostor_win";

	private const string FirstKillKey = "kills_first";

	private const int KillsFirst = 1;

	private const string KillsEasyKey = "kills_easy";

	private const int KillsEasy = 5;

	private const string KillsMediumKey = "kills_medium";

	private const int KillsMedium = 50;

	private const string KillsHardKey = "kills_hard";

	private const int KillsHard = 150;

	private const int MapWins = 3;

	private const string SkeldWinsKey = "wins_skeld";

	private const string MiraWinsKey = "wins_mira";

	private const string PolusWinsKey = "wins_polus";

	private const string AirshipWinsKey = "wins_airship";

	private const string TwoImpsSurviveKey = "survive_two_impostors";

	private const string TasksWinKey = "win_all_tasks";

	private const string SabotageWinKey = "win_sabotage";

	private const string ImpostorKillWinKey = "win_kills";

	private const string ImpostorVoteWinKey = "win_impostor_vote";

	private const string CrewmateSurviveWinKey = "survive_crewmate";

	private const string DieDuringMedScanKey = "die_during_medscan";

	private const string FixOwnSabotageKey = "fix_own_sabotage";

	private const string ThreeKillsBeforeMeetingKey = "three_kills_before_meeting";

	private const string WinAlwaysCorrectVotesKey = "win_always_correct_votes";

	private const string KillWhileDisguisedKey = "kill_while_shifted";

	private const string BlockKillAsGuardianAngelKey = "block_kill_as_guardian";

	private const string StatNameImpostorKills = "impostorKills";

	private const string StatNameTasksCompleted = "tasksCompleted";

	private const string StatNameMapWinsSkeld = "MapWinsSkeld";

	private const string StatNameMapWinsPolus = "MapWinsPolus";

	private const string StatNameMapWinsMira = "MapWinsMira";

	private const string StatNameMapWinsAirship = "MapWinsAirship";

	private const string HnSCrewmateSurviveWinKey = "hns_survive_crewmate";

	private const string HnSImpostorKillAllKey = "hns_impostor_kill_all";

	private const string HnSCompleteAllTasksKey = "hns_complete_all_tasks";

	private const string HnSCrewmateWinsEasyKey = "hns_crewmate_wins_easy";

	private const int HnSCrewmateWinsEasy = 10;

	private const string HnSCrewmateWinsHardKey = "hns_crewmate_wins_hard";

	private const int HnSCrewmateWinsHard = 50;

	private const string HnSImpostorKillsEasyKey = "hns_impostor_kills_easy";

	private const int HnSImpostorKillsEasy = 100;

	private const string HnSImpostorKillsHardKey = "hns_impostor_kills_hard";

	private const int HnSImpostorKillsHard = 200;

	private const string StatNameHnSCrewmateWin = "hnsCrewmateWin";

	private const string StatNameHnSImpostorKill = "hnsImpostorKills";

	public static readonly Dictionary<string, List<GameModes>> AchievementGameModeKey;

	public static readonly Dictionary<string, List<GameModes>> StatsGameModeKey;

	private readonly Logger logger;

	private bool gameStarted;

	private RoleTypes myRole;

	private int cardSwipesThisMatch;

	private int ventsUsedThisMatch;

	private bool meetingCalledThisMatch;

	private int killsThisMatch;

	private bool sabotageCalledLocally;

	private int timesVoted;

	private int timesVotedForImp;

	private int winMap;

	private Dictionary<string, List<AchievementProgressValue>> statName2AchievementProgressValues;

	public override void Awake()
	{
	}

	private void InitializeAchievementProgressDictionary()
	{
	}

	public void UpdateAchievementsAndStats()
	{
	}

	public void QueryStats(Action callback)
	{
	}

	public void OnMatchStart(RoleTypes myRole)
	{
	}

	public void SetWinMap(int mapIndex)
	{
	}

	public void OnMatchExited()
	{
	}

	public void OnMatchEnd(GameOverReason reason, bool didWin)
	{
	}

	public void OnConsoleUse(IUsable console)
	{
	}

	public void SabotageCalledLocally()
	{
	}

	public void OnSabotageCleared()
	{
	}

	public void OnSabotageFixed(bool didContribute)
	{
	}

	public void OnMurder(bool amKiller, bool amVictim, bool isShapeShifted, int shapeshiftTargetId, int victimId)
	{
	}

	public void OnMeetingCalled()
	{
	}

	public void OnProtectACrewmate()
	{
	}

	public void OnMeetingVote(NetworkedPlayerInfo self, NetworkedPlayerInfo target)
	{
	}

	public void OnTaskComplete(TaskTypes taskType)
	{
	}

	public void OnTaskFailure(TaskTypes taskType)
	{
	}

	public void QueryAndLogAchievementProgress(string achievementKey = null)
	{
	}

	private bool IsTaskOpen(TaskTypes taskType)
	{
		return false;
	}

	private bool TryGetSystemOfType<T>(SystemTypes sysType, out T output) where T : class, ISystemType
	{
		output = null;
		return false;
	}

	private void CopyAndLogPlayerAchievementProgress(string key, ProductUserId userId)
	{
	}

	private void UpdateAchievementProgress(string statName, int progress)
	{
	}

	private void UnlockAchievement(string key)
	{
	}

	public void UpdateAchievementProgressImpl(string key, int progress, int total)
	{
	}

	public void UnlockAchievementImpl(string key)
	{
	}
}
