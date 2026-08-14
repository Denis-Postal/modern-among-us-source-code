using UnityEngine;

public class SensorDoor : MonoBehaviour
{
	public SpriteRenderer LeftSide;

	public SpriteRenderer RightSide;

	public float ActivationDistance;

	public bool Opening;

	public float OpenDuration;

	private float openTimer;

	public AudioClip OpenSound;

	public AudioClip CloseSound;

	private const float slideVibrationIntensity = 3f;

	public void OnEnable()
	{
	}

	[ContextMenu("Set Right Uvs")]
	public void SetUvs()
	{
	}

	private void Update()
	{
	}

	private void CheckDoor()
	{
	}
}
