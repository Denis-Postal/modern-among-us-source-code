using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenu : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoAnimate_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuickChatMenu _003C_003E4__this;

			public AnimationCurve animation;

			public float from;

			public float to;

			public Action onCompleteCallback;

			private float _003Cduration_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CCoAnimate_003Ed__68(int _003C_003E1__state)
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

		public const float WIDTH_DEFAULT = 3.5f;

		public const float WIDTH_MIN = 2.5f;

		public const float PADDING_X = 0.2f;

		public static readonly Logger Logger;

		[SerializeField]
		private QuickChatData data;

		[SerializeField]
		private Transform container;

		[SerializeField]
		private SpriteRenderer frame;

		[Space(10f)]
		[SerializeField]
		private Transform topContentBlocker;

		[SerializeField]
		private Transform bottomContentBlocker;

		[Space(10f)]
		[SerializeField]
		private PassiveButton closeButton;

		[SerializeField]
		private GameObject closeButtonGlyph;

		[Header("Animations")]
		[SerializeField]
		private AnimationCurve animationIn;

		[SerializeField]
		private AnimationCurve animationOut;

		[SerializeField]
		[Header("Pages")]
		private Transform pagesContainer;

		[SerializeField]
		private QuickChatMenuLandingPage landingPage;

		[SerializeField]
		private QuickChatMenuPhrasesPage phrasesPage;

		[Header("Header")]
		[SerializeField]
		private QuickChatMenuHeader header;

		[SerializeField]
		private QuickChatMenuVoteTimer timer;

		private QuickChatPhraseBuilder builder;

		private List<QuickChatBreadcrumb> breadcrumbs;

		private IEnumerator animationCoroutine;

		private bool isOpen;

		private float height;

		private float width;

		private float targetXPos;

		public QuickChatData Data => null;

		public bool IsOpen => false;

		public bool IsAnimating => false;

		public bool IsEmpty => false;

		public bool CanSend => false;

		public Vector3 WorldPosition => default(Vector3);

		private bool IsTimerVisible => false;

		private float TargetXClosed => 0f;

		private float TargetXOpen => 0f;

		public event Action OnOpenEvent
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

		public event Action OnCloseEvent
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

		public event QuickChatPhraseBuilder.ChangeHandler OnBuilderChangedEvent
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

		public void Clear()
		{
		}

		public void Undo()
		{
		}

		public void UpdateVoteTimerText(StringNames key, int value)
		{
		}

		private void InitializeChildren()
		{
		}

		private void OnCloseButtonPressed()
		{
		}

		public QuickChatPhraseBuilderResult BuildMessageData()
		{
			return null;
		}

		public void BuildMessageLog(StringBuilder log)
		{
		}

		public bool CanAddPhraseToBuilder(QuickChatPhrase p)
		{
			return false;
		}

		private void OnBuilderChanged(QuickChatPhraseBuilder builder)
		{
		}

		public void Open(float width)
		{
		}

		public void Close()
		{
		}

		public void CloseImmediately()
		{
		}

		private void OnCloseComplete()
		{
		}

		private void StopAnimationCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CCoAnimate_003Ed__68))]
		private IEnumerator CoAnimate(float from, float to, AnimationCurve animation, Action onCompleteCallback = null)
		{
			return null;
		}

		private void SetAnimationParameters(float value)
		{
		}

		private void UpdateContainerTransform()
		{
		}

		private float GetPageHeight()
		{
			return 0f;
		}

		private void UpdatePagePosition()
		{
		}

		private void UpdatePageBlockers()
		{
		}

		private void ShowLandingPage()
		{
		}

		private void OnLandingPageTagButtonPressed(QuickChatMenuLandingPageButton button)
		{
		}

		private void ShowPhrasePage(params QuickChatTag[] tags)
		{
		}

		private void OnPhraseSelected(QuickChatPhrase phrase)
		{
		}

		private void OnHeaderBackButtonPressed()
		{
		}

		private void OnPhrasesTopMenuButtonPressed()
		{
		}
	}
}
