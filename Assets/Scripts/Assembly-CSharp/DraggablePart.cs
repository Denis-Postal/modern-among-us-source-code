using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DraggablePart : MonoBehaviour
{
	[SerializeField]
	private Collider2D collider;

	[SerializeField]
	private SpriteRenderer targetSprite;

	private Vector3 initialPosition;

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

	public void SnapIntoPlaceOrReset()
	{
	}

	public void UpdatePartPosition(Vector2 dragPosition)
	{
	}
}
