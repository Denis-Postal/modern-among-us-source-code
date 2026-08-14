using UnityEngine;

public static class PhysicsHelpers
{
	private static Collider2D[] colliderHits;

	private static RaycastHit2D[] castHits;

	private static Vector2 temp;

	private static ContactFilter2D filter;

	public static bool CircleContains(Vector2 source, float radius, int layerMask)
	{
		return false;
	}

	public static bool AnyEdgeTriggerBetween(Vector2 source, Vector2 target, int layerMask)
	{
		return false;
	}

	public static bool AnythingBetween(Vector2 source, Vector2 target, int layerMask, bool useTriggers)
	{
		return false;
	}

	public static bool AnythingBetween(Collider2D castObject, Vector2 source, Vector2 target, int layerMask, bool useTriggers)
	{
		return false;
	}

	public static bool AnyNonTriggersBetween(Vector2 source, Vector2 dirNorm, float mag, int layerMask)
	{
		return false;
	}

	public static bool AnythingBetween(Vector2 source, Vector2 target, int layerMask, bool useTriggers, Collider2D itemToIgnore, Transform objectToIgnore)
	{
		return false;
	}
}
