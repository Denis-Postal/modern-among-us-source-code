using UnityEngine;

public class NoShadowBehaviour : MonoBehaviour
{
	public Renderer rend;

	public bool didHit;

	public Renderer shadowChild;

	public Collider2D hitOverride;

	private BoxCollider2D bc;

	private bool isBox;

	private bool verticalBox;

	private Vector2[] boxCheckPoints;

	private const int edgePoints = 4;

	private const int totalPointsPerEdge = 6;

	public void Start()
	{
	}

	private void CalculateBoxEdgeCheckPoints()
	{
	}

	public void OnDestroy()
	{
	}

	private void SetMaskFunction(int func)
	{
	}

	internal void CheckHit(float lightRadius, Vector2 lightPosition)
	{
	}
}
