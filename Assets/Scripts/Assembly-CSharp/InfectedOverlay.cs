using UnityEngine;

public class InfectedOverlay : MonoBehaviour
{
	public MapRoom[] rooms;

	private IActivatable doors;

	private SabotageSystemType sabSystem;

	public ButtonBehavior[] allButtons;

	public ButtonBehavior selectedButton;

	private const float selectCooldown = 0.5f;

	private float currentCooldown;

	public bool CanUseDoors => false;

	public bool CanUseSabotage => false;

	private bool DoorsPreventingSabotage => false;

	public void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnControlTypeChanged()
	{
	}

	private void DeselectCurrent()
	{
	}

	private void Select(ButtonBehavior newSelected)
	{
	}

	private void SelectClosestButton(Vector2 anchorSpot)
	{
	}

	private void Update()
	{
	}
}
