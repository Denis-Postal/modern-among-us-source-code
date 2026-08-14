using PowerTools;
using UnityEngine;

public class SurvCamera : MonoBehaviour
{
	public string CamName;

	public StringNames NewName;

	public SpriteAnim[] Images;

	public float CamSize;

	public float CamAspect;

	public Vector3 Offset;

	public AnimationClip OnAnim;

	public AnimationClip OffAnim;

	public StringNames camNameString;

	public void Awake()
	{
	}

	public virtual void SetAnimation(bool on)
	{
	}
}
