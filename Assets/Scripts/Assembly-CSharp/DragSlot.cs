using UnityEngine;

public class DragSlot : MonoBehaviour
{
	public Vector3 Offset;

	public Behaviour Occupant;

	public Vector3 TargetPosition => default(Vector3);
}
