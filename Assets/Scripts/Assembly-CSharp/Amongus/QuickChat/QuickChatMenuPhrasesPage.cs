using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuPhrasesPage : AbstractQuickChatMenuPage
	{
		public delegate void PhraseSelectedHandler(QuickChatPhrase phrase);

		[CompilerGenerated]
		private sealed class _003CCoDelayedSelectFirstButton_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuickChatMenuPhrasesPage _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoDelayedSelectFirstButton_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const float BOTTOM_PADDING = 0.1f;

		private static readonly Color32 TEXT_COLOR_ENABLED;

		private static readonly Color32 TEXT_COLOR_DISABLED;

		[Header("UI")]
		[SerializeField]
		private QuickChatMenuScroller scroller;

		[Header("Button Templates")]
		[SerializeField]
		private QuickChatMenuPhrasesPagePhraseButton phraseButtonTemplate;

		[SerializeField]
		private QuickChatMenuPhrasesPageCrewmateButton crewmateButtonTemplate;

		[SerializeField]
		private Material defaultButtonTextMaterial;

		[Header("Input")]
		[SerializeField]
		private ControllerButtonBehavior favoriteButton;

		private AbstractQuickChatMenuPhrasesPageButton[] dynamicButtons;

		private QuickChatTag[] tags;

		private QuickChatPhrase[] phrases;

		private Material buttonTextMaterial;

		public QuickChatTag[] Tags => null;

		public QuickChatPhrase[] Phrases => null;

		public event PhraseSelectedHandler OnPhraseSelectedEvent
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

		public void ShowTagPage(float height, params QuickChatTag[] tags)
		{
		}

		public override void Hide()
		{
		}

		public void SetPhrasesEnableState(bool enabled)
		{
		}

		private void SetupContent()
		{
		}

		private void OnButtonSelected(AbstractQuickChatMenuPhrasesPageButton button)
		{
		}

		private void ClearDynamicButtons()
		{
		}

		private AbstractQuickChatMenuPhrasesPageButton CreatePhraseButton(int index, int buttonCount, float width, QuickChatPhrase phrase)
		{
			return null;
		}

		private T CreatePhraseButtonOfType<T>(T template) where T : AbstractQuickChatMenuPhrasesPageButton
		{
			return null;
		}

		private void OnFavoriteButtonPressed()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayedSelectFirstButton_003Ed__30))]
		private IEnumerator CoDelayedSelectFirstButton()
		{
			return null;
		}
	}
}
