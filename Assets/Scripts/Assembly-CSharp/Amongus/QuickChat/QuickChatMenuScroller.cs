using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuScroller : MonoBehaviour
	{
		public const float SCROLLBAR_WIDTH = 0.2f;

		[SerializeField]
		private Scroller scroller;

		[SerializeField]
		private Scrollbar scrollBar;

		[SerializeField]
		private SpriteRenderer track;

		[SerializeField]
		private BoxCollider2D collider;

		[SerializeField]
		private ScrollToSelection scrollToSelection;

		[SerializeField]
		[Header("Gradients")]
		private SpriteRenderer topGradient;

		[SerializeField]
		private Transform topGradientContainer;

		[SerializeField]
		[Space(10f)]
		private SpriteRenderer bottomGradient;

		[SerializeField]
		private Transform bottomGradientContainer;

		private float width;

		private float height;

		private Color topGradientColor;

		private Color bottomGradientColor;

		public bool IsVisible => false;

		private void Awake()
		{
		}

		public void SetSize(float width, float height)
		{
		}

		public void SetContentHeight(float contentHeight)
		{
		}

		private void InitializeGradient()
		{
		}

		private void UpdateGradientAlpha(float value)
		{
		}

		private static float GetPercentage(float min, float max, float input)
		{
			return 0f;
		}

		private void OnScroll(float value)
		{
		}
	}
}
