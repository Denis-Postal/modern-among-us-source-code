using System.Collections.Generic;
using UnityEngine;

public class CollectShellsMinigame : Minigame
{
	[SerializeField]
	private CollectableShell[] shellPrefabs;

	[SerializeField]
	private Transform[] spawnPositions;

	[SerializeField]
	private IntRange numShellsRange;

	[SerializeField]
	private GameObject controllerCursor;

	[SerializeField]
	private GameObject handWipeObject;

	[Header("Audio")]
	[SerializeField]
	private AudioClip[] dustSounds;

	private List<CollectableShell> shells;

	private Controller controller;

	private Vector2 prevMousePos;

	private Vector2 prevControllerStickPos;

	private float wipeDistance;

	private float maxProgress;

	private float controllerDifficulty;

	private float mouseDifficulty;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	private void UpdateTouch()
	{
	}

	private void UpdateController()
	{
	}

	private void WipeSand(PassiveButton sand, SpriteRenderer sprite, float diff)
	{
	}

	private void OnSandCleared()
	{
	}
}
