using UnityEngine;

public class TargetFlashlight : MonoBehaviour
{
	private const float DOUBLE_CLICK_TIME = 0.3f;

	private bool isDragging;

	private float timeLastClick;

	private Controller myController;

	private Collider2D col;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
