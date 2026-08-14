using PowerTools;
using UnityEngine;

public class ReactorShipRoom : SkeldShipRoom, IReactorShipRoom
{
	public Sprite normalManifolds;

	public Sprite meltdownManifolds;

	public SpriteRenderer Manifolds;

	public AnimationClip normalReactor;

	public AnimationClip meltdownReactor;

	public SpriteAnim Reactor;

	public AnimationClip normalHighFloor;

	public AnimationClip meltdownHighFloor;

	public SpriteAnim HighFloor;

	public AnimationClip normalMidFloor;

	public AnimationClip meltdownMidFloor;

	public SpriteAnim MidFloor1;

	public SpriteAnim MidFloor2;

	public AnimationClip normalLowFloor;

	public AnimationClip meltdownLowFloor;

	public SpriteAnim LowFloor;

	public AnimationClip[] normalPipes;

	public AnimationClip[] meltdownPipes;

	public SpriteAnim[] Pipes;

	public SupressorBehaviour[] Supressors;

	public MeshRenderer Orb;

	public Rotater OrbGlass;

	public ChainBehaviour[] Arms;

	public void StartMeltdown()
	{
	}

	public void StopMeltdown()
	{
	}
}
