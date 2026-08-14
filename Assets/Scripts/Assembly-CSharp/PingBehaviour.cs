using UnityEngine;

public class PingBehaviour : ArrowBehaviour
{
	[SerializeField]
	private AudioClip soundOnEnable;

	public bool AmSeeker;

	public override void Awake()
	{
	}

	public override void UpdatePosition()
	{
	}

	protected override void CloseBehaviour(Vector2 del, float delLen)
	{
	}

	public override void SetImageEnabled(bool isOn)
	{
	}
}
