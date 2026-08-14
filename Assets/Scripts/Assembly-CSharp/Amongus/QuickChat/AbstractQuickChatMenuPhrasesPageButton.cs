using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public abstract class AbstractQuickChatMenuPhrasesPageButton : MonoBehaviour
	{
		public delegate void ButtonClickedHandler(AbstractQuickChatMenuPhrasesPageButton button);

		private const int MASK_LAYER_INDEX_START = 145;

		[SerializeField]
		private PassiveButton button;

		[SerializeField]
		private BoxCollider2D collider;

		[SerializeField]
		private UIScrollbarHelper scrollHelper;

		[SerializeField]
		[Space(10f)]
		private TextMeshPro text;

		[SerializeField]
		private RectTransform textRect;

		[Space(10f)]
		[SerializeField]
		private SpriteRenderer arrow;

		[SerializeField]
		private SpriteRenderer[] backgroundSprites;

		private QuickChatPhrase phrase;

		private int index;

		private int buttonCount;

		private float width;

		private Material textMaterial;

		public QuickChatPhrase Phrase => null;

		public PassiveButton Button => null;

		public UIScrollbarHelper ScrollHelper => null;

		public float Width => 0f;

		public float Height => 0f;

		public int MaskLayer => 0;

		protected TextMeshPro Text => null;

		protected Material TextMaterial => null;

		protected RectTransform TextRect => null;

		protected BoxCollider2D Collider => null;

		protected SpriteRenderer Arrow => null;

		protected SpriteRenderer[] BackgroundSprites => null;

		public abstract string ButtonType { get; }

		public event ButtonClickedHandler OnSelectedEvent
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

		protected virtual void Awake()
		{
		}

		protected abstract void OnSetup();

		protected abstract float GetInitialWidth();

		public void Setup(int index, int buttonCount, float width, QuickChatPhrase phrase, Material textMaterial)
		{
		}

		public void SetWidth(float width)
		{
		}

		public virtual void SetEnabled(bool enabled)
		{
		}

		private void OnButtonPressed()
		{
		}
	}
}
