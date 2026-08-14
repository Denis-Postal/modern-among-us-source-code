using System.Collections.Generic;
using UnityEngine;

public class SlicedAspectScaler : MonoBehaviour
{
	private const float NORMAL_ASPECT = 1.777f;

	[SerializeField]
	private List<AspectScaledAsset> objectsToScale;

	[SerializeField]
	private bool updateAlways;

	private Camera parentCam;

	private void Start()
	{
	}

	private void SetParentCam()
	{
	}

	private void Update()
	{
	}
}
