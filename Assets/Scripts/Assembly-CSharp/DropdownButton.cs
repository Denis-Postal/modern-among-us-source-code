using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownButton : MonoBehaviour
{
	[SerializeField]
	private float buttonStartY;

	[SerializeField]
	private float buttonHeight;

	[SerializeField]
	private GameObject optionsScreen;

	[SerializeField]
	private PassiveButton openOptionsButton;

	[SerializeField]
	private PassiveButton closeButton;

	[SerializeField]
	private TextMeshPro buttonText;

	[SerializeField]
	private Collider2D clickMask;

	[SerializeField]
	private ObjectPoolBehavior optionPool;

	private List<string> options;

	private Action<int> onOptionSelect;

	public int SelectedIndex { get; private set; }

	private string DropdownName => null;

	public void AddOption(string optionName)
	{
	}

	public void SetSelectedIndex(int i)
	{
	}

	public void SetOnOptionSelect(Action<int> onOptionSelect)
	{
	}

	private void Start()
	{
	}

	private void OpenDropdownOptions()
	{
	}

	private void SelectOption(int buttonIndex)
	{
	}

	private void Close()
	{
	}
}
