using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MushroomDoorSabotageMinigame : Minigame, IDoorMinigame
{
	private const int NUM_IMMEDIATELY_VISIBLE_MUSHROOMS = 3;

	private const int NUM_DELAYED_MUSHROOMS = 3;

	private const int TOTAL_MUSHROOM_COUNT = 6;

	[Header("Design")]
	[SerializeField]
	private FloatRange mushroomInvisibleSeconds;

	[SerializeField]
	private FloatRange mushroomVisibleSeconds;

	[SerializeField]
	private TextMeshPro counterText;

	[SerializeField]
	[Header("Objects")]
	private Transform[] spawnPoints;

	[SerializeField]
	private MushroomDoorSabotageMinigameMushroom[] mushroomVariants;

	private OpenableDoor myDoor;

	private int mushroomWhackCount;

	private List<Transform> spawnPointBag;

	private List<MushroomDoorSabotageMinigameMushroom> mushrooms;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public void SetDoor(OpenableDoor door)
	{
	}

	private void SetCounterText(int whackedCount)
	{
	}

	private void UpdateMushroomWhackCount(MushroomDoorSabotageMinigameMushroom mushroom)
	{
	}

	private void FixDoorAndCloseMinigame()
	{
	}
}
