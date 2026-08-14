using System.Collections.Generic;
using UnityEngine;

public class BurgerMinigame : Minigame
{
	public BurgerTopping Plate;

	public BurgerTopping[] Toppings;

	public Sprite[] PaperToppings;

	public SpriteRenderer[] PaperSlots;

	private BurgerToppingTypes[] ExpectedToppings;

	private Stack<BurgerTopping> burger;

	private Controller controller;

	public Transform Paper;

	private const float PaperOpenedY = 0f;

	private const float PaperClosedY = 4.8f;

	private bool PaperClosed;

	public SpriteRenderer Shadow;

	public Transform stickCursor;

	public SpriteRenderer handSprite;

	public BoxCollider2D stickSelectionCenterPoint;

	private Vector3 selectionCenterStart;

	private BurgerTopping stickSelectedTopping;

	private bool grabbedTopping;

	private Vector3 internalCursorPos;

	public float cursorLerpSpeed;

	public float cursorHoverLerpSpeed;

	private float stackHeight;

	public override void Begin(PlayerTask task)
	{
	}

	private void SelectTopping(BurgerTopping topping)
	{
	}

	public void Update()
	{
	}

	public void TogglePaper()
	{
	}
}
