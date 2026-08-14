using System.Collections.Generic;
using UnityEngine;

public class MapBehaviour : MonoBehaviour
{
	public static MapBehaviour Instance;

	public AlphaPulse ColorControl;

	public SpriteRenderer HerePoint;

	public SpriteRenderer TrackedHerePoint;

	public MapCountOverlay countOverlay;

	public InfectedOverlay infectedOverlay;

	public MapTaskOverlay taskOverlay;

	[SerializeField]
	private GameObject fadedBackground;

	[SerializeField]
	private GameObject detectiveMapButtonPrefab;

	private bool detectiveMapOpen;

	private SpecialInputHandler specialInputHandler;

	private bool countOverlayAllowsMovement;

	private Vector3? preMeetingPosition;

	private Vector3? trackedPreMeetingPosition;

	private int trackedColorID;

	private float trackedPointDelayTime;

	private List<UiElement> detectiveLocationControllerButtons;

	public bool IsOpen => false;

	public bool IsOpenStopped => false;

	public void SetPreMeetingPosition(Vector3 preMeetingPosition, bool trackedPlayer = false)
	{
	}

	public void Show(MapOptions opts)
	{
	}

	public void Close()
	{
	}

	public void DisableTrackerOverlays()
	{
	}

	private void Validate()
	{
	}

	private void ShowSabotageMap()
	{
	}

	private void ShowNormalMap()
	{
	}

	private void ShowDetectiveMap()
	{
	}

	private void ShowCountOverlay(bool allowedToMove, bool showLivePlayerPosition, bool includeDeadBodies)
	{
	}

	private void FixedUpdate()
	{
	}

	private void Awake()
	{
	}

	private void GenericShow()
	{
	}

	public void SetTrackedHerePointColor(int colorID)
	{
	}

	private void UpdateTrackedPosition()
	{
	}
}
