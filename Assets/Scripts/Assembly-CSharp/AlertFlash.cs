using UnityEngine;

public class AlertFlash : MonoBehaviour
{
	private const string FLASH_TRIGGER = "OnFlash";

	private const string OVERLAY_BOOL = "Overlay";

	[SerializeField]
	[Range(0f, 1f)]
	private float opacity;

	[SerializeField]
	[Space(10f)]
	private Animator animator;

	[SerializeField]
	private MeshRenderer screenSpaceRenderer;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void Flash()
	{
	}

	public void SetOverlay(bool enabled)
	{
	}
}
