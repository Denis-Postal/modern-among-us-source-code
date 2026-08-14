using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuPhrasesPageCrewmateButton : AbstractQuickChatMenuPhrasesPageButton
	{
		[CompilerGenerated]
		private sealed class _003CCoSetPlayerRendererIndexes_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuickChatMenuPhrasesPageCrewmateButton _003C_003E4__this;

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
			public _003CCoSetPlayerRendererIndexes_003Ed__11(int _003C_003E1__state)
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

		[Header("Crewmate Button")]
		[SerializeField]
		private PoolablePlayer player;

		[SerializeField]
		private SpriteRenderer playerMask;

		[SerializeField]
		private Material playerMaterial;

		[SerializeField]
		private SpriteRenderer[] playerMaterialRenderers;

		[SerializeField]
		private SpriteRenderer[] playerUnmaskedRenderers;

		[SerializeField]
		private SpriteRenderer[] playerColorBackgrounds;

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

		[IteratorStateMachine(typeof(_003CCoSetPlayerRendererIndexes_003Ed__11))]
		private IEnumerator CoSetPlayerRendererIndexes()
		{
			return null;
		}

		private void OnButtonMouseOver()
		{
		}

		private void OnButtonMouseOut()
		{
		}
	}
}
