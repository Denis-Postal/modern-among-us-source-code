using System.Collections.Generic;
using Hazel;
using UnityEngine;

public class MushroomMixupSabotageSystem : MonoBehaviour, ISystemType, IActivatable
{
	public enum Operation
	{
		None = 0,
		TriggerSabotage = 1
	}

	private enum State
	{
		Inactive = 0,
		JustTriggered = 1,
		IdleButMixedUp = 2
	}

	private struct CondensedOutfit
	{
		public byte HatIndex;

		public byte VisorIndex;

		public byte SkinIndex;

		public byte PetIndex;

		public byte ColorPlayerId;

		public void Serialize(MessageWriter writer)
		{
		}

		public void Deserialize(MessageReader reader)
		{
		}
	}

	private const float SYNC_RATE = 2f;

	private const float VIBRATION_INTENSITY = 0.3f;

	[Range(0f, 1f)]
	[SerializeField]
	[Header("Cosmetics")]
	private float skinEmptyChance;

	private List<string> skinIds;

	[Range(0f, 1f)]
	[SerializeField]
	private float hatEmptyChance;

	[SerializeField]
	private string[] hatIds;

	[SerializeField]
	[Range(0f, 1f)]
	private float visorEmptyChance;

	[SerializeField]
	private string[] visorIds;

	[SerializeField]
	[Range(0f, 1f)]
	private float petEmptyChance;

	[SerializeField]
	private string[] petIds;

	[SerializeField]
	[Header("Healing")]
	private float secondsForAutoHeal;

	[SerializeField]
	[Header("Animations")]
	private MushroomMixupScreenTint screenTint;

	[SerializeField]
	private MushroomMixupPlayerAnimation playerAnimationPrefab;

	[SerializeField]
	private AudioClip activateSfx;

	[SerializeField]
	private AudioClip deactivateSfx;

	private readonly Dictionary<byte, CondensedOutfit> currentMixups;

	private readonly Dictionary<byte, NetworkedPlayerInfo.PlayerOutfit> cachedOutfitsByPlayerId;

	private readonly Dictionary<byte, NetworkedPlayerInfo.PlayerOutfit> deadAndDcPlayerOutfitsByPlayerId;

	private State currentState;

	private float currentSecondsUntilHeal;

	private float syncTimer;

	public bool IsDirty { get; private set; }

	public bool IsActive => false;

	public float CurrentSecondsUntilHeal => 0f;

	private void Start()
	{
	}

	private void PopulateSkinsFromPlayers()
	{
	}

	public void Deteriorate(float deltaTime)
	{
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	private void MushroomMixUp()
	{
	}

	private void Host_GenerateRandomOutfits()
	{
	}

	private void UpdatePlayerOutfits()
	{
	}

	public void MarkClean()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	private bool AllPlayersHaveData()
	{
		return false;
	}

	private CondensedOutfit GenerateRandomOutfit(int playerId)
	{
		return default(CondensedOutfit);
	}

	private NetworkedPlayerInfo.PlayerOutfit ConvertToPlayerOutfit(CondensedOutfit condensedOutfit)
	{
		return null;
	}
}
