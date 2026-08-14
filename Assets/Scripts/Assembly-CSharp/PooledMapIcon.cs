using UnityEngine;

public class PooledMapIcon : PoolableBehavior
{
	public float NormalSize;

	public int lastMapTaskStep;

	public SpriteRenderer rend;

	public AlphaPulse alphaPulse;

	public void Update()
	{
	}

	public override void Reset()
	{
	}
}
