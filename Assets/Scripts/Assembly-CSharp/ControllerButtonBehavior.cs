using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class ControllerButtonBehavior : MonoBehaviour
{
	public RewiredConstsEnum.Action Action;

	public GameObject requiredMenuObject;

	public List<string> requiredMenuNames;

	public List<string> restrictedMenuNames;

	public UiElement requiredSelectedObject;

	private Player player;

	public event Action OnPressedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
