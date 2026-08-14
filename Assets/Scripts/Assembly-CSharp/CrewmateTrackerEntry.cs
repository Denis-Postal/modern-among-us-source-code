using PowerTools;
using UnityEngine;

public class CrewmateTrackerEntry : MonoBehaviour
{
	[SerializeField]
	private SpriteAnim crewmateAnimator;

	[SerializeField]
	private SpriteAnim slashAnimator;

	[SerializeField]
	private AnimationClip aliveClip;

	public bool IsKilled { get; private set; }

	public void SetKilled(CrewmateTrackerAnim anim)
	{
	}

	public void Reset()
	{
	}
}
