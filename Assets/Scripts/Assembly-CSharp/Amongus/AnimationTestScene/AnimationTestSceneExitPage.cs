using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneExitPage : AbstractAnimationTestScenePage
	{
		[CompilerGenerated]
		private sealed class _003CCoExit_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationTestSceneExitPage _003C_003E4__this;

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
			public _003CCoExit_003Ed__7(int _003C_003E1__state)
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

		[Header("Exit Page")]
		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Button exitButton;

		[SerializeField]
		private CanvasGroup fader;

		private bool exiting;

		protected override void Awake()
		{
		}

		private void Cancel()
		{
		}

		private void Exit()
		{
		}

		[IteratorStateMachine(typeof(_003CCoExit_003Ed__7))]
		private IEnumerator CoExit()
		{
			return null;
		}

		private void SetFaderAlpha(float value)
		{
		}
	}
}
