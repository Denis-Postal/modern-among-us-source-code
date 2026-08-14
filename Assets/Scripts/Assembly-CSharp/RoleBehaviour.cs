using System.Collections.Generic;
using System.Text;
using AmongUs.GameOptions;
using Hazel;
using UnityEngine;

public abstract class RoleBehaviour : MonoBehaviour
{
	public RoleTypes Role;

	public StringNames StringName;

	public StringNames BlurbName;

	public StringNames BlurbNameMed;

	public StringNames BlurbNameLong;

	public Sprite RoleIconSolid;

	public Sprite RoleIconWhite;

	public Sprite RoleScreenshot;

	public Color NameColor;

	public bool TasksCountTowardProgress;

	public bool CanUseKillButton;

	public bool CanBeKilled;

	public bool CanVent;

	public bool AffectedByLightAffectors;

	public int MaxCount;

	public RoleTeamTypes TeamType;

	public AbilityButtonSettings Ability;

	public AbilityButtonSettings SecondaryAbility;

	public RoleTypes DefaultGhostRole;

	public AudioClip UseSound;

	public AudioClip IntroSound;

	public List<BaseGameSetting> AllGameSettings;

	public OverlayKillAnimation[] CustomKillAnimations;

	protected PlayerControl Player;

	protected AbilityButton buttonManager;

	protected SecondaryAbilityButton secondaryButtonManager;

	private static List<PlayerControl> tempPlayerList;

	private static List<DeadBody> tempBodyList;

	public bool IsImpostor => false;

	public abstract bool IsDead { get; }

	public string NiceName => null;

	public string Blurb => null;

	public string BlurbMed => null;

	public string BlurbLong => null;

	public bool IsSimpleRole => false;

	public Color TeamColor => default(Color);

	public virtual bool IsAffectedByComms => false;

	protected bool CommsSabotaged => false;

	protected static void AppendTaskHint(RoleBehaviour role, StringBuilder taskStringBuilder)
	{
	}

	public virtual bool CanUse(IUsable console)
	{
		return false;
	}

	public virtual bool DidWin(GameOverReason gameOverReason)
	{
		return false;
	}

	public virtual void Deinitialize(PlayerControl targetPlayer)
	{
	}

	public virtual void SpawnTaskHeader(PlayerControl playerControl)
	{
	}

	public virtual void UseAbility()
	{
	}

	public virtual void UseSecondaryAbility()
	{
	}

	public virtual void OnMeetingStart()
	{
	}

	public virtual void OnVotingComplete()
	{
	}

	public virtual void OnDeath(DeathReason reason)
	{
	}

	public virtual void OnRoleSet()
	{
	}

	public virtual void Initialize(PlayerControl player)
	{
	}

	public virtual void SetUsableTarget(IUsable target)
	{
	}

	public virtual void SetPlayerTarget(PlayerControl target)
	{
	}

	public virtual void SetCooldown()
	{
	}

	protected void InitializeMeetingAbilityButton()
	{
	}

	private void InitializeAbilityButton()
	{
	}

	private void InitializeSecondaryAbilityButton()
	{
	}

	private void SetAbilityUsesRemaining(int num)
	{
	}

	protected virtual bool IsValidTarget(NetworkedPlayerInfo target)
	{
		return false;
	}

	public virtual PlayerControl FindClosestTarget()
	{
		return null;
	}

	public virtual DeadBody FindClosestBody()
	{
		return null;
	}

	protected virtual float GetAbilityDistance()
	{
		return 0f;
	}

	protected static List<PlayerControl> GetTempPlayerList()
	{
		return null;
	}

	public List<PlayerControl> GetPlayersInAbilityRangeSorted(List<PlayerControl> outputList)
	{
		return null;
	}

	protected List<PlayerControl> GetPlayersInAbilityRangeSorted(List<PlayerControl> outputList, bool ignoreColliders)
	{
		return null;
	}

	protected static List<DeadBody> GetTempBodyList()
	{
		return null;
	}

	public List<DeadBody> GetBodiesInAbilityRangeSorted(List<DeadBody> outputList)
	{
		return null;
	}

	private List<DeadBody> GetBodiesInAbilityRangeSorted(List<DeadBody> outputList, bool ignoreColliders)
	{
		return null;
	}

	public virtual void AdjustTasks(PlayerControl player)
	{
	}

	public virtual void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}

	public virtual void HandleRoleRpc(byte callId, MessageReader reader)
	{
	}

	public virtual void KillAnimSpecialSetup(DeadBody deadBody, PlayerControl killer, PlayerControl victim)
	{
	}
}
