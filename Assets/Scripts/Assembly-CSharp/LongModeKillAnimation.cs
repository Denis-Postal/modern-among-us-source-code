using UnityEngine;

public class LongModeKillAnimation : OverlayKillAnimation
{
	[SerializeField]
	private SpriteRenderer killerNeck;

	[SerializeField]
	private SpriteRenderer killerHead;

	[SerializeField]
	private HatParent sideHat;

	[SerializeField]
	private VisorLayer sideVisor;

	public override void Initialize(KillOverlayInitData initData)
	{
	}
}
