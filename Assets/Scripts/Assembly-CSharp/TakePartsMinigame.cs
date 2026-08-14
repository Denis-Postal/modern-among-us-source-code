using UnityEngine;

public class TakePartsMinigame : Minigame
{
	[SerializeField]
	private PassiveButton[] parts;

	[SerializeField]
	private GameObject[] inventoryParts;

	[SerializeField]
	private PassiveButton boxLid;

	[SerializeField]
	private GameObject boxOpen;

	[SerializeField]
	private GameObject hand;

	[SerializeField]
	[Header("Audio")]
	private AudioClip openToolboxSfx;

	[SerializeField]
	private AudioClip[] pickUpSfx;

	private readonly Controller controller;

	private int partsTaken;

	public override bool SkipMultistageOverlayMenuSetup => false;

	private void Update()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	public override void Close()
	{
	}

	private void OnToolboxOpen()
	{
	}

	private void SavePart()
	{
	}

	private void OnInputMethodChanged()
	{
	}

	private void UpdateCursorVisibility()
	{
	}
}
