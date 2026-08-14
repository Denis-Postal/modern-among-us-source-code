using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class RoleEffectAnimation : MonoBehaviour
{
	public enum SoundType
	{
		None = 0,
		Local = 1,
		Global = 2
	}

	public enum EffectType
	{
		Default = 0,
		ProtectLoop = 1,
		Shapeshift = 2,
		Vanish_Charge = 3,
		Vanish_Poof = 4,
		Appear_Poof = 5
	}

	[CompilerGenerated]
	private sealed class _003CCoPlay_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoleEffectAnimation _003C_003E4__this;

		public PlayerControl parent;

		public bool parentTransform;

		public bool flipX;

		public float flipXOffset;

		public SoundType soundType;

		public float duration;

		public Action onClipEnded;

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
		public _003CCoPlay_003Ed__11(int _003C_003E1__state)
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

	public EffectType effectType;

	public AnimationClip Clip;

	public SpriteAnim Animator;

	public Action MidAnimCB;

	public SpriteRenderer Renderer;

	public AudioClip UseSound;

	public AudioSource AudioSource;

	private PlayerControl parent;

	public void Play(PlayerControl parent, Action onClipEnded, bool flipX, SoundType soundType, float duration = 0f, bool parentTransform = true, float flipXOffset = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003CCoPlay_003Ed__11))]
	private IEnumerator CoPlay(PlayerControl parent, Action onClipEnded, bool flipX, SoundType soundType, float duration = 0f, bool parentTransform = true, float flipXOffset = 0f)
	{
		return null;
	}

	public void MidAnimationCallback()
	{
	}

	public void SetMaskLayerBasedOnWhoShouldSee(bool shouldBeVisible)
	{
	}

	public void SetMaterialColor(int colorId)
	{
	}

	public void PlaySound()
	{
	}

	public void ToggleRenderer(bool on)
	{
	}
}
