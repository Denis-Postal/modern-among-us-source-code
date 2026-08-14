using Rewired;
using UnityEngine;

public class PlacePartsMinigame : Minigame
{
	[SerializeField]
	private DraggablePart[] draggableParts;

	[SerializeField]
	private DraggablePartFixed[] draggableFixedParts;

	[SerializeField]
	private SpriteRenderer hand;

	[SerializeField]
	private Sprite openHand;

	[SerializeField]
	private Sprite closeHand;

	private readonly Controller controller;

	[SerializeField]
	[Header("Audio")]
	private AudioClip[] pickUpPartSfx;

	[SerializeField]
	private AudioClip[] resetPartSfx;

	[SerializeField]
	private AudioClip[] scrapOldPartSfx;

	[SerializeField]
	private AudioClip[] attachPartSfx;

	private DraggablePart selectedPart;

	private DraggablePartFixed selectedFixedPart;

	private int placedParts;

	private Player gamepad;

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

	private void SetHand(bool isGrabbing)
	{
	}

	private void OnNewPartPlaced()
	{
	}

	private void OnNewPartReset()
	{
	}

	private void OnOldPartRemoved()
	{
	}

	private void OnOldPartReset()
	{
	}

	private void OnInputMethodChanged()
	{
	}

	private void UpdateCursorVisibility()
	{
	}
}
