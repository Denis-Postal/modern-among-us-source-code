using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameOptionButton : PassiveButton
{
	[CompilerGenerated]
	private sealed class _003CDelayControllerClickUp_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOptionButton _003C_003E4__this;

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
		public _003CDelayControllerClickUp_003Ed__15(int _003C_003E1__state)
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

	private bool isInteractable;

	[SerializeField]
	[Header("Game Option Button Stuff")]
	private SpriteRenderer buttonSprite;

	[SerializeField]
	private Color interactableColor;

	[SerializeField]
	private Color interactableHoveredColor;

	[SerializeField]
	private Color interactableClickColor;

	[SerializeField]
	private Color uninteractableColor;

	[SerializeField]
	private Color uninteractableHoveredColor;

	[SerializeField]
	private Color uninteractableClickColor;

	public void SetInteractable(bool interactable)
	{
		isInteractable = interactable;
		if ((bool)buttonSprite)
		{
			buttonSprite.color = isInteractable ? interactableColor : uninteractableColor;
		}
	}

	public override void ReceiveMouseOver()
	{
		base.ReceiveMouseOver();
		AdjustHoverColors(isHovering: true);
	}

	public override void ReceiveMouseOut()
	{
		base.ReceiveMouseOut();
		AdjustHoverColors(isHovering: false);
	}

	public override void ReceiveClickUp()
	{
		if (isInteractable)
		{
			base.ReceiveClickUp();
		}
		AdjustClickedColors(clickDown: false);
	}

	public override void ReceiveClickDown()
	{
		if (isInteractable)
		{
			base.ReceiveClickDown();
		}
		AdjustClickedColors(clickDown: true);
	}

	private void AdjustHoverColors(bool isHovering)
	{
		if ((bool)buttonSprite)
		{
			buttonSprite.color = isInteractable ? (isHovering ? interactableHoveredColor : interactableColor) : (isHovering ? uninteractableHoveredColor : uninteractableColor);
		}
	}

	private void AdjustClickedColors(bool clickDown)
	{
		if ((bool)buttonSprite && clickDown)
		{
			buttonSprite.color = isInteractable ? interactableClickColor : uninteractableClickColor;
		}
	}

	[IteratorStateMachine(typeof(_003CDelayControllerClickUp_003Ed__15))]
	private IEnumerator DelayControllerClickUp()
	{
		return null;
	}
}
