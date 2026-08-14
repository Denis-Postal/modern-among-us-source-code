using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneMeetingPage : AbstractAnimationTestScenePage
	{
		[Serializable]
		public class AnimData
		{
			[SerializeField]
			private string name;

			[SerializeField]
			private MeetingCalledAnimation prefab;

			public string Name => null;

			public MeetingCalledAnimation Prefab => null;
		}

		[CompilerGenerated]
		private sealed class _003CCoShowAnimation_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationTestSceneMeetingPage _003C_003E4__this;

			public MeetingCalledAnimation animPrefab;

			private MeetingCalledAnimation _003Canim_003E5__2;

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
			public _003CCoShowAnimation_003Ed__10(int _003C_003E1__state)
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

		[Header("Meeting Page")]
		[SerializeField]
		private KillOverlay killOverlay;

		[SerializeField]
		private AnimationTestSceneButton buttonTemplate;

		[SerializeField]
		private AnimData[] meetingAnimations;

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

		private void OnAnimButtonClicked(MeetingCalledAnimation animPrefab)
		{
		}

		private void PlayMeetingAnimation(MeetingCalledAnimation animPrefab)
		{
		}

		[IteratorStateMachine(typeof(_003CCoShowAnimation_003Ed__10))]
		private IEnumerator CoShowAnimation(MeetingCalledAnimation animPrefab)
		{
			return null;
		}
	}
}
