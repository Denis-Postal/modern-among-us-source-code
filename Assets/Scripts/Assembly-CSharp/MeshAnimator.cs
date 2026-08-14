using UnityEngine;

public class MeshAnimator : MonoBehaviour
{
	private MeshFilter filter;

	public Mesh[] Frames;

	public float frameRate;

	private float timer;

	private int frameId;

	private Vector3 originalPosition;

	private Vector3 originalScale;

	public MeshSequence sequence;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
