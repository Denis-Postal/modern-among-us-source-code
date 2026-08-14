using TMPro;
using UnityEngine;

public class HauntMenuMinigame : Minigame
{
	private enum HauntFilters
	{
		None = 0,
		Impostor = 1,
		Crewmate = 2,
		Ghost = 3
	}

	private const float MinVelMultiplier = 0.75f;

	private const float MaxVelMultiplier = 4f;

	private const float MinDistance = 0.05f;

	private const float MinOffset = 0.2f;

	private const float MaxOffset = 0.5f;

	private const float Damping = 0.7f;

	private const float Easing = 0.2f;

	[SerializeField]
	private TextMeshPro NameText;

	[SerializeField]
	private TextMeshPro FilterText;

	[SerializeField]
	private TextMeshPro HauntingText;

	private HauntFilters filterMode;

	[SerializeField]
	private PassiveButton[] FilterButtons;

	[SerializeField]
	private PassiveButton[] Arrows;

	private PlayerControl HauntTarget;

	private Vector2 Offset;

	private void Start()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetFilter(int filterInt)
	{
	}

	private void SetFilterText()
	{
	}

	public void ChangePick(int direction)
	{
	}

	private bool MatchesFilter(PlayerControl pc)
	{
		return false;
	}

	private void SetHauntTarget(PlayerControl target)
	{
	}

	public override void Close()
	{
	}
}
