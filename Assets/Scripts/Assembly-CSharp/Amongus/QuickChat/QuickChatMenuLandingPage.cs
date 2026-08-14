using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuLandingPage : AbstractQuickChatMenuPage
	{
		public delegate void OnButtonPressedHandler(QuickChatMenuLandingPageButton button);

		[SerializeField]
		private QuickChatMenuLandingPageButton favoritesButton;

		[SerializeField]
		private QuickChatMenuLandingPageButton remarksButton;

		[SerializeField]
		private Transform contentBlocker;

		[Header("List")]
		[SerializeField]
		private Transform listContainer;

		[SerializeField]
		private QuickChatMenuScroller scroller;

		[SerializeField]
		private QuickChatMenuLandingPageButton buttonTemplate;

		private QuickChatMenuLandingPageButton[] dynamicButtons;

		public override PassiveButton DefaultSelection => null;

		public event OnButtonPressedHandler OnButtonPressed
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

		public override void Initialize(QuickChatMenu menu, float width)
		{
		}

		public override void Show(float height)
		{
		}

		public override void Hide()
		{
		}

		private void SetupContent()
		{
		}

		private QuickChatMenuLandingPageButton CreateDynamicButton()
		{
			return null;
		}

		private void OnRemarksButtonClicked()
		{
		}

		private void OnFavoritesButtonClicked()
		{
		}

		private void OnDynamicButtonClicked(QuickChatMenuLandingPageButton button)
		{
		}
	}
}
