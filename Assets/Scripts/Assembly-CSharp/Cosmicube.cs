using System.Collections.Generic;
using UnityEngine;

public class Cosmicube : MonoBehaviour
{
	[SerializeField]
	private CosmicubeData data;

	private CosmicubeCell startCell;

	public CosmicubeData Data => null;

	public void SetData(CosmicubeData d)
	{
	}

	public void SetMenu(CosmicubeMenu menu)
	{
	}

	public PassiveButton GetFirstCell()
	{
		return null;
	}

	public IEnumerable<PassiveButton> GetAllButtons()
	{
		return null;
	}
}
