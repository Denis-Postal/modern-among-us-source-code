using PowerTools;
using UnityEngine;

public class ViperDeadBody : DeadBody
{
	[SerializeField]
	private AnimationClip[] dissolveAnims;

	[SerializeField]
	private SpriteRenderer acidRenderer;

	[SerializeField]
	private SpriteRenderer splashRenderer;

	[SerializeField]
	private SpriteAnim spriteAnim;

	[SerializeField]
	private AudioClip acidSplashSFX;

	private float dissolveCurrentTime;

	private float maxDissolveTime;

	private bool victimDissolving;

	private int dissolveStage;

	private PlayerControl myKiller;

	private PlayerControl myController;

	public void SetupViperInfo(float maxTime, PlayerControl killer, PlayerControl owner)
	{
	}

	private void FixedUpdate()
	{
	}
}
