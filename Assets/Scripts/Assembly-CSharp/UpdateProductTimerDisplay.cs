using TMPro;
using UnityEngine;

public class UpdateProductTimerDisplay : MonoBehaviour
{
	private const float TimeBetweenRefresh = 1f;

	public TextMeshPro Tmp;

	private IBuyable currentProduct;

	private float lastUpdate;

	[SerializeField]
	private bool DisplayShort;

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetProduct(IBuyable product)
	{
	}

	private void RefreshTimer()
	{
	}
}
