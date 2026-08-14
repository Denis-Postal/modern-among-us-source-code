using UnityEngine;

public class DragPlayerParticles : MonoBehaviour
{
	private PlayerParticle selectedObject;

	private Vector3 offset;

	private void Update()
	{
		Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0))
		{
			Collider2D collider2D = Physics2D.OverlapPoint(vector);
			if ((bool)collider2D)
			{
				PlayerParticle component = collider2D.GetComponent<PlayerParticle>();
				if ((bool)component)
				{
					selectedObject = component;
					offset = selectedObject.transform.position - vector;
				}
			}
		}
		if (selectedObject != null)
		{
			selectedObject.transform.position = vector + offset;
		}
		if (Input.GetMouseButtonUp(0) && selectedObject != null)
		{
			selectedObject = null;
		}
	}
}
