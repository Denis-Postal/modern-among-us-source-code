using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class DetectiveRole : CrewmateRole
{
	[SerializeField]
	private GameObject notesPrefab;

	[SerializeField]
	private GameObject inspectionGraphic;

	[SerializeField]
	private GameObject abilityInfoPrefab;

	[SerializeField]
	private AudioClip interrogateSFX;

	private int currentNotesIndex;

	public List<DetectiveNotesPageInfo> notesPageInfos;

	private DetectiveNotesMinigame notesMinigame;

	private List<NetworkedPlayerInfo> deadPlayers;

	private DetectiveAbilityInfo abilityInfo;

	private DetectiveAbilityInfo meetingAbilityInfo;

	[SerializeField]
	private PlayerControl currentTarget;

	[Header("Ship Locations")]
	[SerializeField]
	private GameObject skeldShipLocationsPrefab;

	[SerializeField]
	private GameObject miraShipLocationsPrefab;

	[SerializeField]
	private GameObject polusShipLocationsPrefab;

	[SerializeField]
	private GameObject airshipShipLocationsPrefab;

	[SerializeField]
	private GameObject fungleShipLocationsPrefab;

	private float cooldownSecondsRemaining;

	private bool IsCoolingDown => false;

	public override void Initialize(PlayerControl player)
	{
	}

	public override void UseAbility()
	{
	}

	public override void UseSecondaryAbility()
	{
	}

	private void Interrogate()
	{
	}

	private void AddVictimToNotes(NetworkedPlayerInfo playerInfo)
	{
	}

	private void OpenNotes(NetworkedPlayerInfo victimPlayer = null, bool openInterface = true)
	{
	}

	public override void SetPlayerTarget(PlayerControl target)
	{
	}

	private void ClearPlayerTarget()
	{
	}

	public override PlayerControl FindClosestTarget()
	{
		return null;
	}

	protected override float GetAbilityDistance()
	{
		return 0f;
	}

	private void FixedUpdate()
	{
	}

	public override void OnMeetingStart()
	{
	}

	private void SetAbilityInfo(NetworkedPlayerInfo playerInfo)
	{
	}

	public override void OnVotingComplete()
	{
	}

	private void UpdateDeadPlayers()
	{
	}

	public bool PlayerWasDead(DetectiveSuspect playerInfo)
	{
		return false;
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}

	public void SetCurrentIndex(int _index)
	{
	}

	public override void KillAnimSpecialSetup(DeadBody deadBody, PlayerControl killer, PlayerControl victim)
	{
	}

	private void CreatePlayerLocations(DetectiveDeadBodyInfo deadBodyInfo)
	{
	}

	public string GetPlayerLocation(byte playerID, byte victimID)
	{
		return null;
	}

	private void CreateMapLocations()
	{
	}

	public override void OnDeath(DeathReason reason)
	{
	}

	public override void OnRoleSet()
	{
	}
}
