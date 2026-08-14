using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugToolOverlay : MonoBehaviour
	{
		[SerializeField]
		private GameObject rootUI;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button backButton;

		[SerializeField]
		[Header("Tabs")]
		private DebugTabButton[] tabButtons;

		[SerializeField]
		private DebugToolOverlayPage[] pages;

		private readonly List<IDebugToolInputProvider> inputProviders;

		private int activeTabIndex;

		private int totalTabs;

		private bool UIVisible => false;

		private bool SubpageShowingDetails => false;

		private DebugToolOverlayPage ActivePage => null;

		private bool SubpageConsumingNavActions => false;

		private event Action<bool> OnToggle
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

		private void Awake()
		{
		}

		private void ShowPage(string pageName)
		{
		}

		private void Update()
		{
		}

		public void RegisterInputProvider(IDebugToolInputProvider provider)
		{
		}

		public void RegisterKeyboardInputProvider(IDebugToolKeyboardInputProvider provider)
		{
		}

		public void AddToggleActiveCallback(Action<bool> action)
		{
		}

		public void Initialize()
		{
		}

		public void ToggleUIVisible(bool visible)
		{
		}

		private void ToggleBackButtonActive(bool active)
		{
		}
	}
}
