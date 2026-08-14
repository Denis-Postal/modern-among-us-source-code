using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DraggablePartFixed : MonoBehaviour
{
	[SerializeField]
	private Collider2D collider;

	[SerializeField]
	private Transform targetPoint;

	[SerializeField]
	private GameObject brokenPart;

	[SerializeField]
	private SpriteRenderer sprite;

	[SerializeField]
	private Color finalColor;

	private Vector3 initialPosition;

	private Vector3 initialScale;

	public event Action OnNewPositionSavedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnPartPositionResetEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Initialize()
	{
	}

	public Collider2D GetCollider()
	{
		return null;
	}

	public void StartDrag()
	{
	}

	public void SnapIntoPlaceOrReset()
	{
	}

	public void UpdatePartPosition(Vector2 dragPosition)
	{
	}
}
