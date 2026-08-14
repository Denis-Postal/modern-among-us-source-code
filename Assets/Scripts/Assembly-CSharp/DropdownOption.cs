using System;
using TMPro;
using UnityEngine;

public class DropdownOption : PoolableBehavior
{
	[SerializeField]
	private TextMeshPro optionText;

	[SerializeField]
	private PassiveButton button;

	public UiElement ButtonUiElement => null;

	public void Initialize(string text, Action onClick, Collider2D clickMask, Vector3 position)
	{
	}

	public override void Reset()
	{
	}
}
