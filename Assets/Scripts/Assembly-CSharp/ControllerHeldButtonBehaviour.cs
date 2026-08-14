using Rewired;
using UnityEngine;

public class ControllerHeldButtonBehaviour : MonoBehaviour
{
	public RewiredConstsEnum.Action Action;

	public SpriteRenderer targetCooldownSprite;

	public float holdDuration;

	public ActionButton TargetActionButton;

	private Player player;

	private ButtonBehavior buttonBehavior;

	private PassiveButton passiveButton;

	private float holdTimer;

	private bool alreadyPressed;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
