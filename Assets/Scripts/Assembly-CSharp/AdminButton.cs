using UnityEngine;

public class AdminButton : ActionButton
{
	[SerializeField]
	private Animator MyAnimator;

	[SerializeField]
	private AudioClip RevealSFX;

	private bool useable;

	public override void DoClick()
	{
	}

	public void Refresh()
	{
	}

	public void AnimEvent_TurnOffAnimator()
	{
	}

	public void AnimEvent_PlayRevealSFX()
	{
	}
}
