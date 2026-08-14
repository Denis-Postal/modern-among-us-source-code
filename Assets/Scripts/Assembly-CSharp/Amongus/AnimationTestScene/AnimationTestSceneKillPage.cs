using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneKillPage : AbstractAnimationTestScenePage
	{
		[Serializable]
		public class AnimData
		{
			[SerializeField]
			private string name;

			[SerializeField]
			private OverlayKillAnimation prefab;

			public string Name => null;

			public OverlayKillAnimation Prefab => null;
		}

		[CompilerGenerated]
		private sealed class _003CCoShowAnimation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationTestSceneKillPage _003C_003E4__this;

			public OverlayKillAnimation animPrefab;

			public KillOverlayInitData initData;

			private OverlayKillAnimation _003Canim_003E5__2;

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
			public _003CCoShowAnimation_003Ed__14(int _003C_003E1__state)
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

		[SerializeField]
		[Header("Kill Page")]
		private Transform genericButtonContainer;

		[SerializeField]
		private Transform cosmeticButtonContainer;

		[SerializeField]
		private KillOverlay killOverlay;

		[SerializeField]
		private AnimationTestSceneButton buttonTemplate;

		[FormerlySerializedAs("killAnimations")]
		[SerializeField]
		private AnimData[] genericKillAnimations;

		[SerializeField]
		private AnimData[] cosmeticKillAnimations;

		private List<AnimationTestSceneButton> buttons;

		protected override void OnShow()
		{
		}

		protected override void OnHide()
		{
		}

		private void ClearButtons()
		{
		}

		private void InitializeButtons()
		{
		}

		private void CreateButton(AnimData anim, Transform parent)
		{
		}

		private void OnAnimButtonClicked(OverlayKillAnimation animPrefab)
		{
		}

		private void PlayKillAnim(OverlayKillAnimation animPrefab)
		{
		}

		[IteratorStateMachine(typeof(_003CCoShowAnimation_003Ed__14))]
		private IEnumerator CoShowAnimation(OverlayKillAnimation animPrefab, KillOverlayInitData initData)
		{
			return null;
		}
	}
}
