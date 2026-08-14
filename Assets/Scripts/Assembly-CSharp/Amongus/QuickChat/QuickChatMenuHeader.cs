using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuHeader : MonoBehaviour
	{
		private const float PADDING = 0.2f;

		private const float TEXT_LINE_HEIGHT = 0.5f;

		private const float DIVIDER_OFFSET = -0.11f;

		private const StringNames DEFAULT_HEADER = StringNames.QCBuilderHeader;

		[SerializeField]
		private Transform content;

		[Space(10f)]
		[SerializeField]
		private TextMeshPro text;

		[SerializeField]
		private Transform textMask;

		[SerializeField]
		private Transform textGradient;

		[Space(10f)]
		[SerializeField]
		private PassiveButton backButton;

		[SerializeField]
		private BoxCollider2D backButtonCollider;

		[SerializeField]
		[Space(10f)]
		private Transform divider;

		[Space(10f)]
		[SerializeField]
		private GameObject favoriteBox;

		[SerializeField]
		private GameObject favoriteBoxContainer;

		[SerializeField]
		private GameObject favoriteBoxGlyph;

		[SerializeField]
		private SpriteRenderer favoriteBoxBackground;

		private float width;

		private float height;

		private float defaultFontSize;

		public float Height => 0f;

		public event Action OnBackPressedEvent
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

		private void Update()
		{
		}

		public void Initialize(float width)
		{
		}

		public void ShowLandingPage()
		{
		}

		public void ShowPhrasesPage(List<QuickChatBreadcrumb> breadcrumbs)
		{
		}

		private void UpdateSize()
		{
		}

		private void SetFavoriteGlyphBox(bool enabled)
		{
		}

		private string ClampTextToBounds(string input)
		{
			return null;
		}

		private void OnBackPressed()
		{
		}
	}
}
