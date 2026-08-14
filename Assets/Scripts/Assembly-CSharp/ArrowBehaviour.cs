using UnityEngine;

public class ArrowBehaviour : PoolableBehavior
{
	public Vector3 target;

	public float perc;

	public float MaxScale;

	public bool alwaysMaxSize;

	protected float minDistanceToShowArrow;

	[HideInInspector]
	public SpriteRenderer image;

	public new virtual void Awake()
	{
	}

	public void Update()
	{
	}

	public virtual void UpdatePosition()
	{
	}

	public virtual void SetImageEnabled(bool isOn)
	{
	}

	protected bool Between(float value, float min, float max)
	{
		return false;
	}

	protected virtual void CloseBehaviour(Vector2 del, float delLen)
	{
	}

	protected virtual void DistancedBehaviour(Vector2 vpPoint, Vector2 del, float delLen, Camera cam)
	{
	}
}
