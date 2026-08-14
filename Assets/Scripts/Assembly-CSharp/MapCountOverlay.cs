using TMPro;
using UnityEngine;

public class MapCountOverlay : MonoBehaviour
{
	public AlphaPulse BackgroundColor;

	public TextMeshPro SabotageText;

	public CounterArea[] CountAreas;

	private readonly Collider2D[] buffer;

	private ContactFilter2D filter;

	private float timer;

	private bool isSab;

	private bool showLivePlayerPosition;

	private bool includeDeadBodies;

	public void SetOptions(bool showLivePlayerPosition, bool includeDeadBodies)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
