using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class VertLineBehaviour : MonoBehaviour
{
	public int NumPoints;

	public FloatRange Width;

	public FloatRange Height;

	private Mesh mesh;

	private MeshRenderer rend;

	private Vector3[] vecs;

	public float Duration;

	private float timer;

	public int Offset;

	public int beats;

	public int beatPadding;

	public Color color
	{
		set
		{
		}
	}

	public void Awake()
	{
	}

	public void Update()
	{
	}

	public void SetAlive()
	{
	}

	public void SetDead()
	{
	}
}
