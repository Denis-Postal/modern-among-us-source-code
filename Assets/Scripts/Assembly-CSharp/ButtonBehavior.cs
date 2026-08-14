using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : UiElement
{
	public bool OnUp;

	public bool OnDown;

	public bool Repeat;

	public Button.ButtonClickedEvent OnClick;

	private Controller myController;

	private Collider2D[] colliders;

	private float downTime;

	public SpriteRenderer spriteRenderer;

	private bool checkedClickEvent;

	public void OnEnable()
	{
	}

	public void Update()
	{
	}

	public void ReceiveClick()
	{
	}
}
