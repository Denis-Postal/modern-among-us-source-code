using UnityEngine;

public class SortableSample : MonoBehaviour
{
	[SerializeField]
	private Collider2D coll;

	[SerializeField]
	private bool isMushroom;

	[SerializeField]
	private float distanceAboveJar;

	[SerializeField]
	[Header("Audio")]
	private AudioClip pickUpSfx;

	[SerializeField]
	private AudioClip placeCorrectSfx;

	private Vector3 originalPosition;

	public Collider2D Collider => null;

	public bool IsMushroom => false;

	private void Start()
	{
	}

	public void StartPickUp()
	{
	}

	public void SnapBackToOriginalPosition()
	{
	}

	public void DropIntoContainer(Transform dropSpot)
	{
	}

	public void UpdatePosition(Vector3 pos)
	{
	}
}
