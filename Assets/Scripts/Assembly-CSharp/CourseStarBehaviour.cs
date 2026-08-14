using UnityEngine;

public class CourseStarBehaviour : MonoBehaviour
{
	public SpriteRenderer Upper;

	public SpriteRenderer Lower;

	public float Speed = 30f;

	public void Update()
	{
		if (Upper != null)
		{
			Upper.transform.Rotate(0f, 0f, Time.deltaTime * Speed);
		}
		if (Lower != null)
		{
			Lower.transform.Rotate(0f, 0f, Time.deltaTime * Speed);
		}
	}
}
