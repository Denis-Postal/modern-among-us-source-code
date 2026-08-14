using UnityEngine;

internal class FootstepWatcher : MonoBehaviour, IStepWatcher
{
	public int priority;

	public Collider2D Area;

	public SoundGroup Sounds;

	public int Priority => 0;

	public SoundGroup MakeFootstep(PlayerControl player)
	{
		return null;
	}
}
