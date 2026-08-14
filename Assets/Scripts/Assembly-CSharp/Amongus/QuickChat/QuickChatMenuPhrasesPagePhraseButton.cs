using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuPhrasesPagePhraseButton : AbstractQuickChatMenuPhrasesPageButton
	{
		[Header("Phrase Button")]
		[SerializeField]
		private QuickChatFavoriteIcon favoriteIcon;

		public override string ButtonType => null;

		protected override void Awake()
		{
		}

		protected override float GetInitialWidth()
		{
			return 0f;
		}

		protected override void OnSetup()
		{
		}

		public override void SetEnabled(bool enabled)
		{
		}

		public void ToggleFavorite()
		{
		}

		private void OnFavoritePressed()
		{
		}
	}
}
