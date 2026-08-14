using TMPro;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuLandingPageButton : MonoBehaviour
	{
		[SerializeField]
		private PassiveButton button;

		[SerializeField]
		private BoxCollider2D collider;

		[SerializeField]
		private UIScrollbarHelper scrollHelper;

		[Space(10f)]
		[SerializeField]
		private TMP_Text text;

		[SerializeField]
		private RectTransform textRect;

		[SerializeField]
		private TextTranslatorTMP translator;

		[Space(10f)]
		[SerializeField]
		private SpriteRenderer[] backgroundSprites;

		[SerializeField]
		private SpriteRenderer[] shineSprites;

		private new QuickChatTag tag;

		public QuickChatTag Tag => null;

		public PassiveButton Button => null;

		public UIScrollbarHelper ScrollHelper => null;

		public float Width => 0f;

		public float Height => 0f;

		public StringNames TranslationKey => default(StringNames);

		public virtual void Setup(int index, QuickChatTag tag)
		{
		}

		public void SetStringName(StringNames key)
		{
		}

		public void SetWidth(float width)
		{
		}
	}
}
