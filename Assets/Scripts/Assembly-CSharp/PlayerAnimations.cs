using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoPlayCustomAnimation_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerAnimations _003C_003E4__this;

		public AnimationClip customAnim;

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
		public _003CCoPlayCustomAnimation_003Ed__35(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoPlayEnterVentAnimation_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerAnimations _003C_003E4__this;

		public int numFramesUntilDisappearance;

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
		public _003CCoPlayEnterVentAnimation_003Ed__32(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoPlayExitVentAnimation_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerAnimations _003C_003E4__this;

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
		public _003CCoPlayExitVentAnimation_003Ed__33(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoPlayJumpAnimation_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerAnimations _003C_003E4__this;

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
		public _003CCoPlayJumpAnimation_003Ed__34(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoPlaySpawnAnimation_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerAnimations _003C_003E4__this;

		public bool flipX;

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
		public _003CCoPlaySpawnAnimation_003Ed__31(int _003C_003E1__state)
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
	private SpriteAnim glowAnimator;

	[SerializeField]
	private SpriteRenderer glowSpriteRenderer;

	[SerializeField]
	private List<PlayerAnimationGroup> animationGroups;

	[Header("Med Scan")]
	[SerializeField]
	private SpriteAnim[] scannerAnims;

	[SerializeField]
	private SpriteRenderer[] scannersImages;

	private PlayerAnimationGroup group;

	private PlayerBodyTypes type;

	public float Time => 0f;

	public float ShapeshiftScale => group != null ? group.ShapeshiftScale : 1f;

	public Vector3 DefaultPlayerScale => group != null ? group.defaultPlayerScale : Vector3.one;

	private SpriteAnim Animator => group != null ? group.SpriteAnimator : null;

	public void SetBodyType(PlayerBodyTypes bodyType, Vector3 flippedCosmeticOffset, Vector3 normalCosmeticOffset)
	{
		type = bodyType;
		group = null;
		if (animationGroups != null)
		{
			for (int i = 0; i < animationGroups.Count; i++)
			{
				PlayerAnimationGroup candidate = animationGroups[i];
				if (candidate == null)
				{
					continue;
				}
				bool selected = candidate.BodyType == bodyType;
				if (selected)
				{
					group = candidate;
				}
				SetAnimationGroupVisible(candidate, selected);
			}
		}
		if (group == null && animationGroups != null)
		{
			for (int i = 0; i < animationGroups.Count; i++)
			{
				if (animationGroups[i] != null && animationGroups[i].BodyType == PlayerBodyTypes.Normal)
				{
					group = animationGroups[i];
					break;
				}
			}
			if (group == null && animationGroups.Count > 0)
			{
				group = animationGroups[0];
			}
			SetAnimationGroupVisible(group, true);
		}
		UpdateCosmeticOffset(flippedCosmeticOffset, normalCosmeticOffset);
		PlayIdleAnimation();
	}

	public void UpdateCosmeticOffset(Vector3 flippedCosmeticOffset, Vector3 normalCosmeticOffset)
	{
		if (animationGroups == null)
		{
			return;
		}
		for (int i = 0; i < animationGroups.Count; i++)
		{
			PlayerAnimationGroup playerAnimationGroup = animationGroups[i];
			if (playerAnimationGroup?.NodeSyncs == null)
			{
				continue;
			}
			for (int j = 0; j < playerAnimationGroup.NodeSyncs.Count; j++)
			{
				SpriteAnimNodeSync spriteAnimNodeSync = playerAnimationGroup.NodeSyncs[j];
				if (spriteAnimNodeSync != null)
				{
					spriteAnimNodeSync.flipOffset = flippedCosmeticOffset;
					spriteAnimNodeSync.normalOffset = normalCosmeticOffset;
				}
			}
		}
	}

	public OverlayKillAnimation[] GetKillAnimations()
	{
		return group != null ? group.KillAnims : null;
	}

	public bool IsPlayingRunAnimation()
	{
		return Animator != null && group != null && Animator.IsPlaying(group.RunAnim);
	}

	public bool IsPlayingSpawnAnimation()
	{
		return Animator != null && group != null && Animator.IsPlaying(group.SpawnAnim);
	}

	public bool IsPlayingClimbAnimation()
	{
		return Animator != null && group != null && (Animator.IsPlaying(group.ClimbUpAnim) || Animator.IsPlaying(group.ClimbDownAnim));
	}

	public bool IsPlayingGuardianAngelIdleAnimation()
	{
		return Animator != null && group != null && Animator.IsPlaying(group.GhostGuardianAngelAnim);
	}

	public bool IsPlayingGhostIdleAnimation()
	{
		return Animator != null && group != null && Animator.IsPlaying(group.GhostIdleAnim);
	}

	public bool IsPlayingEnterVentAnimation()
	{
		return Animator != null && group != null && Animator.IsPlaying(group.EnterVentAnim);
	}

	public bool IsPlayingAnyLadderAnimation()
	{
		return IsPlayingClimbAnimation();
	}

	public bool IsPlayingSomeAnimation()
	{
		return Animator != null && Animator.IsPlaying();
	}

	public void PlayRunAnimation()
	{
		if (Animator != null && group != null)
		{
			Animator.Play(group.RunAnim);
		}
	}

	public void PlayIdleAnimation()
	{
		if (Animator != null && group != null)
		{
			Animator.Play(group.IdleAnim);
		}
	}

	public void PlayClimbAnimation(bool down)
	{
		if (Animator != null && group != null)
		{
			Animator.Play(down ? group.ClimbDownAnim : group.ClimbUpAnim);
		}
	}

	public void PlayGuardianAngelIdleAnimation()
	{
		if (Animator != null && group != null)
		{
			Animator.Play(group.GhostGuardianAngelAnim);
		}
	}

	public void PlayGhostIdleAnimation()
	{
		if (Animator != null && group != null)
		{
			Animator.Play(group.GhostIdleAnim);
		}
	}

	private static void SetAnimationGroupVisible(PlayerAnimationGroup animationGroup, bool visible)
	{
		if (animationGroup?.SpriteAnimator == null)
		{
			return;
		}
		Transform transform = animationGroup.SpriteAnimator.transform;
		if (transform != null)
		{
			transform.gameObject.SetActive(visible);
			Renderer[] componentsInChildren = transform.GetComponentsInChildren<Renderer>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = visible;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CCoPlaySpawnAnimation_003Ed__31))]
	public IEnumerator CoPlaySpawnAnimation(bool flipX)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoPlayEnterVentAnimation_003Ed__32))]
	public IEnumerator CoPlayEnterVentAnimation(int numFramesUntilDisappearance)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoPlayExitVentAnimation_003Ed__33))]
	public IEnumerator CoPlayExitVentAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoPlayJumpAnimation_003Ed__34))]
	public IEnumerator CoPlayJumpAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoPlayCustomAnimation_003Ed__35))]
	public IEnumerator CoPlayCustomAnimation(AnimationClip customAnim)
	{
		return null;
	}

	public void PlayScanner(bool on, bool isDead, bool flipX)
	{
	}
}
